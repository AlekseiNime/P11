using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {


        static void Main()
        {
            int a = 1, b = 2, c = 3, d = 4;

            Console.WriteLine("До обмена:");
            Console.WriteLine($"a: {a}, b: {b}, c: {c}, d: {d}");

            SwapValues(ref a, ref b, ref c, ref d);

            Console.WriteLine("После обмена:");
            Console.WriteLine($"a: {a}, b: {b}, c: {c}, d: {d}");
            Console.ReadKey();
        }

        static void SwapValues(ref int a, ref int b, ref int c, ref int d)
        {
            int temp = a;
            a = b;
            b = temp;

            temp = c;
            c = d;
            d = temp;
        }
    }
}
