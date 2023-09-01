using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class StringConcatination
    {
        public StringConcatination() 
        {
            string name = "Emmanuel Okoye";

            Console.WriteLine("May name are " + name); //this will join the string in the console and then concatinate it with the name stored in the variable
            Console.WriteLine("My name are " + name + " i live in Abuja"); //this will join the string in the console and then concatinate it with the name stored in the variable

            Console.ReadLine();
        }
    }
}
