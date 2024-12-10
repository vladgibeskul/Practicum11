using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника:");
            Console.Write("Cторона а=");
            double a1=double.Parse(Console.ReadLine());
            Console.Write("Cторона b=");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Cторона c=");
            double c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника:");
            Console.Write("Cторона а=");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Cторона b=");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("Cторона c=");
            double c2 = double.Parse(Console.ReadLine());
            double perimeter1 = Perim(a1, b1, c1);
            double area1 = Area(a1, b1, c1);
            double perimeter2 = Perim(a2, b2, c2);
            double area2 = Area(a2, b2, c2);
            Console.WriteLine($"Периметр первого триугольника={perimeter1}");
            Console.WriteLine($"Периметр второго триугольника={perimeter2}");
            Console.WriteLine($"Площадь первого триугольник={area1}");
            Console.WriteLine($"Площадь второго триугольник={area2}");
            Console.ReadKey();  

        }
        //Метод для преиметра триугольника
        public static double Perim(double a, double b, double c)
        {
            return a + b + c;
        }
        // метод для площади триугольника 
        static double Area(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

    }
}
