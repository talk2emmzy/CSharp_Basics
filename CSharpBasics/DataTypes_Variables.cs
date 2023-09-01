using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class DataTypes_Variables
    {
        static void Main()
        {
            string phrase = "James is still in Nigeria"; // this is used for storing words 
            int year_of_birth = 2005; // this is used for numbers with no decimal
            char alphabet = 'A'; // this is used for single charachters
            double longitude = 6.00999; // this is best for storing decimal number
            decimal amount = 15000; // this is used for money value
            bool is_deactive = false; // this is used to check is something is true or false
            bool is_active = true; // this is used to store a true or false information


            Console.WriteLine(phrase);
            Console.WriteLine(year_of_birth);   
            Console.WriteLine(alphabet);
            Console.WriteLine(longitude);
            Console.WriteLine(amount);
            Console.WriteLine(is_deactive);
            Console.WriteLine(phrase);
            Console.WriteLine(is_active);

            Console.ReadLine();

        }
    }
}
