namespace Week9Demo
{
    partial class Form2
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
            this.chbTrans = new System.Windows.Forms.CheckBox();
            this.chbDining = new System.Windows.Forms.CheckBox();
            this.chbAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnAlas = new System.Windows.Forms.RadioButton();
            this.rBtnLa = new System.Windows.Forms.RadioButton();
            this.rBtnVan = new System.Windows.Forms.RadioButton();
            this.rBtnSeattle = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBtnNa = new System.Windows.Forms.RadioButton();
            this.rBtnDC = new System.Windows.Forms.RadioButton();
            this.rBtnBca = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPStart = new System.Windows.Forms.DateTimePicker();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbTrans);
            this.groupBox1.Controls.Add(this.chbDining);
            this.groupBox1.Controls.Add(this.chbAll);
            this.groupBox1.Location = new System.Drawing.Point(73, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chbTrans
            // 
            this.chbTrans.AutoSize = true;
            this.chbTrans.Location = new System.Drawing.Point(29, 66);
            this.chbTrans.Name = "chbTrans";
            this.chbTrans.Size = new System.Drawing.Size(65, 17);
            this.chbTrans.TabIndex = 2;
            this.chbTrans.Text = "Transfer";
            this.chbTrans.UseVisualStyleBackColor = true;
            // 
            // chbDining
            // 
            this.chbDining.AutoSize = true;
            this.chbDining.Location = new System.Drawing.Point(29, 43);
            this.chbDining.Name = "chbDining";
            this.chbDining.Size = new System.Drawing.Size(102, 17);
            this.chbDining.TabIndex = 1;
            this.chbDining.Text = "Specialty Dining";
            this.chbDining.UseVisualStyleBackColor = true;
            // 
            // chbAll
            // 
            this.chbAll.AutoSize = true;
            this.chbAll.Location = new System.Drawing.Point(29, 20);
            this.chbAll.Name = "chbAll";
            this.chbAll.Size = new System.Drawing.Size(132, 17);
            this.chbAll.TabIndex = 0;
            this.chbAll.Text = "All iinclusive Excursive";
            this.chbAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(495, 78);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCustomer.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnAlas);
            this.groupBox2.Controls.Add(this.rBtnLa);
            this.groupBox2.Controls.Add(this.rBtnVan);
            this.groupBox2.Controls.Add(this.rBtnSeattle);
            this.groupBox2.Location = new System.Drawing.Point(73, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pick a Cruise";
            // 
            // rBtnAlas
            // 
            this.rBtnAlas.AutoSize = true;
            this.rBtnAlas.Location = new System.Drawing.Point(29, 108);
            this.rBtnAlas.Name = "rBtnAlas";
            this.rBtnAlas.Size = new System.Drawing.Size(97, 17);
            this.rBtnAlas.TabIndex = 3;
            this.rBtnAlas.TabStop = true;
            this.rBtnAlas.Text = "Alaska 10 days";
            this.rBtnAlas.UseVisualStyleBackColor = true;
            // 
            // rBtnLa
            // 
            this.rBtnLa.AutoSize = true;
            this.rBtnLa.Location = new System.Drawing.Point(29, 85);
            this.rBtnLa.Name = "rBtnLa";
            this.rBtnLa.Size = new System.Drawing.Size(78, 17);
            this.rBtnLa.TabIndex = 2;
            this.rBtnLa.TabStop = true;
            this.rBtnLa.Text = "LA 12 days";
            this.rBtnLa.UseVisualStyleBackColor = true;
            // 
            // rBtnVan
            // 
            this.rBtnVan.AutoSize = true;
            this.rBtnVan.Location = new System.Drawing.Point(29, 53);
            this.rBtnVan.Name = "rBtnVan";
            this.rBtnVan.Size = new System.Drawing.Size(111, 17);
            this.rBtnVan.TabIndex = 1;
            this.rBtnVan.TabStop = true;
            this.rBtnVan.Text = "Vancouver 7 days";
            this.rBtnVan.UseVisualStyleBackColor = true;
            // 
            // rBtnSeattle
            // 
            this.rBtnSeattle.AutoSize = true;
            this.rBtnSeattle.Location = new System.Drawing.Point(29, 30);
            this.rBtnSeattle.Name = "rBtnSeattle";
            this.rBtnSeattle.Size = new System.Drawing.Size(92, 17);
            this.rBtnSeattle.TabIndex = 0;
            this.rBtnSeattle.TabStop = true;
            this.rBtnSeattle.Text = "Seattle 9 days";
            this.rBtnSeattle.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rBtnNa);
            this.groupBox3.Controls.Add(this.rBtnDC);
            this.groupBox3.Controls.Add(this.rBtnBca);
            this.groupBox3.Location = new System.Drawing.Point(388, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disc";
            // 
            // rBtnNa
            // 
            this.rBtnNa.AutoSize = true;
            this.rBtnNa.Location = new System.Drawing.Point(33, 77);
            this.rBtnNa.Name = "rBtnNa";
            this.rBtnNa.Size = new System.Drawing.Size(40, 17);
            this.rBtnNa.TabIndex = 2;
            this.rBtnNa.TabStop = true;
            this.rBtnNa.Text = "NA";
            this.rBtnNa.UseVisualStyleBackColor = true;
            // 
            // rBtnDC
            // 
            this.rBtnDC.AutoSize = true;
            this.rBtnDC.Location = new System.Drawing.Point(33, 53);
            this.rBtnDC.Name = "rBtnDC";
            this.rBtnDC.Size = new System.Drawing.Size(88, 17);
            this.rBtnDC.TabIndex = 1;
            this.rBtnDC.TabStop = true;
            this.rBtnDC.Text = "Douglas Club";
            this.rBtnDC.UseVisualStyleBackColor = true;
            // 
            // rBtnBca
            // 
            this.rBtnBca.AutoSize = true;
            this.rBtnBca.Location = new System.Drawing.Point(33, 20);
            this.rBtnBca.Name = "rBtnBca";
            this.rBtnBca.Size = new System.Drawing.Size(46, 17);
            this.rBtnBca.TabIndex = 0;
            this.rBtnBca.TabStop = true;
            this.rBtnBca.Text = "BCA";
            this.rBtnBca.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Starting Date";
            // 
            // dtPStart
            // 
            this.dtPStart.Location = new System.Drawing.Point(388, 165);
            this.dtPStart.Name = "dtPStart";
            this.dtPStart.Size = new System.Drawing.Size(207, 20);
            this.dtPStart.TabIndex = 6;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(617, 75);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 7;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(699, 75);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 23);
            this.btnClr.TabIndex = 8;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(780, 75);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lstResult
            // 
            this.lstResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 14;
            this.lstResult.Location = new System.Drawing.Point(662, 152);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(227, 200);
            this.lstResult.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.dtPStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbTrans;
        private System.Windows.Forms.CheckBox chbDining;
        private System.Windows.Forms.CheckBox chbAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnAlas;
        private System.Windows.Forms.RadioButton rBtnLa;
        private System.Windows.Forms.RadioButton rBtnVan;
        private System.Windows.Forms.RadioButton rBtnSeattle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rBtnNa;
        private System.Windows.Forms.RadioButton rBtnDC;
        private System.Windows.Forms.RadioButton rBtnBca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPStart;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox lstResult;
    }
}