using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a= ");
            int b = Input("b= ");
            int c = Input("c= ");
            int d = Input("d= ");
            Console.WriteLine($"до обмена: a={a}, b={b}, c={c}, d={d}");
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Console.WriteLine($"после обмена: a={a}, b={b}, c={c},d={d}");
            Console.Read();
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Swap(ref int x, ref int y)
        {
            int p = x;
             x = y;
            y = p;
        }
    }
}
