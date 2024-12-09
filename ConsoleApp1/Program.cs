using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
            static void Main()
            {
                string str1 = "Hello";
                string str2 = "World";

                Console.WriteLine("До обмена:");
                Console.WriteLine("str1: " + str1);
                Console.WriteLine("str2: " + str2);

                SwapStrings(ref str1, ref str2);

                Console.WriteLine("После обмена:");
                Console.WriteLine("str1: " + str1);
                Console.WriteLine("str2: " + str2);
                Console.ReadKey();
            }
            static void SwapStrings(ref string str1, ref string str2)
            {
                string temp = str1;
                str1 = str2;
                str2 = temp;
            }
    }
}
