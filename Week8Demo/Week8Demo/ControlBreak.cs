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

namespace Week8Demo
{
    public partial class ControlBreak : Form
    {
        public ControlBreak()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string[] data;
            // "-" is to align on the left and :c to display currency
            string fmt = "{0,-5}{1,-10}{2,15:c}";
            StreamReader reader = File
                .OpenText(@"E:\1175-008\repos\Week8Demo\CustomerDeposit.csv");

            while (!reader.EndOfStream) {
                data = reader.ReadLine().Split(',');
                lsBx.Items.Add(string.Format(fmt, data[0], data[1], double.Parse(data[2])));
            }
            reader.Close();
        }
    }
}
