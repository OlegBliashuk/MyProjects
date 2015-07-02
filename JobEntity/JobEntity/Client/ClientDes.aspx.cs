using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Services.Client;
using Client.JobService;
using BusinesObj;


namespace Client
{
    public partial class ClientDes : System.Web.UI.Page
    {
        public static string surn;
        public static string nam;
        public static string secNam;
        public static string DateB;
        public static string Sal;
        public static string posit;
        public static string expir;
        public static string DateS;

        void Page_Load(object sender, EventArgs e)
        {
            SaveChang.Click += new EventHandler(this.SaveChang_Click);
            Cancel.Click += new EventHandler(this.Cancel_Click);



        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            string message = "<script language=javascript>window.close()</script>";
            this.RegisterStartupScript("script", message);
        }
        private void SaveChang_Click(object sender, EventArgs e)
        {
            surn = Surnume.Text;
            nam = Name.Text;
            secNam = SecName.Text;
            DateB = DBirth.Text;
            Sal = Salary.Text;
            posit = Position.Text;
            expir = Expirience.Text;
            DateS = DStart.Text;
            if ((surn.Count() == 0) || (nam.Count() == 0) || (secNam.Count() == 0) || (DateB.Count() == 0) || (Sal.Count() == 0) || (posit.Count() == 0) || (expir.Count() == 0) || (DateS.Count() == 0))
            {
                string message = "<script language=javascript>alert('Незаповнені всі поля!!!');</script>";
                this.RegisterStartupScript("script", message);

            }
            else
            {
                if (!Metods.PersWork(surn, nam, secNam, DateB))
                {
                    if (Metods.PersCrime(surn, nam, secNam, DateB))
                    {
                        string message = "<script language=javascript>alert('Наявний привід до міліції');</script>";
                        this.RegisterStartupScript("script", message);
                    }
                    else
                    {
                        Metods.SaveBd(surn, nam, secNam, DateB, DateS, Sal, expir, posit);
                        string message = "<script language=javascript>alert('Доданий до бази працівників');</script>";
                        this.RegisterStartupScript("script", message);
                    }
                }
                else
                {
                    string message = "<script language=javascript>alert('Уже є в базі працівників!!!');</script>";
                    this.RegisterStartupScript("script", message);
                }
            }

        }
    }
}