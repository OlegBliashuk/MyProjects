using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace ForTables
{
    public class TempBase
    {
        public static string GetTemp(string NameColum)
        {
            string vall;
            Database.SetInitializer<TablesContext>(null);
            var db = new TablesContext();
            var nfsdf = db.Temp.Where(x => x.NameV == NameColum).Select(x => x.Value).FirstOrDefault();
            return nfsdf;
        }
        public static void RefreshTemp()
        {/*
            using (var db = new TablesContext())
            {
                while (db.Temp.Any())
                {
                    
                    db.Temp.Remove(db.Temp.First());
                }
                db.SaveChanges();
                */
            var db = new TablesContext();
                db.Database.ExecuteSqlCommand("DELETE FROM Temps WHERE NameV = 'surn'");
                db.Database.ExecuteSqlCommand("DELETE FROM Temps WHERE NameV = 'nam'");
                db.Database.ExecuteSqlCommand("DELETE FROM Temps WHERE NameV = 'secNam'");
                db.Database.ExecuteSqlCommand("DELETE FROM Temps WHERE NameV = 'DateB'");
                db.Database.ExecuteSqlCommand("DELETE FROM Temps WHERE NameV = 'DateS'");
                db.Database.ExecuteSqlCommand("DELETE FROM Temps WHERE NameV = 'Sal'");
                db.Database.ExecuteSqlCommand("DELETE FROM Temps WHERE NameV = 'expir'");
                db.Database.ExecuteSqlCommand("DELETE FROM Temps WHERE NameV = 'posit'");
                 
                
            //}
        }

        public static void ToDisk(string surn, string nam, string secNam,
            string DateB, string DateS, int Sal,
            string expir, string posit)
        {
            using (var db = new TablesContext())
            {
                Database.SetInitializer<TablesContext>(null);
                var serm = new Temp();
                serm.NameV = "surn";
                serm.Value = surn;
                db.Temp.Add(serm);


                var nem = new Temp();
                nem.NameV = "nam";
                nem.Value = nam;
                db.Temp.Add(nem);


                var sec = new Temp();
                sec.NameV = "secNam";
                sec.Value = secNam;
                db.Temp.Add(sec);


                var dbirth = new Temp();
                dbirth.NameV = "DateB";
                dbirth.Value = DateB;
                db.Temp.Add(dbirth);


                var dstart = new Temp();
                dstart.NameV = "DateS";
                dstart.Value = DateS;
                db.Temp.Add(dstart);



                var sala = new Temp();
                sala.NameV = "Sal";
                sala.Value = Sal.ToString();
                db.Temp.Add(sala);


                var expr = new Temp();
                expr.NameV = "expir";
                expr.Value = expir;
                db.Temp.Add(expr);


                var post = new Temp();
                post.NameV = "posit";
                post.Value = posit;
                db.Temp.Add(post);


                db.SaveChanges();

            }
        }

        private void AddTempValue(string name, string position)
        {
            using (var db = new TablesContext())
            {
                var post = new Temp();
                post.NameV = name;
                post.Value = position;
                db.Temp.Add(post);
            }
        } 
    }
}
