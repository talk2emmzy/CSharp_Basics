using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class StringConverstion
    {
        public void StringToIntiger()
        {
            int num = Convert.ToInt32("100"); // the word "Convert.ToInt32" will help us Connvert the string "100" 
            int num2 = 50;
            Console.WriteLine(num + num2);
        }
    }
}
