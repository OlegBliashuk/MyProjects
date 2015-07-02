using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ForTables.Conveer
{
    public class Inwork : ICBase<string>
    {
        
        public IEnumerable<string> StartOf(IEnumerable<string> input)
        {
            string surn = TempBase.GetTemp("surn");
            string nam = TempBase.GetTemp("nam");
            string secNam = TempBase.GetTemp("secNam");
            string DateB = TempBase.GetTemp("DateB");
            string posit = TempBase.GetTemp("posit");
            string expir = TempBase.GetTemp("expir");
            string DateS = TempBase.GetTemp("DateS");
            int Sal = Convert.ToInt32(TempBase.GetTemp("Sal"));
            TempBase.RefreshTemp();
            using (StreamReader streamReader = new StreamReader("res.txt"))
            {
                string str = "", str_temp = "";
                while ((str_temp = streamReader.ReadLine()) != null)
                {
                    str += str_temp;
                }
                streamReader.Close();
                if (str.Count() == 0)
                {


                    Database.SetInitializer<TablesContext>(null);
                    var db = new TablesContext();

                    IQueryable<Workman> custQueryS =
                        from Workman in db.Workman
                        where
                            Workman.Surname == surn & Workman.Name == nam & Workman.SecondName == secNam &
                            Workman.DateOfBirth == DateB
                        select Workman;

                    if (custQueryS.Any())
                    {
                        StreamWriter expf = new StreamWriter("res.txt");
                        expf.WriteLine("2");
                        expf.Close();
                        //return flag = 2;
                        
                    }
                    else
                    {
                        TempBase.ToDisk(surn, nam, secNam, DateB, DateS, Sal, expir, posit);
                        return input;
                        //return flag = 0;
                    }
                }
                else
                {
                    TempBase.ToDisk(surn, nam, secNam, DateB, DateS, Sal, expir, posit);
                    return input;
                }



            }
            TempBase.ToDisk(surn, nam, secNam, DateB, DateS, Sal, expir, posit);
            return input;
        }
    }
}

