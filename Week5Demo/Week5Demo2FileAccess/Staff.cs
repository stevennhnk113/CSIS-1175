using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Demo2FileAccess
{
    class Staff
    {
        private string _id;
        private string _name;
        private string _grade;
        private double _hrs;
        private double _rate;

        public Staff(string input)
        {
            string[] entry = input.Split(',');
            _id = entry[0];
            _name = entry[1];
            _grade = entry[2];
            _hrs = double.Parse(entry[3]);
            _rate = double.Parse(entry[4]);
        }
        public string getTitle()
        {
            string title = "";
            switch (_grade)
            {
                case "B":
                    title = "Boss";
                    break;
                case "S":
                    title = "Staff";
                    break;
                case "M":
                    title = "Manager";
                    break;
            }
            return title;
        }

        public double getPayAmt()
        {
            double amt = 0;
            if (_hrs > 35)
            {
                amt = _rate * 35 + _rate * 1.5 * (_hrs - 35);
            }
            else
            {
                amt = _rate * _hrs;
            }
            return amt;
        }

        public string getName()
        {
            return _name;
        }
        public string getFirstName()
        {
            return _name.Split(' ')[0];
        }

    }
}
