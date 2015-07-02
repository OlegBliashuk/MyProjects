using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace WcfService
{
	public static class LabelsDo
	{

		public static List<Labels> ShowAll()
		{
			Database.SetInitializer<TableContext>(null);
			var db = new TableContext();
			var query = from s in db.Labels
						select s;
			return query.ToList();
		}

		public static void SaveLabel(double valx, double valy, string inform, string name, byte[] madress)
		{
			using (var db = new TableContext())
			{
				Database.SetInitializer<TableContext>(null);
				var lab = new Labels
				{
					Name = name,
					Latitude = valx,
					Longitude = valy,
					Information = inform,
					Image = madress
				};

				db.Labels.Add(lab);

				db.SaveChanges();

			}
		}
	}
}
