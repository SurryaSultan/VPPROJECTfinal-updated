namespace CVREADER
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
            this.lblCVPath = new System.Windows.Forms.Label();
            this.richTextBoxFileData = new System.Windows.Forms.RichTextBox();
            this.btnOD = new System.Windows.Forms.Button();
            this.ofdCVPath = new System.Windows.Forms.OpenFileDialog();
            this.btnOp = new System.Windows.Forms.Button();
            this.cbBS = new System.Windows.Forms.CheckBox();
            this.cbMS = new System.Windows.Forms.CheckBox();
            this.cbMphil = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbGender = new System.Windows.Forms.CheckBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.prgrsBarOP = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCVPath
            // 
            this.lblCVPath.AutoSize = true;
            this.lblCVPath.Location = new System.Drawing.Point(19, 16);
            this.lblCVPath.Name = "lblCVPath";
            this.lblCVPath.Size = new System.Drawing.Size(59, 13);
            this.lblCVPath.TabIndex = 0;
            this.lblCVPath.Text = "Select CVs";
            // 
            // richTextBoxFileData
            // 
            this.richTextBoxFileData.Location = new System.Drawing.Point(16, 206);
            this.richTextBoxFileData.Name = "richTextBoxFileData";
            this.richTextBoxFileData.Size = new System.Drawing.Size(711, 214);
            this.richTextBoxFileData.TabIndex = 2;
            this.richTextBoxFileData.Text = "";
            this.richTextBoxFileData.Visible = false;
            // 
            // btnOD
            // 
            this.btnOD.Location = new System.Drawing.Point(432, 12);
            this.btnOD.Name = "btnOD";
            this.btnOD.Size = new System.Drawing.Size(94, 23);
            this.btnOD.TabIndex = 3;
            this.btnOD.Text = "Browse...";
            this.btnOD.UseVisualStyleBackColor = true;
            this.btnOD.Click += new System.EventHandler(this.btnOD_Click);
            // 
            // ofdCVPath
            // 
            this.ofdCVPath.FileName = "openFileDialog1";
            this.ofdCVPath.Multiselect = true;
            // 
            // btnOp
            // 
            this.btnOp.Location = new System.Drawing.Point(503, 138);
            this.btnOp.Name = "btnOp";
            this.btnOp.Size = new System.Drawing.Size(125, 23);
            this.btnOp.TabIndex = 5;
            this.btnOp.Text = "Start Operation";
            this.btnOp.UseVisualStyleBackColor = true;
            this.btnOp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbBS
            // 
            this.cbBS.AutoSize = true;
            this.cbBS.Location = new System.Drawing.Point(6, 19);
            this.cbBS.Name = "cbBS";
            this.cbBS.Size = new System.Drawing.Size(40, 17);
            this.cbBS.TabIndex = 6;
            this.cbBS.Text = "BS";
            this.cbBS.UseVisualStyleBackColor = true;
            // 
            // cbMS
            // 
            this.cbMS.AutoSize = true;
            this.cbMS.Location = new System.Drawing.Point(52, 19);
            this.cbMS.Name = "cbMS";
            this.cbMS.Size = new System.Drawing.Size(42, 17);
            this.cbMS.TabIndex = 7;
            this.cbMS.Text = "MS";
            this.cbMS.UseVisualStyleBackColor = true;
            // 
            // cbMphil
            // 
            this.cbMphil.AutoSize = true;
            this.cbMphil.Location = new System.Drawing.Point(100, 19);
            this.cbMphil.Name = "cbMphil";
            this.cbMphil.Size = new System.Drawing.Size(51, 17);
            this.cbMphil.TabIndex = 8;
            this.cbMphil.Text = "Mphil";
            this.cbMphil.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBS);
            this.groupBox1.Controls.Add(this.cbMphil);
            this.groupBox1.Controls.Add(this.cbMS);
            this.groupBox1.Location = new System.Drawing.Point(16, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 43);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Education Criteria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Location = new System.Drawing.Point(190, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 43);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find By Name";
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(46, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(171, 20);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Location = new System.Drawing.Point(223, 19);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(15, 14);
            this.cbName.TabIndex = 12;
            this.cbName.UseVisualStyleBackColor = true;
            this.cbName.CheckedChanged += new System.EventHandler(this.cbName_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbFemale);
            this.groupBox3.Controls.Add(this.rbMale);
            this.groupBox3.Controls.Add(this.cbGender);
            this.groupBox3.Location = new System.Drawing.Point(441, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 43);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Find By Gender";
            // 
            // cbGender
            // 
            this.cbGender.AutoSize = true;
            this.cbGender.Location = new System.Drawing.Point(166, 20);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(15, 14);
            this.cbGender.TabIndex = 0;
            this.cbGender.UseVisualStyleBackColor = true;
            this.cbGender.CheckedChanged += new System.EventHandler(this.cbGender_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Enabled = false;
            this.rbMale.Location = new System.Drawing.Point(7, 19);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Enabled = false;
            this.rbFemale.Location = new System.Drawing.Point(62, 19);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // prgrsBarOP
            // 
            this.prgrsBarOP.Location = new System.Drawing.Point(16, 138);
            this.prgrsBarOP.Name = "prgrsBarOP";
            this.prgrsBarOP.Size = new System.Drawing.Size(481, 23);
            this.prgrsBarOP.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Target Folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 186);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prgrsBarOP);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOp);
            this.Controls.Add(this.btnOD);
            this.Controls.Add(this.richTextBoxFileData);
            this.Controls.Add(this.lblCVPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CV Extractor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCVPath;
        private System.Windows.Forms.Button btnOD;
        private System.Windows.Forms.Button btnOp;
        public System.Windows.Forms.RichTextBox richTextBoxFileData;
        public System.Windows.Forms.CheckBox cbBS;
        public System.Windows.Forms.CheckBox cbMS;
        public System.Windows.Forms.CheckBox cbMphil;
        public System.Windows.Forms.OpenFileDialog ofdCVPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.CheckBox cbGender;
        private System.Windows.Forms.ProgressBar prgrsBarOP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

