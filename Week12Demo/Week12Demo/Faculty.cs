using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Demo
{
    //Faculty class is to extend the Employee class
    //with their properties

    //Employee is called parent or base class
    //In java it is super class
    class Faculty : Employee
    {
        private string _dept;
        private double _salary;

        //base keyword is to map with properties 
        //from Employee class
        public Faculty(string id, string firstName, string lastName, 
            string dept, double salary)
               :base (id, firstName, lastName)
        {
            this._dept = dept;
            this._salary = salary;
        }

        //create class getDepartment
        public string getDept()
        {
            return _dept;
        }

        public double getSalary()
        {
            return _salary;
        }
    }
}
