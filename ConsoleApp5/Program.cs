using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
            static double CalculatePerimeter(double a, double b, double c)
            {
                return a + b + c;
            }

            static double CalculateArea(double a, double b, double c)
            {
                double s = (a + b + c) / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }

            static void Main()
            {

                Console.WriteLine("Введите стороны первого треугольника:");
                double a1 = double.Parse(Console.ReadLine());
                double b1 = double.Parse(Console.ReadLine());
                double c1 = double.Parse(Console.ReadLine());


                Console.WriteLine("Введите стороны второго треугольника:");
                double a2 = double.Parse(Console.ReadLine());
                double b2 = double.Parse(Console.ReadLine());
                double c2 = double.Parse(Console.ReadLine());


                double perimeter1 = CalculatePerimeter(a1, b1, c1);
                double area1 = CalculateArea(a1, b1, c1);

                double perimeter2 = CalculatePerimeter(a2, b2, c2);
                double area2 = CalculateArea(a2, b2, c2);


                Console.WriteLine($"Периметр первого треугольника: {perimeter1}");
                Console.WriteLine($"Площадь первого треугольника: {area1}");

                Console.WriteLine($"Периметр второго треугольника: {perimeter2}");
                Console.WriteLine($"Площадь второго треугольника: {area2}");


                double totalPerimeter = perimeter1 + perimeter2;
                double totalArea = area1 + area2;

                Console.WriteLine($"Сумма периметров: {totalPerimeter}");
                Console.WriteLine($"Сумма площадей: {totalArea}");
            }
    }
}
