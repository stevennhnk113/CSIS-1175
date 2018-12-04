using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee("911", "a", "b");
            lstBxEmployee.Items.Clear();
            lstBxEmployee.Items.Add(emp.getFullName() + " " +emp.getId());
            Faculty faculty = new Faculty("911", "a", "b", "csis", 8000);
            lstBxEmployee.Items.Add(faculty.getFullName() + " " 
                + faculty.getDept() + " " + faculty.getSalary());

            Staff staff = new Staff("911", "a", "b", 5, 10);
            lstBxEmployee.Items.Add(staff.getFullName() + " "
                + staff.getAmt());

            SA sa = new SA("", "a", "b", 349, 13);
            lstBxEmployee.Items.Add(sa.getFullName() + " "
                + sa.getAmt() + " Firstname: " + sa.getName());
        }
    }
}
