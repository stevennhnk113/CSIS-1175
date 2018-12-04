using System;

namespace Week5Demo3MultipleConstructor
{
    class Employee
    {
        private string _name;
        private string _grade;
        private double _hrs;
        private double _rate;
        private double _amt;

        public Employee(string name, string grade, double hrs, double rate)
        {
            _name = name;
            _grade = grade;
            _hrs = hrs;
            _rate = rate;
            _amt = calcAmt();
        }

        public double calcAmt()
        {
            double amt = _hrs * _rate;
            if (_hrs > 35)
            {
                amt = _rate * 35 + (_hrs - 35) * 1.5 * _rate;
            }
            return amt;
        }

        public Employee(string name, string grade, double amt)
        {
            _name = name;
            _grade = grade;
            _amt = amt;
        }

        public string getName()
        {
            return _name;
        }

        public double getAmt()
        {
            return _amt;
        }

        public string getTitle()
        {
            string title = "";
            if (_grade == "S")
            {
                title = "Staff";
            } else
            {
                title = "Manager";
            }
            return title;
        } 
    }
}
