using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txtASwt.Text = "20";
            txtQwt.Text = "10";
            txtMidwt.Text = "30";
            txtFwt.Text = "40";
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtWtAS.Text = CalcWt(txtASwt.Text, txtASMark.Text);
            txtWtQ.Text = CalcWt(txtQwt.Text, txtQMark.Text);
            txtWtMid.Text = CalcWt(txtMidwt.Text, txtMidMark.Text);
            txtWtF.Text = CalcWt(txtFwt.Text, txtFMark.Text);

            txtWtExam.Text = showExam(txtWtQ.Text, 
                txtWtMid.Text, txtWtF.Text);
            showGrade(txtWtAS.Text, txtWtQ.Text, txtWtMid.Text, txtWtF.Text);
        }

        public string showGrade(string Asm , string quiz, 
            string midterm, string final)
        {
            double score = double.Parse(showExam(quiz, midterm, final));
            double overallScore = score + double.Parse(Asm);
            string grade = "";
            //    if (score <= 40)
            //    {
            //        MessageBox.Show("Overall score is F");
            //   } else
            //    {
            switch (overallScore)
                {
                    case double x when (x >= 85):
                        grade = "A";
                        break;
                    case double x when (x >= 70):
                        grade = "B";
                        break;
                    case double x when (x >= 55):
                        grade = "C";
                        break;
                    case double x when (x >= 50):
                        grade = "P";
                        break;
                    default:
                        grade = "F";
                        break;
                }
          //  }
            MessageBox.Show("Overall score is " + grade);
            return grade;
        }
        
        public string showExam(string txtQMark, 
            string txtMidMark, string txtFMark)
        {
            double score = 0.0;

            score = double.Parse(txtQMark) + 
                double.Parse(txtMidMark) + double.Parse(txtFMark);

            return score.ToString();
        }

        public string CalcWt(string wt, string mark)
        {
            double score = 0.0;
            score = double.Parse(wt) / 100 * double.Parse(mark);

            return score.ToString();
        }
    }
}
