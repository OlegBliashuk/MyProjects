using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Brows
{
    public partial class Form1 : Form
    {
        int maxbytes = 0;
        int copied = 0;
        int total = 0;
        string sourceDirectory;
        string targetDirectory;

        public Form1()
        {
            InitializeComponent();
            CopyFrom.Click += CopyFrom_Click;
            CopyIn.Click += CopyIn_Click;
            StartB.Click += StartB_Click;
            ExB.Click += ExB_Click;
            CopyF.Click += CopyF_Click;

        }


        private void ExB_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void CopyF_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxFfrom.Text = openFileDialog1.FileName;
                BrowsFrom.SelectedPath = openFileDialog1.FileName;

            }
        }
        private void CopyFrom_Click(object sender, EventArgs e)
        {

            if (BrowsFrom.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxfrom.Text = BrowsFrom.SelectedPath;
                sourceDirectory = BrowsFrom.SelectedPath;
            }
        }

        private void CopyIn_Click(object sender, EventArgs e)
        {
            if (BrowsTo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxin.Text = BrowsTo.SelectedPath;
                targetDirectory = BrowsTo.SelectedPath;
            }
        }
        void TreadList()
        {
            Thread t = new Thread(new ThreadStart(Copy1));
            t.IsBackground = true;
            t.Start();

        }
        private void StartB_Click(object sender, EventArgs e)
        {
            TreadList();
        }


        public void Copy1()
        {
            if (File.Exists(sourceDirectory))
            {
                DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
                DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);
                if (Directory.Exists(targetDirectory) == true)
                {
                    Directory.CreateDirectory(targetDirectory);
                    File.Copy(sourceDirectory, Path.Combine(targetDirectory, Path.GetFileName(sourceDirectory)));

                }
                else
                {
                    File.Copy(sourceDirectory, Path.Combine(targetDirectory, Path.GetFileName(sourceDirectory)));
                    listBox1.Items.Add(targetDirectory + "________" + "скопирован");
                }


                /*total += (int)File.;

                copied += (int)File.Length;
                copied /= 1024;
                progressBar1.Step = copied;

                progressBar1.PerformStep();
                label1.Text = (total / 1048576).ToString() + "MB of " + (maxbytes / 1024).ToString() + "MB copied";

                label1.Refresh();*/

            }
            else
            {
                DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
                DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);
                //Получает размер всех файлов, присутствующих в исходной папке.
                GetSize(diSource, diTarget);
                maxbytes = maxbytes / 1024;
                this.progressBar1.BeginInvoke(
    (MethodInvoker)delegate()
                {
                    this.progressBar1.Maximum = maxbytes;
                });


                CopyAll(diSource, diTarget);
            }
        }

        public void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {

            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            foreach (FileInfo fi in source.GetFiles())
            {
                try
                {
                    fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);

                }
                catch
                {
                  this.BeginInvoke(new Action(()=>  listBox1.Items.Add(target.FullName + "________" + "нельзя скопировать, так как нет прав доступа")));
                }
                total += (int)fi.Length;

                copied += (int)fi.Length;
                copied /= 1024;
                this.progressBar1.BeginInvoke(
    (MethodInvoker)delegate()
    {
        this.progressBar1.Value += copied;
    });


                this.label1.BeginInvoke((MethodInvoker)delegate()
                {
                this.label1.Text = (total / 1048576).ToString() + "MB of " + (maxbytes / 1024).ToString() + "MB copied";
                });
                this.listBox1.BeginInvoke((MethodInvoker)delegate()
                {
                    this.listBox1.Items.Add(fi.Name + "________" + "скопирован");
                    this.label1.Refresh();
                });


                
            }

            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
            MessageBox.Show("Готово");
        
        }
        public void GetSize(DirectoryInfo source, DirectoryInfo target)
        {
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }
            try
            {

                foreach (FileInfo fi in source.GetFiles())
                {
                    maxbytes += (int)fi.Length;//Размер файла
                }
            }
            catch
            {
                listBox1.Items.Add(target.FullName + "________" + "нельзя скопировать, так как нет прав доступа");
            }
            try
            {
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                    GetSize(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch
            {
                this.BeginInvoke( new Action(()=>
                listBox1.Items.Add(target.FullName + "________" + "нельзя скопировать, так как нет прав доступа")));
            }


        }

        private void StartB_Click_1(object sender, EventArgs e)
        {

        }

        private void mapControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
