using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ForTables.Conveer
{
    public class EmtyT : ICBase<string>
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
            var tmpStr = TempBase.GetTemp("Sal");
            int Sal = Convert.ToInt32(tmpStr);
            TempBase.RefreshTemp();
            var fileStream = new FileStream("res.txt",FileMode.OpenOrCreate);
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                string str = "", str_temp = "";
                while ((str_temp = streamReader.ReadLine()) != null)
                {
                    str += str_temp;
                }
                streamReader.Close();
                if (str.Count() == 0)
                {


                    if ((surn.Count() == 0) || (nam.Count() == 0) || (secNam.Count() == 0) || (DateB.Count() == 0) ||
                        (Sal.ToString().Count() == 0) || (posit.Count() == 0) || (expir.Count() == 0) ||
                        (DateS.Count() == 0))
                    {
                        StreamWriter expf = new StreamWriter("res.txt");
                        expf.WriteLine("1");
                        expf.Close();
                        // return flag = 1;
                       
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
