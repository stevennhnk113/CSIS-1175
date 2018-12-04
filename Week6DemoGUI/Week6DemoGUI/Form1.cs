using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6DemoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            btnMsg.BackColor = Color.Beige;
            MessageBox.Show("Welcome to CSIS1175");
            this.BackColor = Color.Green;
            //Form1.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            string[] names = txtName.Text.Split(' ');
            MessageBox.Show("Welcome " + names[0]);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAS1_Click(object sender, EventArgs e)
        {
            double programCost = 0;
            string programName = "";

            if (txtProgram.Text == "csis")
            {
                programName = "Computing Study";
                programCost = 150;
            }

            if (txtProgram.Text == "busn")
            {
                programName = "Business";
                programCost = 100;
            }

            if (txtProgram.Text == "econ")
            {
                programName = "Economics";
            }

            if (txtProgram.Text == "mark")
            {
                programName = "Marketing";
            }
            //MessageBox.Show("You are in " + programName + " Cost : " + programCost);
            //MessageBox.Show("Course fee: " + getCourseAmt());

            txtProgName.Text = programName;
            txtProgCost.Text = programCost.ToString();
            txtFee.Text = getCourseAmt().ToString("c");
        }

        public double getCourseAmt()
        {
            double amt = 0; 
            if (txtCourse.Text == "")
            {
                MessageBox.Show("Please enter 1 course" );
            } else
                {
                string[] courses = txtCourse.Text.Split(' ');
                int NoCourses = courses.Length;

                //MessageBox.Show("Number of courses: " + NoCourses);
                amt = 650 * NoCourses;

            }
            return amt;
        }

        public double getDorm()
        {
            double amt = 0;
            if (txtCourse.Text == "")
            {
                MessageBox.Show("Please enter 1 course");
            }
            else
            {
                string[] courses = txtCourse.Text.Split(' ');
                int NoCourses = courses.Length;

                //MessageBox.Show("Number of courses: " + NoCourses);
                amt = 650 * NoCourses;

            }
            return amt;
        }
    }
}
