namespace Week12Demo
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
            this.btnEmp = new System.Windows.Forms.Button();
            this.lstBxEmployee = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEmp
            // 
            this.btnEmp.Location = new System.Drawing.Point(54, 45);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(107, 91);
            this.btnEmp.TabIndex = 0;
            this.btnEmp.Text = "Employee";
            this.btnEmp.UseVisualStyleBackColor = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // lstBxEmployee
            // 
            this.lstBxEmployee.FormattingEnabled = true;
            this.lstBxEmployee.Location = new System.Drawing.Point(54, 178);
            this.lstBxEmployee.Name = "lstBxEmployee";
            this.lstBxEmployee.Size = new System.Drawing.Size(690, 238);
            this.lstBxEmployee.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBxEmployee);
            this.Controls.Add(this.btnEmp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.ListBox lstBxEmployee;
    }
}

