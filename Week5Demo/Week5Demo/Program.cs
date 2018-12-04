using System;
using static System.Console;
using System.IO;

namespace Week5Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object called inFile
            //that is based on the streamReader class
            StreamReader inFile;
            //Associate inFile with CustomerDeposit.csv in folder
            //and open the text file
            inFile = File.OpenText(@"E:\1175-008\repos\CustomerDeposit.csv");
            string[] inputLine;
            double depositAmt;
            double totalAmt = 0;
            while (inFile.EndOfStream != true)
            {
                inputLine = inFile.ReadLine().Split(',');
                depositAmt = double.Parse(inputLine[2]);
                totalAmt += depositAmt;
                WriteLine(inputLine[1] + " " + depositAmt);
            }
            inFile.Close();
            WriteLine();
            WriteLine("Total amount : " + totalAmt);
            ReadKey();
        }
    }
}
