using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой вершины (x1, y1):");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины (x2, y2):");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты третей вершины (x3, y3):");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double side1 = Distanc(x1, y1, x2, y2);
            double side2 = Distanc(x2, y2, x3, y3);
            double side3 = Distanc(x3, y3, x1, y1);
            double perimeter = side1 + side2 + side3;
            Console.WriteLine($"Периметр треугольника: {perimeter}");
            Console.ReadKey();
        }
        static double Distanc(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
