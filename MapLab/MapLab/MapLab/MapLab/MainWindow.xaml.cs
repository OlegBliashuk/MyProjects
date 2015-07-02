using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using MapLab.Annotations;

using Microsoft.Win32;

using WcfService;

namespace MapLab
{
	/// <summary>
	///     Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		#region Fields

		private byte[] _image;

		private readonly ObservableCollection<LabelData> _listMarks = new ObservableCollection<LabelData>();

		private string _inform;

		private string _labelName;

		private string _imadres;

		private double _latitude;

		private double _longitude;

		#endregion

		#region Constructors and Destructors

		public MainWindow()
		{
			Init();
			InitializeComponent();
			Closing += MainWindow_Closing;
		}

		#endregion

		#region Public Properties

		public IEnumerable<LabelData> LabelList
		{
			get
			{
				return _listMarks;
			}
		}

		#endregion

		#region Public Methods and Operators

		private static void ClearBuffer()
		{
			try
			{																																						   
				string linkAssembly = Assembly.GetExecutingAssembly().Location;
				string link = new FileInfo(linkAssembly).DirectoryName;

				if (link != null && !Directory.Exists(link))
				{
					return;
				}
				if (link != null)
				{
					var directory = new DirectoryInfo(Path.Combine(link, "Images"));
					foreach (FileInfo file in directory.GetFiles())
					{
						try
						{
							file.Delete();
						}
						catch 
						{
						}
					}
					if (!directory.GetFiles().Any())
					{
						directory.Delete();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Deleted failed, message:" + ex.Message, "");
			}
		}

		private void Init()
		{
			//read from DB
			List<Labels> s = LabelsDo.ShowAll();
			ListReload(s);
		}

		private ObservableCollection<LabelData> ListReload(List<Labels> inp)
		{
			string linkAssembly = Assembly.GetExecutingAssembly().Location;
			var directoryName = new FileInfo(linkAssembly).DirectoryName;
			if (directoryName != null)
			{
				string link = Path.Combine(directoryName, "Images");
				if (!Directory.Exists(link))
				{
					Directory.CreateDirectory(link);
				}

				foreach (Labels i in inp)
				{
					var j = new LabelData();
					j.Name = i.Name;
					j.Information = i.Information;
					j.Latitude = i.Latitude.ToString().Replace(',', '.');
					j.Longitude = i.Longitude.ToString().Replace(',', '.');
					var fs = new FileStream(
						string.Format("{0}\\{1}", link, Guid.NewGuid() + ".jpg"), FileMode.OpenOrCreate,
						FileAccess.ReadWrite);
					var bw = new BinaryWriter(fs);
					bw.Write(i.Image);
					j.Image = fs.Name;
					bw.Close();
					fs.Close();
					_listMarks.Add(j);
				}
			}
			return _listMarks;
		}

		#endregion

		#region Methods

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			try
			{
				_latitude = Convert.ToDouble(Latitude.Text);
				_longitude = Convert.ToDouble(Longitude.Text);
			}
			catch
			{
				ErrorListBox.Items.Add("!!!Enter coordinates!!!");
			}

			_inform = InfBox.Text;
			_labelName = NamL.Text;
			if ((_latitude > 180 || _latitude < -180) || (_longitude > 180 || _longitude < -180))
			{
				ErrorListBox.Items.Add(
					"Not correctly entered coordinates,\n" +
					" please check {-180, 180}.");
			}
			else
			{
				if (_inform.Count() == 0 ||_labelName.Count() == 0)
				{
					ErrorListBox.Items.Add(
						"!!!Please enter the name \n" +
						"and information of label!!!");
				}
				else
				{
					if (_image != null)
					{
						LabelsDo.SaveLabel(_latitude, _longitude, _inform,_labelName, _image);
						ErrorListBox.Items.Add("!!!Label added!!!");
						Init();
					}
					else
					{
						ErrorListBox.Items.Add("!!!Choice the image please!!!");
					}
				}
			}
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			// Create OpenFileDialog
			var dlg = new OpenFileDialog();

			// Set filter for file extension and default file extension
			dlg.DefaultExt = ".jpg" + ".png" + ".bmp";
			dlg.Filter = "Image files (*.bmp, *.jpg, *.png)|*.bmp;*.png;*.jpg";

			// Display OpenFileDialog by calling ShowDialog method
			bool? result = dlg.ShowDialog();

			// Get the selected file name and display in a TextBox
			if (result == true)
			{
				// Open document
				_imadres = dlg.FileName;

				MemoryStream mem;
				_image = File.ReadAllBytes(_imadres);
				mem = new MemoryStream(_image);
				var bi3 = new BitmapImage();
				bi3.BeginInit();
				bi3.UriSource = new Uri(_imadres, UriKind.Absolute);
				bi3.EndInit();
				var thumbImage = new BitmapImage();
				thumbImage.BeginInit();
				thumbImage.CacheOption = BitmapCacheOption.Default;
				thumbImage.CreateOptions = BitmapCreateOptions.None;
				thumbImage.DecodePixelWidth = 60;
				thumbImage.DecodePixelHeight = 60;
				thumbImage.UriSource = new Uri(_imadres, UriKind.Absolute);

				thumbImage.StreamSource = mem;
				thumbImage.EndInit();
				mem.Close();

				sp.Stretch = Stretch.Fill;
				sp.Source = thumbImage;
			}
		}

		private void LabMapControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			Latitude.Text = VectorLayer.ScreenToGeoPoint(e.GetPosition(VectorLayer)).Latitude.ToString();
			Longitude.Text = VectorLayer.ScreenToGeoPoint(e.GetPosition(VectorLayer)).Longitude.ToString();
		}

		private void MainWindow_Closing(object sender, CancelEventArgs e)
		{
			ClearBuffer();
		}

		#endregion

		public class LabelData : INotifyPropertyChanged
		{
			#region Fields

			private string _name;

			private string _image;

			private string _information;

			private string _latitude;

			private string _longitude;

			#endregion

			#region Public Events

			public event PropertyChangedEventHandler PropertyChanged;

			#endregion

			#region Public Properties

			public string Image
			{
				get
				{
					return _image;
				}

				set
				{
					if (value != _image)
					{
						_image = value;
						NotifyPropertyChanged();
					}
				}
			}

			public string Information
			{
				get
				{
					return _information;
				}

				set
				{
					if (value != _information)
					{
						_information = value;
						NotifyPropertyChanged();
					}
				}
			}

			public string Latitude
			{
				get
				{
					return _latitude;
				}

				set
				{
					if (value != _latitude)
					{
						_latitude = value;
						NotifyPropertyChanged();
					}
				}
			}

			public string Longitude
			{
				get
				{
					return _longitude;
				}

				set
				{
					if (value != _longitude)
					{
						_longitude = value;
						NotifyPropertyChanged();
					}
				}
			}

			public string Name
			{
				get
				{
					return _name;
				}

				set
				{
					if (value != _name)
					{
						_name = value;
						NotifyPropertyChanged();
					}
				}
			}

			#endregion

			#region Methods

			[NotifyPropertyChangedInvocator]
			protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
			{
				PropertyChangedEventHandler handler = PropertyChanged;
				if (handler != null)
				{
					handler(this, new PropertyChangedEventArgs(propertyName));
				}
			}

			#endregion
		}
	}
}