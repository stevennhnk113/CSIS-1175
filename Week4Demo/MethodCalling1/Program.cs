using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCalling1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static string getFirstName(string name)
        {
            string[] newName = name.Split(' ');
            return newName[0];
        }
    }
}
