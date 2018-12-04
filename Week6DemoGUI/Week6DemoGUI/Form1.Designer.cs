namespace Week6DemoGUI
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
            this.btnMsg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDorm = new System.Windows.Forms.TextBox();
            this.btnAS1 = new System.Windows.Forms.Button();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtProgName = new System.Windows.Forms.TextBox();
            this.txtProgCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMsg
            // 
            this.btnMsg.Location = new System.Drawing.Point(21, 30);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(75, 27);
            this.btnMsg.TabIndex = 0;
            this.btnMsg.Text = "Show Msg";
            this.btnMsg.UseVisualStyleBackColor = true;
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(248, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnWelcome
            // 
            this.btnWelcome.Location = new System.Drawing.Point(21, 109);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(75, 23);
            this.btnWelcome.TabIndex = 3;
            this.btnWelcome.Text = "Welcome";
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Program";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(248, 109);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(100, 20);
            this.txtProgram.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Course";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(248, 179);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 20);
            this.txtCourse.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dorm";
            // 
            // txtDorm
            // 
            this.txtDorm.Location = new System.Drawing.Point(248, 235);
            this.txtDorm.Name = "txtDorm";
            this.txtDorm.Size = new System.Drawing.Size(100, 20);
            this.txtDorm.TabIndex = 9;
            // 
            // btnAS1
            // 
            this.btnAS1.Location = new System.Drawing.Point(21, 214);
            this.btnAS1.Name = "btnAS1";
            this.btnAS1.Size = new System.Drawing.Size(75, 23);
            this.btnAS1.TabIndex = 10;
            this.btnAS1.Text = "AS1";
            this.btnAS1.UseVisualStyleBackColor = true;
            this.btnAS1.Click += new System.EventHandler(this.btnAS1_Click);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(375, 179);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(100, 20);
            this.txtFee.TabIndex = 12;
            // 
            // txtProgName
            // 
            this.txtProgName.Location = new System.Drawing.Point(375, 112);
            this.txtProgName.Name = "txtProgName";
            this.txtProgName.Size = new System.Drawing.Size(100, 20);
            this.txtProgName.TabIndex = 11;
            // 
            // txtProgCost
            // 
            this.txtProgCost.Location = new System.Drawing.Point(507, 112);
            this.txtProgCost.Name = "txtProgCost";
            this.txtProgCost.Size = new System.Drawing.Size(100, 20);
            this.txtProgCost.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProgCost);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtProgName);
            this.Controls.Add(this.btnAS1);
            this.Controls.Add(this.txtDorm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWelcome);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMsg);
            this.Name = "Form1";
            this.Text = "Welcome Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDorm;
        private System.Windows.Forms.Button btnAS1;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtProgName;
        private System.Windows.Forms.TextBox txtProgCost;
    }
}

