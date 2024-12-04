using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {/// <summary>
     /// cоздать метод, который будет вычислять площадь круга и длину окружности. Вызывающий программный код должен передавать в качестве аргумента методу значение радиуса и печатать значение радиуса, площади круга и длины окружности.
     ///      /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            int r = Input("r=");
            double p = 1, s = 1;
            Func(r, ref p, ref s);
            Console.WriteLine($"Длина окружности: {p}");
            Console.WriteLine($"Площадь круга: {s}");
            Console.ReadLine();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Func(int r, ref double p, ref double s)
        {
            p=2*Math.PI*r;
            s=Math.PI*Math.Pow(r,2);
        }
    }
}
