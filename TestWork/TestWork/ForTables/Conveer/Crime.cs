using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ForTables.Conveer
{
    public class Crime : ICBase<string>
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
                    var per1 = new Police();


                    IQueryable<Police> custQueryS =
                        from Police in db.Police
                        where
                            Police.Surname == surn & Police.Name == nam & Police.SecondName == secNam &
                            Police.DateOfBirth == DateB
                        select Police;

                    if (custQueryS.Any())
                    {
                        StreamWriter expf = new StreamWriter("res.txt");
                        expf.WriteLine("3");
                        expf.Close();
                        //return flag = 3;
                        
                    }
                    else
                    {
                        TempBase.ToDisk(surn, nam, secNam, DateB, DateS, Sal, expir, posit);
                        return input;
                        // return flag = 0;
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

