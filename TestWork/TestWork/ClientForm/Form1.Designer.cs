namespace ClientForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateB1 = new System.Windows.Forms.DateTimePicker();
            this.SecName = new System.Windows.Forms.TextBox();
            this.NameP = new System.Windows.Forms.TextBox();
            this.Surnm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Salary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DateS1 = new System.Windows.Forms.DateTimePicker();
            this.Expir = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LogInf = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StartBut = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateB1);
            this.groupBox1.Controls.Add(this.SecName);
            this.groupBox1.Controls.Add(this.NameP);
            this.groupBox1.Controls.Add(this.Surnm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Персональні дані";
            // 
            // DateB1
            // 
            this.DateB1.Location = new System.Drawing.Point(155, 148);
            this.DateB1.MaxDate = new System.DateTime(1995, 12, 17, 0, 0, 0, 0);
            this.DateB1.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.DateB1.Name = "DateB1";
            this.DateB1.Size = new System.Drawing.Size(200, 20);
            this.DateB1.TabIndex = 8;
            this.DateB1.Value = new System.DateTime(1992, 12, 17, 0, 0, 0, 0);
            // 
            // SecName
            // 
            this.SecName.Location = new System.Drawing.Point(153, 105);
            this.SecName.Name = "SecName";
            this.SecName.Size = new System.Drawing.Size(202, 20);
            this.SecName.TabIndex = 6;
            this.SecName.TextChanged += new System.EventHandler(this.SecName_TextChanged);
            // 
            // NameP
            // 
            this.NameP.Location = new System.Drawing.Point(153, 66);
            this.NameP.Name = "NameP";
            this.NameP.Size = new System.Drawing.Size(202, 20);
            this.NameP.TabIndex = 5;
            this.NameP.TextChanged += new System.EventHandler(this.NameP_TextChanged);
            // 
            // Surnm
            // 
            this.Surnm.Location = new System.Drawing.Point(153, 30);
            this.Surnm.Name = "Surnm";
            this.Surnm.Size = new System.Drawing.Size(202, 20);
            this.Surnm.TabIndex = 4;
            this.Surnm.TextChanged += new System.EventHandler(this.Surnm_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата народження:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "По батькові:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "lм\'я:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Salary);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.DateS1);
            this.groupBox2.Controls.Add(this.Expir);
            this.groupBox2.Controls.Add(this.Position);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(399, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 194);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Корпоративні дані";
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(164, 62);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(86, 20);
            this.Salary.TabIndex = 9;
            this.Salary.TextChanged += new System.EventHandler(this.Salary_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(256, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "$";
            // 
            // DateS1
            // 
            this.DateS1.Location = new System.Drawing.Point(155, 144);
            this.DateS1.MinDate = new System.DateTime(2013, 12, 17, 0, 0, 0, 0);
            this.DateS1.Name = "DateS1";
            this.DateS1.Size = new System.Drawing.Size(200, 20);
            this.DateS1.TabIndex = 7;
            // 
            // Expir
            // 
            this.Expir.Location = new System.Drawing.Point(164, 105);
            this.Expir.Name = "Expir";
            this.Expir.Size = new System.Drawing.Size(191, 20);
            this.Expir.TabIndex = 6;
            this.Expir.TextChanged += new System.EventHandler(this.Expir_TextChanged);
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(164, 30);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(191, 20);
            this.Position.TabIndex = 4;
            this.Position.TextChanged += new System.EventHandler(this.Position_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Дата початку \r\nроботи:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Попередній досвід\r\nроботи:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Заробітня плата:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Посада:";
            // 
            // LogInf
            // 
            this.LogInf.FormattingEnabled = true;
            this.LogInf.Location = new System.Drawing.Point(12, 233);
            this.LogInf.Name = "LogInf";
            this.LogInf.Size = new System.Drawing.Size(748, 134);
            this.LogInf.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(13, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Статус виконання:";
            // 
            // StartBut
            // 
            this.StartBut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBut.Location = new System.Drawing.Point(610, 396);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(150, 23);
            this.StartBut.TabIndex = 11;
            this.StartBut.Text = "Готово";
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // ExitBut
            // 
            this.ExitBut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBut.Location = new System.Drawing.Point(12, 395);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(150, 23);
            this.ExitBut.TabIndex = 12;
            this.ExitBut.Text = "Вихід";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 431);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.StartBut);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LogInf);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ToBase";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SecName;
        private System.Windows.Forms.TextBox NameP;
        private System.Windows.Forms.TextBox Surnm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Expir;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LogInf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.DateTimePicker DateB1;
        private System.Windows.Forms.DateTimePicker DateS1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Salary;
    }
}