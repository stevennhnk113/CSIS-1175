using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Week3Demo7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "simon", "Priya", "Ivan", "Ray" };
            foreach(string name in names)
            {
                WriteLine(name);
            }

            for(int x = 0; x < names.Length; x++)
            {
                WriteLine(names[x]);
            }

            int y = 0;
            while(y < names.Length)
            {
                WriteLine(names[y]);
                y++;
            }
            ReadKey();
        }
    }
}
