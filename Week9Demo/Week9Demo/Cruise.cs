using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Demo
{
    class Cruise
    {
        private double _optAmt = 0;
        private double _cruiseFare = 0;
        private double _dicsAmt = 0;

        public Cruise()
        {

        }

        public string getEndDate(DateTime start, int days)
        {
            string enddate = "";
            enddate = start.AddDays(days).ToShortDateString();
            return enddate;
        }

        public double cruiseFare(string customer, int days)
        {
            double amt = 0.0;
            int ppl = int.Parse(customer);


            return amt;
        }

        public double getOptionsAmt(string option, string customer, int days)
        {
            double amt = 0.0;
            int ppl = int.Parse(customer);
            if (option.Contains("E"))
            {
                amt = 50 * days * ppl;
            }

            if (option.Contains("D"))
            {
                amt += 20 * days;
            }

            if (option.Contains("T"))
            {
                amt += 50 * ppl;
            }
            return amt;
        }
    }
}
