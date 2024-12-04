using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{ /// <summary>
/// Поменять местами содержимое двух строковых переменных.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Это первая строка";
            string str2 = "Это вторая строка";
            Console.WriteLine($"Cтроки до обмена:{str1}\t{str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"После обмена:{str1}\t{str2}");
            Console.ReadKey();
        }
        public static void Swap(ref string str1, ref string str2)
        {
            string p = str1;
            str1 = str2;
            str2 = p;
        }
    }
}
