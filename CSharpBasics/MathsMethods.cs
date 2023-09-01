using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharpBasics
{
    internal class MathsMethods
    {
        public void WorkingwithMethods()
        {
            Console.WriteLine(Math.Pow(10,2)); // this will be calculated as 10 raise to the power of 2
            Console.WriteLine(Math.Pow(3.8,2)); //this will be calculated as 3.8 raise to the power of 2
            Console.WriteLine(Math.Sqrt(10)); // this will give us the square root of 10
            Console.WriteLine(Math.Max(100,10)); // this will tell us which number is the biggest among 100 and 10
            Console.WriteLine(Math.Min(50,5)); // this will tell us which number is the smallest among 50 and 5
        }
    }
}
