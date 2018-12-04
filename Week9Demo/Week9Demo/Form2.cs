using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9Demo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            //excursion $50/day/cust.
            //dinning $20/day
            //transfer $50/cust.
            //cruise fare $100/d/c
            //discount DC: 5% on cruise fare
            //bcaa 10% on options
            
            chbAll.Checked = true;
            chbDining.Checked = false;
            chbTrans.Checked = false;

            rBtnVan.Checked = true;
            rBtnNa.Checked = true;

            txtCustomer.Text = "2";
            dtPStart.Value = DateTime.Now.AddDays(7);
        }

        private int setCruiseDate()
        {
            int days = 0;
            if (rBtnAlas.Checked)
            {
                days = 10;
            }
            if (rBtnVan.Checked)
            {
                days = 7;
            }
            if (rBtnSeattle.Checked)
            {
                days = 9;
            }
            if (rBtnLa.Checked)
            {
                days = 12;
            }

            return days;
        }

        private string setOption()
        {
            string option = "";

            if (chbAll.Checked)
            {
                option = "E";
            }

            if (chbDining.Checked)
            {
                option += "D";
            }

            if (chbTrans.Checked)
            {
                option += "T";
            }

            if (option == "")
            {
                option = "N";
            }
            return option;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            string format = "{0, -15}{1, 10:c}";
            string formatDate = "{0, -15}{1, 10}";
            Cruise cruise = new Cruise();

            lstResult.Items.Add(string.Format(formatDate, "Start Date", dtPStart.Value.ToShortDateString()));
            lstResult.Items.Add(string.Format(formatDate, "End Date", cruise.getEndDate(dtPStart.Value, setCruiseDate())));
            lstResult.Items.Add(string.Format(format, "Cruise Fare ", cruise.cruiseFare(txtCustomer.Text, setCruiseDate())));
            lstResult.Items.Add(string.Format(format, "Options Selected " + setOption(), 
                cruise.getOptionsAmt(setOption(), txtCustomer.Text, setCruiseDate())));
        }

    }
}
