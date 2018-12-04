using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Week10Demo
{
    public partial class Form1 : Form
    {

        string filePath = "C:\\Users\\300299969\\Desktop\\AS1cruise.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader reader 
                = File.OpenText(filePath);
            String[] entry; 

            while (!reader.EndOfStream)
            {
                entry = reader.ReadLine().Split(',');
                cboCustomer.Items.Add(entry[1] + " " + entry[0]);
            }

            reader.Close();
        }

        private void readFile(string filePath)
        {

        }

        private string getId()
        {
            string[] cboEntry = cboCustomer.SelectedItem.ToString().Split(' ');
            return cboEntry[2];
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cId = getId();
            StreamReader myFile 
                = File.OpenText(filePath);
            String[] entry;
            int days = 0;

            while (!myFile.EndOfStream)
            {
                entry = myFile.ReadLine().Split(',');
                if (entry[0] == cId)
                {
                    txtShipName.Text = entry[2];
                    txtStartDate.Text = entry[3];
                    days = int.Parse(entry[4]);
                    txtDay.Text 
                        = DateTime.Parse(txtStartDate.Text)
                            .AddDays(days - 1).ToShortDateString();
                    //transfer
                    switch (entry[7])
                    {
                        case "Y":
                            rbRequired.Checked = true;
                            break;
                        default:
                            rbNotReq.Checked = true;
                            break;
                    }

                    //cabin type
                    switch (entry[5])
                    {
                        case "I":
                            //$100/day
                            rbInside.Checked = true;
                            break;
                        case "O":
                            //$135/day
                            rbOutside.Checked = true;
                            break;
                        case "B":
                            //$200/day
                            rbBal.Checked = true;
                            break;
                        case "S":
                            //$400
                            rbSide.Checked = true;
                            break;
                    }
                    //options
                    cbDining.Checked = false;
                    cbSpa.Checked = false;
                    cbWifi.Checked = false;
                    cbExcur.Checked = false;

                    if (entry[6].Contains('E'))
                    {
                        //$50/day
                        cbExcur.Checked = true;
                    }

                    if (entry[6].Contains('W'))
                    {
                        //$100/trip
                        cbWifi.Checked = true;
                    }

                    if (entry[6].Contains('S'))
                    {
                        //$30/day
                        cbSpa.Checked = true;
                    }

                    if (entry[6].Contains('D'))
                    {
                        //$300/trip
                        cbDining.Checked = true;
                    }

                    //sample output on the listbox 
                    //Customer:                         Simon Li
                    //Cruise ship name:                 Name
                    //Sailing date:                     Date (mm/dd/yyyy)
                    //Return date:                      Date (mm/dd/yyyy)
                    //Transfer: TransferType            $xxx.xx                         
                    //Cabin: CabinType                  $xxx.xx                     
                    //options exursion & Drink          $xxx.xx
                    //
                    //Total:                            $xxx.xx

                    break;
                }
            }
            myFile.Close();
        }
    }
}
