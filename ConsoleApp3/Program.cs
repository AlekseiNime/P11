using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int z = int.Parse(Console.ReadLine());

            Sort(ref x, ref y, ref z);

            Console.WriteLine("Числа в порядке возрастания: ");
            Console.WriteLine($"{x} {y} {z}");
            Console.ReadKey();
        }

        static void Sort(ref int x, ref int y, ref int z)
        {
            if (x > y) { int temp = x; x = y; y = temp; }
            if (y > z) { int temp = y; y = z; z = temp; }
            if (x > y) { int temp = x; x = y; y = temp; }
        }
    }
}
