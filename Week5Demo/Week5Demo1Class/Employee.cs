using System;

namespace Week5Demo1Class
{
    class Employee
    {
        //private fields to describe elements in your class
        private string _id;
        private string _name;
        private string _grade;
        private double _hrs;
        private double _rate;

        //constructor to receive data from outer calling
        public Employee(string id, string name, 
            string grade, double hrs, double rate)
        {
            _id = id;
            _name = name;
            _grade = grade;
            _hrs = hrs;
            _rate = rate;
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
            } else
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
