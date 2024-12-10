using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты вершин пятиугольника:");
            Console.Write("x1, y1: ");
            var (x1, y1) = ReadCoordinates();
            Console.Write("x2, y2: ");
            var (x2, y2) = ReadCoordinates();
            Console.Write("x3, y3: ");
            var (x3, y3) = ReadCoordinates();
            Console.Write("x4, y4: ");
            var (x4, y4) = ReadCoordinates();
            Console.Write("x5, y5: ");
            var (x5, y5) = ReadCoordinates();

            double area1 = CalculateTriangleArea(x1, y1, x2, y2, x3, y3);
            double area2 = CalculateTriangleArea(x1, y1, x3, y3, x4, y4);
            double area3 = CalculateTriangleArea(x1, y1, x4, y4, x5, y5);

            double pentagonArea = area1 + area2 + area3;

            Console.WriteLine($"Площадь пятиугольника: {pentagonArea}");
            Console.ReadLine();
        }
        static (double x, double y) ReadCoordinates()
        {
            string[] input = Console.ReadLine().Split(',');
            double x = double.Parse(input[0].Trim());
            double y = double.Parse(input[1].Trim());
            return (x, y);
        }

        static double CalculateTriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
        }
    }
}
