using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace WcfService.Migrations
{
	using System;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<TableContext>
	{
		#region Constructors and Destructors

		public Configuration()
		{
			AutomaticMigrationDataLossAllowed = true;
			ContextKey = "TableContext";
		}

		#endregion

		#region Methods

		protected override void Seed(TableContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//
		}

		#endregion
	}
}