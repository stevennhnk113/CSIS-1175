namespace Week8Demo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtASwt = new System.Windows.Forms.TextBox();
            this.txtASMark = new System.Windows.Forms.TextBox();
            this.txtQMark = new System.Windows.Forms.TextBox();
            this.txtQwt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMidMark = new System.Windows.Forms.TextBox();
            this.txtMidwt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFMark = new System.Windows.Forms.TextBox();
            this.txtFwt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.txtWtF = new System.Windows.Forms.TextBox();
            this.txtWtMid = new System.Windows.Forms.TextBox();
            this.txtWtQ = new System.Windows.Forms.TextBox();
            this.txtWtAS = new System.Windows.Forms.TextBox();
            this.txtWtExam = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assignments";
            // 
            // txtASwt
            // 
            this.txtASwt.Location = new System.Drawing.Point(117, 69);
            this.txtASwt.Name = "txtASwt";
            this.txtASwt.Size = new System.Drawing.Size(100, 20);
            this.txtASwt.TabIndex = 1;
            // 
            // txtASMark
            // 
            this.txtASMark.Location = new System.Drawing.Point(223, 69);
            this.txtASMark.Name = "txtASMark";
            this.txtASMark.Size = new System.Drawing.Size(100, 20);
            this.txtASMark.TabIndex = 3;
            // 
            // txtQMark
            // 
            this.txtQMark.Location = new System.Drawing.Point(223, 114);
            this.txtQMark.Name = "txtQMark";
            this.txtQMark.Size = new System.Drawing.Size(100, 20);
            this.txtQMark.TabIndex = 6;
            // 
            // txtQwt
            // 
            this.txtQwt.Location = new System.Drawing.Point(117, 114);
            this.txtQwt.Name = "txtQwt";
            this.txtQwt.Size = new System.Drawing.Size(100, 20);
            this.txtQwt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quiz";
            // 
            // txtMidMark
            // 
            this.txtMidMark.Location = new System.Drawing.Point(223, 159);
            this.txtMidMark.Name = "txtMidMark";
            this.txtMidMark.Size = new System.Drawing.Size(100, 20);
            this.txtMidMark.TabIndex = 9;
            // 
            // txtMidwt
            // 
            this.txtMidwt.Location = new System.Drawing.Point(117, 159);
            this.txtMidwt.Name = "txtMidwt";
            this.txtMidwt.Size = new System.Drawing.Size(100, 20);
            this.txtMidwt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Midterm";
            // 
            // txtFMark
            // 
            this.txtFMark.Location = new System.Drawing.Point(223, 201);
            this.txtFMark.Name = "txtFMark";
            this.txtFMark.Size = new System.Drawing.Size(100, 20);
            this.txtFMark.TabIndex = 12;
            // 
            // txtFwt
            // 
            this.txtFwt.Location = new System.Drawing.Point(117, 201);
            this.txtFwt.Name = "txtFwt";
            this.txtFwt.Size = new System.Drawing.Size(100, 20);
            this.txtFwt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Weight";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Marks";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(117, 273);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 15;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // txtWtF
            // 
            this.txtWtF.Location = new System.Drawing.Point(340, 201);
            this.txtWtF.Name = "txtWtF";
            this.txtWtF.Size = new System.Drawing.Size(100, 20);
            this.txtWtF.TabIndex = 19;
            // 
            // txtWtMid
            // 
            this.txtWtMid.Location = new System.Drawing.Point(340, 159);
            this.txtWtMid.Name = "txtWtMid";
            this.txtWtMid.Size = new System.Drawing.Size(100, 20);
            this.txtWtMid.TabIndex = 18;
            // 
            // txtWtQ
            // 
            this.txtWtQ.Location = new System.Drawing.Point(340, 114);
            this.txtWtQ.Name = "txtWtQ";
            this.txtWtQ.Size = new System.Drawing.Size(100, 20);
            this.txtWtQ.TabIndex = 17;
            // 
            // txtWtAS
            // 
            this.txtWtAS.Location = new System.Drawing.Point(340, 69);
            this.txtWtAS.Name = "txtWtAS";
            this.txtWtAS.Size = new System.Drawing.Size(100, 20);
            this.txtWtAS.TabIndex = 16;
            // 
            // txtWtExam
            // 
            this.txtWtExam.Location = new System.Drawing.Point(340, 275);
            this.txtWtExam.Name = "txtWtExam";
            this.txtWtExam.Size = new System.Drawing.Size(100, 20);
            this.txtWtExam.TabIndex = 20;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(223, 272);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 21;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtWtExam);
            this.Controls.Add(this.txtWtF);
            this.Controls.Add(this.txtWtMid);
            this.Controls.Add(this.txtWtQ);
            this.Controls.Add(this.txtWtAS);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFMark);
            this.Controls.Add(this.txtFwt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMidMark);
            this.Controls.Add(this.txtMidwt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQMark);
            this.Controls.Add(this.txtQwt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtASMark);
            this.Controls.Add(this.txtASwt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtASwt;
        private System.Windows.Forms.TextBox txtASMark;
        private System.Windows.Forms.TextBox txtQMark;
        private System.Windows.Forms.TextBox txtQwt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMidMark;
        private System.Windows.Forms.TextBox txtMidwt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFMark;
        private System.Windows.Forms.TextBox txtFwt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TextBox txtWtF;
        private System.Windows.Forms.TextBox txtWtMid;
        private System.Windows.Forms.TextBox txtWtQ;
        private System.Windows.Forms.TextBox txtWtAS;
        private System.Windows.Forms.TextBox txtWtExam;
        private System.Windows.Forms.Button btnCalc;
    }
}

