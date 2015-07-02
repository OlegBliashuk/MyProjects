using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace ForTables.Conveer
{
    public class AddTo : ICBase<string>
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
                    using (var db = new TablesContext())
                    {

                        var per = new Workman();
                        per.Surname = surn;
                        per.Name = nam;
                        per.SecondName = secNam;
                        per.DateOfBirth = DateB;
                        per.DateOfStart = DateS;
                        per.Salary = Sal;
                        per.Expirience = expir;
                        per.Position = posit;

                        db.Workman.Add(per);
                        db.SaveChanges();

                    }
                    StreamWriter expf = new StreamWriter("res.txt");
                    expf.WriteLine("0");
                    expf.Close();

                }
                else
                {
                    return input;
                }

            }
            
            return input;
        }
    }
}
