﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class GettingInputs
    {
        public void UserInput()
        {
            Console.Write("What is your name? "); // the Write the value of the console without shuting it down
            string myName = Console.ReadLine(); // this will read the user input and store it in the myName variable 
            Console.WriteLine("Welcome" + myName); // this will print the string Welcome and the concatinate with the name taken from the user input

            Console.ReadLine();
        }
    }
}
