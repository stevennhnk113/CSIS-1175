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
    public partial class TicTacToe : Form
    {
        //string x = "X";
        string user = "X", x = "X";
        string o = "O";
        public TicTacToe()
        {
            InitializeComponent();
        }

        public void btnClick(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).Name);
            Button btn = (Button)sender;

            if (btn.Text == "")
            {
                if (user == x)
                {
                    btn.Text = x;
                    user = o;
                } else
                {
                    btn.Text = o;
                    user = x;
                }
            } else
            {
                MessageBox.Show("Stop clicking");
            }

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(sender.ToString());
        //    MessageBox.Show(((Button) sender).ToString());
        //    MessageBox.Show(((Button) sender).Name);
        //}
    }
}
