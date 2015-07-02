using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WcfService
{
	public class TableContext : DbContext
	{
		#region Public Properties

		public DbSet<Labels> Labels
		{
			get;
			set;
		}

		#endregion
	}

	public class Labels
	{
		#region Public Properties

		public Byte[] Image
		{
			get;
			set;
		}

		public string Information
		{
			get;
			set;
		}

		[Key]
		public int LabelId
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public double Latitude
		{
			get;
			set;
		}

		public double Longitude
		{
			get;
			set;
		}

		#endregion
	}
}