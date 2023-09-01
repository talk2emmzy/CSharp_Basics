using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class NumbersInCSharp
    {
        public void BasicMathsOperation() 
        {
            Console.WriteLine(10 + 10); // this will add 10 with 10 and five us 20
            Console.WriteLine(10 - 5); // this will minus 10 from 5 and give us = 5
            Console.WriteLine(10 * 2); // this will multiply 10 by 2 and give us = 5
            Console.WriteLine(15 / 3); //this will divide 15 by 3 and give = 3
            Console.WriteLine(15 % 4); // this will divide 15 by 4 and give us the remainder = 3
            Console.WriteLine( 5 + 2 * 3 ); // this will multiply 2 by 3 and then add 5 which will = 11
            Console.WriteLine((5 + 2) * 3); // this will add 5 and 2 then multiply the outcome by 3 which is = 30 
        }

        public void BasicMathsOperation2()
        {
            int num = 6;
            Console.WriteLine(num); //this will print the number in 6 stored in the variable num

            int num2 = 7;
            int num3 = 8;
            Console.WriteLine(num2+num3); //this will print sum the value stored in num2 and num3 and will result = 15

        }
    }
}
