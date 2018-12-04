using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Demo
{
    class Employee
    {

        private string eId;
        private string firstName;
        private string lastName;

        public Employee(string eId, string firstName, string lastName)
        {
            this.eId = eId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Employee()
        {

        }

        public string getId()
        {
            return eId;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }


        public string getFullName()
        {
            return firstName + " " + lastName;
        }
        //public string EId { get => eId; set => eId = value; }
        //public string FirstName { get => firstName; set => firstName = value; }
        //public string LastName { get => lastName; set => lastName = value; }
    }
}
