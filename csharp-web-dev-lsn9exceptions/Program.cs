using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Divider is zero");
            }
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            int score = 0;
            if (fileName == "")
            {
                throw new ArgumentNullException("Argument is null");
            }
            if (fileName == "MyCode.cs" || fileName == "CoolProgram.cs")
            {
                score = 1;
            }
            else if (fileName == "Program.cs")
            {
                score = 0;
            }
            return score;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            try
            {
                Console.WriteLine(Divide(4, 0));
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Cannot be divided by zero!");
            }

            try
            {
                Console.WriteLine(CheckFileExtension(students["Elizabeth"]));
                Console.WriteLine(CheckFileExtension(students["Brad"]));
                
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Error: Argument is null");
            }
            finally
            {
                Console.WriteLine(CheckFileExtension(students["Carl"]));
            }


        }
    }
}
