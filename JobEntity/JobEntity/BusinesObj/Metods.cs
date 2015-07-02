using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BusinesObj
{
    public class Metods
    {

        public static void SaveBd(string surn, string nam, string secNam, string DateB, string DateS, string Sal, string expir, string posit)
        {
            ListOfWorkersEntities bd = new ListOfWorkersEntities();
            Workman per = new Workman();
            per.Surnume = surn;
            per.Name = nam;
            per.SecondName = secNam;
            per.DateOfBirth = DateB;
            per.DateOfStart = DateS;
            per.Salary = Convert.ToInt32(Sal);
            per.Expirience = expir;
            per.Position = posit;

            bd.Workman.AddObject(per);
            bd.SaveChanges();
        }
        public static Boolean PersCrime(string surn, string name, string sdname, string Dbirth)
        {
            ListOfWorkersEntities bd1 = new ListOfWorkersEntities();
            PoliceList per1 = new PoliceList();

            IQueryable<PoliceList> custQueryS =
                from PoliceList in bd1.PoliceList
                where PoliceList.Surnume == surn & PoliceList.Name == name & PoliceList.SecondName == sdname & PoliceList.DateOfBirth == Dbirth
                select PoliceList;

            if (custQueryS.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static Boolean PersWork(string surn, string name, string sdname, string Dbirth)
        {
            ListOfWorkersEntities bd1 = new ListOfWorkersEntities();
            Workman per1 = new Workman();

            IQueryable<Workman> custQueryn =
                from Workman in bd1.Workman
                where Workman.Surnume == surn & Workman.Name == name & Workman.SecondName == sdname & Workman.DateOfBirth == Dbirth
                select Workman;

            if (custQueryn.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
