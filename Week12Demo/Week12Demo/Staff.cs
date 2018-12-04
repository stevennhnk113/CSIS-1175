using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Demo
{
    class Staff : Employee
    {

        private double _hrs;
        private double _rate; 

        public Staff(string id, string firstName, string lastName,
            double hrs, double rate)
            : base (id, firstName, lastName)
        {
            this._hrs = hrs;
            this._rate = rate;
        }


        public double getAmt()
        {
            return _hrs * _rate;
        }

    }
}
