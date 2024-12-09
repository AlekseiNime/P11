using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {

        static void Main()
        {
            Console.Write("Введите радиус круга: ");
            double radius = double.Parse(Console.ReadLine());

            CalculateCircleProperties(radius);
            Console.ReadKey();
        }
        static void CalculateCircleProperties(double radius)
        {
            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine($"Радиус: {radius}");
            Console.WriteLine($"Площадь круга: {area}");
            Console.WriteLine($"Длина окружности: {circumference}");
        }
    }
}
