using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {/// <summary>
     /// Составить программу, в результате которой величина а меняется значением с величиной b, а величина c — с величиной d.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("b=");
            int d = Input("b=");
            Console.WriteLine($"До обмена: {a}\t{b}\t{c}\t{d}");
            
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Console.WriteLine($"После обмена:{a}\t{b}\t{c}\t{d}");
            Console.ReadKey();
        }
        public static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Swap(ref int x, ref int y)
        {
            int p = x;
            x = y;
            y = p;
        }
    }
}
