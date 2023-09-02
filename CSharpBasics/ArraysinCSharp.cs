using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class ArraysinCSharp
    {
        public static void TypeofArrays()
        {
            // We use Array becuase it can store multiple pieces of data instead, a variable can only store one
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, }; // this [] is used to tell CSharp you writing an Array, and thi
            Console.WriteLine(numbers); // this will print the list of numbers in the Array
            Console.WriteLine(numbers[1]); // this will print the index of the number in the Array = 2

            string[] friends = new string[5]; //[5] this will tell the computer the number of Array the variable "friends" can hold
            friends[0] = "a"; // this is one of the item to be stored in the Array
            friends[1] = "b"; // this is one of the item to be stored in the Array
            friends[2] = "c"; // this is one of the item to be stored in the Array
            friends[3] = "d"; // this is one of the item to be stored in the Array
            friends[4] = "e"; // this is one of the item to be stored in the Array

            Console.WriteLine(friends); // this will print the list of items stored in the Array
        }
    }
}
