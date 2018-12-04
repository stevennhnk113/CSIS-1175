using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Demo
{
    class SA : Employee
    {

        private double _hrs;
        private double _rate;

        public SA(string id, string firstName, string lastName,
            double hrs, double rate)
            : base (id, firstName, lastName)
        {
            this._hrs = hrs;
            this._rate = rate;
        }

        public double getAmt()
        {
            double amt = _hrs * _rate;
            if (_hrs > 40)
            {
                amt = (_hrs - 40) * 2 * _rate + 40 * _rate;
            }
            return amt;
        }

        public string getName()
        {
            return getFirstName();
        }

        override
        public string getFullName()
        {
            return "";
        }

    }
}
