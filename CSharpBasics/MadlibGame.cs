using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class MadlibGame
    {
        public static void WordGame()
        {
            String color, pluralNoun, celebrityName; //here we are creating our variables

            Console.Write("Enter a color? "); // here we are taking the user input 
            color = Console.ReadLine(); // here we are storing the user input into our variable

            Console.Write("Enter a color? "); // here we are taking the user input 
            pluralNoun = Console.ReadLine(); // here we are storing the user input into our variable

            Console.Write("Enter a color? "); // here we are taking the user input 
            celebrityName = Console.ReadLine(); // here we are storing the user input into our variable

            Console.WriteLine("Reses are" + color); //here we are able to print the string and the user input stored in the variable 
            Console.WriteLine(pluralNoun + "are blue"); //here we are able to print the string and the user input stored in the variable
            Console.WriteLine("I love" + celebrityName); //here we are able to print the string and the user input stored in the variable
        } 
    }
}
