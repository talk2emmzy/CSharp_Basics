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
            Console.WriteLine(name.Length); // this method "Lenght" is used to count the number of character in the string
            Console.WriteLine(name.ToUpper()); // this method "ToUpper" is used to convert a string to upper case
            Console.WriteLine(name.Contains("Emmanuel")); // this method "Contains" is to check if the string value contains the Emmanuel in it and will return a true value if exist, else false
            Console.WriteLine(name[2]); // this method [2] is used to show the index of the string 2 in the name variable
            Console.WriteLine(name.IndexOf("Emmanuel")); // this method "IndexOf" shows what index position the string word Emmanuel starts from
            Console.WriteLine(name.Substring(8)); // this method "Substring" is used to collect some part of the string, ths will pick " Okoye" as the output
            Console.WriteLine(name.Substring(0,8)); // this method "Substring" is used to collect a range of string from 0 to 8, output will be "Emmanuel"


            Console.ReadLine();
        }
    }
}
