using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week3Demo5
{
    class Program
    {
        const string TELUS = "telus";
        const string BELL = "bell";
        const string ROGER = "roger";
        

        static void Main(string[] args)
        {
            string phoneCo = "";
            //GetPhoneCo(phoneCo);
            GetNewCo(phoneCo);
        }

        public static void GetNewCo(string compay)
        {
            bool ok = false;
            while(!ok)
            {
                WriteLine("Which phone company do you have a plan with?");
                compay = ReadLine();
                if (compay.ToLower() != TELUS & compay.ToLower() != BELL & compay.ToLower() != ROGER)
                {
                    WriteLine("You have make a good choice not with the big 3");
                    ReadKey();
                    ok = true;
                }
            }
        }

        public static void GetPhoneCo(string company)
        {
            WriteLine("Which phone company do you have a plan with?");
            company = ReadLine();

            while(company.ToLower() != TELUS && company.ToLower() != BELL)
            {
                WriteLine("Company name is invalid, please enter again");
                company = ReadLine();
            }

            WriteLine("You have make a good choice");
            ReadKey();
        }
    }
}
