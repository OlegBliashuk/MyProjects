using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ForTables;
using ForTables.Conveer;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        #region Static Fields

        public static string DateBirth;

        public static string DateStart;

        public static int Sal;        

        public static string expir;

        public static string nam;

        public static string posit;

        public static string secNam;

        public static string surn;

      




        #endregion

        #region Constructors and Destructors

        public Form1()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Methods

        private void ExitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Expir_TextChanged(object sender, EventArgs e)
        {
            this.Expir.Text = this.ValidationSymbol(c => ((c >= 'А' && c <= 'я') || (c >= 48 && c <= 57) || (c == 'є') || (c == 'ї') || (c == 'і') || (c == 'ґ') || (c == '`') || (c == ' ')), Expir.Text);

            this.Expir.Select(this.Expir.Text.Length, 0);
        }

        private void NameP_TextChanged(object sender, EventArgs e)
        {
            this.NameP.Text = this.ValidationSymbol(c => ((c >= 'А' && c <= 'я') || (c == '-') || (c == 'є') || (c == 'ї') || (c == 'і') || (c == 'ґ') || (c == '`')), NameP.Text);

            this.NameP.Select(this.NameP.Text.Length, 0);
        }

        private void Position_TextChanged(object sender, EventArgs e)
        {
            this.Position.Text = this.ValidationSymbol(c => ((c >= 'А' && c <= 'я') || (c == '-') || (c == ' ') || (c == 'є') || (c == 'ї') || (c == 'і') || (c == 'ґ') || (c == '`')), Position.Text);

            this.Position.Select(this.Position.Text.Length, 0);
        }

        private void Salary_TextChanged(object sender, EventArgs e)
        {
            this.Salary.Text = this.ValidationSymbol(c => (c >= 48 && c <= 57), Salary.Text);
            this.Salary.Select(this.Salary.Text.Length, 0);
        }

        private void SecName_TextChanged(object sender, EventArgs e)
        {
            this.SecName.Text = this.ValidationSymbol(c => ((c >= 'А' && c <= 'я') || (c == '-') || (c == 'є') || (c == 'ї') || (c == 'і') || (c == 'ґ') || (c == '`')), SecName.Text);

            this.SecName.Select(this.SecName.Text.Length, 0);
        }

        private void StartBut_Click(object sender, EventArgs e)
        {
            surn = this.Surnm.Text;
            nam = this.NameP.Text;
            secNam = this.SecName.Text;
            DateBirth = this.DateB1.Text;
            try
            {
                Sal = Convert.ToInt32(this.Salary.Text);
            }
            catch
            {
                this.LogInf.Items.Add("!!!Ви не заповнили поле Заробітня плата!!!");
            }
            posit = this.Position.Text;
            expir = this.Expir.Text;
            DateStart = this.DateS1.Text;
            string str;
            TempBase.ToDisk(surn, nam, secNam, DateBirth, DateStart, Sal, expir, posit);
            GoConveer.ConveerGo();
         
            using (StreamReader streamReader = new StreamReader("res.txt"))
            {
                str = "";
                string str_temp = "";
                while ((str_temp = streamReader.ReadLine()) != null)
                {
                    str += str_temp;
                }
            }
            switch (str.ToLower())
            {
                case "0":
                    TempBase.RefreshTemp();
                    this.LogInf.Items.Add(
                            surn + " " + nam + " " + secNam +
                            "__________________доданий до бази працівників.");
                    break;
                case "1":
                    TempBase.RefreshTemp();
                    this.LogInf.Items.Add("!!!Ви не заповнили усі поля, перевірте будь ласка правильність введених даних!!!");
                    break;
                case "2":
                    TempBase.RefreshTemp();
                    this.LogInf.Items.Add(
                        surn + " " + nam + " " + secNam +
                        "______уже доданий до бази раніше");
                    break;
                case "3":
                    TempBase.RefreshTemp();
                    this.LogInf.Items.Add(
                            surn + " " + nam + " " + secNam +
                            "______був арештований і не може бути доданий до бази");
                    break;

            }
            

            if (this.LogInf.Items.Count != 0)
            {
                this.LogInf.SelectedIndex = this.LogInf.Items.Count - 1;
            }
            using (StreamWriter sw = new StreamWriter("res.txt"))
            {
                sw.WriteLine("");
            }
           
            
        }

        private void Surnm_TextChanged(object sender, EventArgs e)
        {

            this.Surnm.Text = this.ValidationSymbol(c => ((c >= 'А' && c <= 'я') || (c == '-') || (c == 'є') || (c == 'ї') || (c == 'і') || (c == 'ґ') || (c == '`')), Surnm.Text);
            this.Surnm.Select(this.Surnm.Text.Length, 0);
        }

        public string ValidationSymbol(Func<char, bool> text, string Ntext)
        {
            var str = new StringBuilder();
            char[] charArray = Ntext.ToCharArray();
            foreach (char c in charArray)
            {
                if (text(char.ToLower(c)))
                {
                    str.Append(c);
                }
            }

            return str.ToString();
        }

        #endregion
    }
}