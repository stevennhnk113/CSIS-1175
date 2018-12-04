namespace Week10Demo
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
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSide = new System.Windows.Forms.RadioButton();
            this.rbBal = new System.Windows.Forms.RadioButton();
            this.rbOutside = new System.Windows.Forms.RadioButton();
            this.rbInside = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNotReq = new System.Windows.Forms.RadioButton();
            this.rbRequired = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDining = new System.Windows.Forms.CheckBox();
            this.cbSpa = new System.Windows.Forms.CheckBox();
            this.cbWifi = new System.Windows.Forms.CheckBox();
            this.cbExcur = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(15, 53);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(197, 21);
            this.cboCustomer.Sorted = true;
            this.cboCustomer.TabIndex = 0;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ship";
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(60, 129);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(152, 20);
            this.txtShipName.TabIndex = 2;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(60, 182);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(152, 20);
            this.txtStartDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(60, 238);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(152, 20);
            this.txtDay.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Day";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSide);
            this.groupBox1.Controls.Add(this.rbBal);
            this.groupBox1.Controls.Add(this.rbOutside);
            this.groupBox1.Controls.Add(this.rbInside);
            this.groupBox1.Location = new System.Drawing.Point(289, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 175);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabin Type";
            // 
            // rbSide
            // 
            this.rbSide.AutoSize = true;
            this.rbSide.Location = new System.Drawing.Point(19, 137);
            this.rbSide.Name = "rbSide";
            this.rbSide.Size = new System.Drawing.Size(46, 17);
            this.rbSide.TabIndex = 3;
            this.rbSide.TabStop = true;
            this.rbSide.Text = "Side";
            this.rbSide.UseVisualStyleBackColor = true;
            // 
            // rbBal
            // 
            this.rbBal.AutoSize = true;
            this.rbBal.Location = new System.Drawing.Point(19, 97);
            this.rbBal.Name = "rbBal";
            this.rbBal.Size = new System.Drawing.Size(63, 17);
            this.rbBal.TabIndex = 2;
            this.rbBal.TabStop = true;
            this.rbBal.Text = "Balcony";
            this.rbBal.UseVisualStyleBackColor = true;
            // 
            // rbOutside
            // 
            this.rbOutside.AutoSize = true;
            this.rbOutside.Location = new System.Drawing.Point(19, 58);
            this.rbOutside.Name = "rbOutside";
            this.rbOutside.Size = new System.Drawing.Size(61, 17);
            this.rbOutside.TabIndex = 1;
            this.rbOutside.TabStop = true;
            this.rbOutside.Text = "Outside";
            this.rbOutside.UseVisualStyleBackColor = true;
            // 
            // rbInside
            // 
            this.rbInside.AutoSize = true;
            this.rbInside.Location = new System.Drawing.Point(19, 20);
            this.rbInside.Name = "rbInside";
            this.rbInside.Size = new System.Drawing.Size(53, 17);
            this.rbInside.TabIndex = 0;
            this.rbInside.TabStop = true;
            this.rbInside.Text = "Inside";
            this.rbInside.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNotReq);
            this.groupBox2.Controls.Add(this.rbRequired);
            this.groupBox2.Location = new System.Drawing.Point(60, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transfer";
            // 
            // rbNotReq
            // 
            this.rbNotReq.AutoSize = true;
            this.rbNotReq.Location = new System.Drawing.Point(18, 54);
            this.rbNotReq.Name = "rbNotReq";
            this.rbNotReq.Size = new System.Drawing.Size(83, 17);
            this.rbNotReq.TabIndex = 1;
            this.rbNotReq.TabStop = true;
            this.rbNotReq.Text = "Not required";
            this.rbNotReq.UseVisualStyleBackColor = true;
            // 
            // rbRequired
            // 
            this.rbRequired.AutoSize = true;
            this.rbRequired.Location = new System.Drawing.Point(18, 20);
            this.rbRequired.Name = "rbRequired";
            this.rbRequired.Size = new System.Drawing.Size(68, 17);
            this.rbRequired.TabIndex = 0;
            this.rbRequired.TabStop = true;
            this.rbRequired.Text = "Required";
            this.rbRequired.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDining);
            this.groupBox3.Controls.Add(this.cbSpa);
            this.groupBox3.Controls.Add(this.cbWifi);
            this.groupBox3.Controls.Add(this.cbExcur);
            this.groupBox3.Location = new System.Drawing.Point(504, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // cbDining
            // 
            this.cbDining.AutoSize = true;
            this.cbDining.Location = new System.Drawing.Point(259, 19);
            this.cbDining.Name = "cbDining";
            this.cbDining.Size = new System.Drawing.Size(56, 17);
            this.cbDining.TabIndex = 3;
            this.cbDining.Text = "Dining";
            this.cbDining.UseVisualStyleBackColor = true;
            // 
            // cbSpa
            // 
            this.cbSpa.AutoSize = true;
            this.cbSpa.Location = new System.Drawing.Point(191, 19);
            this.cbSpa.Name = "cbSpa";
            this.cbSpa.Size = new System.Drawing.Size(45, 17);
            this.cbSpa.TabIndex = 2;
            this.cbSpa.Text = "Spa";
            this.cbSpa.UseVisualStyleBackColor = true;
            // 
            // cbWifi
            // 
            this.cbWifi.AutoSize = true;
            this.cbWifi.Location = new System.Drawing.Point(105, 19);
            this.cbWifi.Name = "cbWifi";
            this.cbWifi.Size = new System.Drawing.Size(44, 17);
            this.cbWifi.TabIndex = 1;
            this.cbWifi.Text = "Wifi";
            this.cbWifi.UseVisualStyleBackColor = true;
            // 
            // cbExcur
            // 
            this.cbExcur.AutoSize = true;
            this.cbExcur.Location = new System.Drawing.Point(19, 20);
            this.cbExcur.Name = "cbExcur";
            this.cbExcur.Size = new System.Drawing.Size(72, 17);
            this.cbExcur.TabIndex = 0;
            this.cbExcur.Text = "Excursion";
            this.cbExcur.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(289, 270);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(486, 158);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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

        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSide;
        private System.Windows.Forms.RadioButton rbBal;
        private System.Windows.Forms.RadioButton rbOutside;
        private System.Windows.Forms.RadioButton rbInside;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNotReq;
        private System.Windows.Forms.RadioButton rbRequired;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbDining;
        private System.Windows.Forms.CheckBox cbSpa;
        private System.Windows.Forms.CheckBox cbWifi;
        private System.Windows.Forms.CheckBox cbExcur;
        private System.Windows.Forms.ListBox listBox1;
    }
}

