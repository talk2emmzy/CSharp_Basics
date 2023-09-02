using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Calculator
    {
        public void BasicCalculator()
        {
            // Convert.ToDouble is used to convert digit to doubles, Convert.ToInt32 is used to convert a string to number

            Console.Write("What is your name? "); // this will ask the user for an Input
            int num3 = Convert.ToInt32(Console.ReadLine()); // this will take the user input and store it in a variable num3
            Console.Write("What is your name? "); // this will ask the user for an Input
            int num4 = Convert.ToInt32(Console.ReadLine()); // this will take the user input and store it in a variable num4

            Console.WriteLine(num3 + num4); // this will sum up the user input store in num3 and num4 variables

            Console.ReadLine(); // this will keep the terminal open
        }
    }
}
