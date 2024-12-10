using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты вершины A (x1, y1):");
            var A = ReadPoint();

            Console.WriteLine("Введите координаты вершины B (x2, y2):");
            var B = ReadPoint();

            Console.WriteLine("Введите координаты вершины C (x3, y3):");
            var C = ReadPoint();

            double AB = GetDistance(A, B);
            double BC = GetDistance(B, C);
            double CA = GetDistance(C, A);

            string triangleType = GetTriangleType(AB, BC, CA);

            Console.WriteLine($"Вид треугольника: {triangleType}");
            Console.ReadKey();
        }
        static (double x, double y) ReadPoint()
        {
            var input = Console.ReadLine().Split(',');
            double x = Convert.ToDouble(input[0]);
            double y = Convert.ToDouble(input[1]);
            return (x, y);
        }
        static double GetDistance((double x, double y) p1, (double x, double y) p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }
        static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
                return "равносторонний";
            else if (a == b || b == c || a == c)
                return "равнобедренный";

            if (IsRightTriangle(a, b, c))
                return "прямоугольный";

            return "обычный";
        }
        static bool IsRightTriangle(double a, double b, double c)
        {
            var sides = new[] { a, b, c };
            Array.Sort(sides);
            return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-10;
        }
    }
}
