namespace Brows
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
            this.BrowsFrom = new System.Windows.Forms.FolderBrowserDialog();
            this.CopyFrom = new System.Windows.Forms.Button();
            this.CopyIn = new System.Windows.Forms.Button();
            this.BrowsTo = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxfrom = new System.Windows.Forms.TextBox();
            this.textBoxin = new System.Windows.Forms.TextBox();
            this.StartB = new System.Windows.Forms.Button();
            this.ExB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CopyF = new System.Windows.Forms.Button();
            this.textBoxFfrom = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowsFrom
            // 
            this.BrowsFrom.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            // 
            // CopyFrom
            // 
            this.CopyFrom.Location = new System.Drawing.Point(32, 12);
            this.CopyFrom.Name = "CopyFrom";
            this.CopyFrom.Size = new System.Drawing.Size(103, 23);
            this.CopyFrom.TabIndex = 0;
            this.CopyFrom.Text = "Копіювати з ...";
            this.CopyFrom.UseVisualStyleBackColor = true;
            // 
            // CopyIn
            // 
            this.CopyIn.Location = new System.Drawing.Point(32, 53);
            this.CopyIn.Name = "CopyIn";
            this.CopyIn.Size = new System.Drawing.Size(103, 23);
            this.CopyIn.TabIndex = 1;
            this.CopyIn.Text = "Копіювати в ...";
            this.CopyIn.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 108);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(505, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(219, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 4;
            // 
            // textBoxfrom
            // 
            this.textBoxfrom.Location = new System.Drawing.Point(141, 15);
            this.textBoxfrom.Name = "textBoxfrom";
            this.textBoxfrom.Size = new System.Drawing.Size(396, 20);
            this.textBoxfrom.TabIndex = 5;
            // 
            // textBoxin
            // 
            this.textBoxin.Location = new System.Drawing.Point(142, 53);
            this.textBoxin.Name = "textBoxin";
            this.textBoxin.Size = new System.Drawing.Size(395, 20);
            this.textBoxin.TabIndex = 6;
            // 
            // StartB
            // 
            this.StartB.Location = new System.Drawing.Point(409, 293);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(128, 23);
            this.StartB.TabIndex = 7;
            this.StartB.Text = "Start";
            this.StartB.UseVisualStyleBackColor = true;
            this.StartB.Click += new System.EventHandler(this.StartB_Click_1);
            // 
            // ExB
            // 
            this.ExB.Location = new System.Drawing.Point(12, 293);
            this.ExB.Name = "ExB";
            this.ExB.Size = new System.Drawing.Size(96, 23);
            this.ExB.TabIndex = 8;
            this.ExB.Text = "Close";
            this.ExB.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.Multiselect = true;
            // 
            // CopyF
            // 
            this.CopyF.Location = new System.Drawing.Point(32, 83);
            this.CopyF.Name = "CopyF";
            this.CopyF.Size = new System.Drawing.Size(103, 23);
            this.CopyF.TabIndex = 9;
            this.CopyF.Text = "Копіювати файл";
            this.CopyF.UseVisualStyleBackColor = true;
            // 
            // textBoxFfrom
            // 
            this.textBoxFfrom.Location = new System.Drawing.Point(142, 85);
            this.textBoxFfrom.Name = "textBoxFfrom";
            this.textBoxFfrom.Size = new System.Drawing.Size(395, 20);
            this.textBoxFfrom.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 163);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(505, 121);
            this.listBox1.TabIndex = 12;
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(549, 328);
            this.mapControl1.TabIndex = 13;
            this.mapControl1.Click += new System.EventHandler(this.mapControl1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 328);
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxFfrom);
            this.Controls.Add(this.CopyF);
            this.Controls.Add(this.ExB);
            this.Controls.Add(this.StartB);
            this.Controls.Add(this.textBoxin);
            this.Controls.Add(this.textBoxfrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CopyIn);
            this.Controls.Add(this.CopyFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog BrowsFrom;
        private System.Windows.Forms.Button CopyFrom;
        private System.Windows.Forms.Button CopyIn;
        private System.Windows.Forms.FolderBrowserDialog BrowsTo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxfrom;
        private System.Windows.Forms.TextBox textBoxin;
        private System.Windows.Forms.Button StartB;
        private System.Windows.Forms.Button ExB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button CopyF;
        private System.Windows.Forms.TextBox textBoxFfrom;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraMap.MapControl mapControl1;
    }
}

