using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а=");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b=");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число с=");
            int c=int.Parse(Console.ReadLine());
            int[] numbers = { a, b, c };
            Array.Sort(numbers);
            Console.WriteLine("Числа по возрастанию: " + string.Join(", ", numbers));
        }
        
    }
}
