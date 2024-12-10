using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void DetermineTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Треугольник равносторонний.");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Треугольник равнобедренный.");
            }
            else if (IsRightAngled(a, b, c))
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            else
            {
                Console.WriteLine("Треугольник обычный.");
            }
        }

        static bool IsRightAngled(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides); 
            return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-6;
        }

        static void Main()
        {
            Console.WriteLine("Введите координаты вершин треугольника:");

            Console.Write("x1, y1: ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("x2, y2: ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("x3, y3: ");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double side1 = Distance(x1, y1, x2, y2);
            double side2 = Distance(x2, y2, x3, y3);
            double side3 = Distance(x3, y3, x1, y1);

            DetermineTriangleType(side1, side2, side3);
            Console.ReadKey();
        }
    }

}
