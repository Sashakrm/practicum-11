using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = Input("x1= ");
            int x2 = Input("x2= ");
            int x3 = Input("x3= ");
            int x4 = Input("x4= ");
            int x5 = Input("x5= ");
            int y1 = Input("y1= ");
            int y2 = Input("y2= ");
            int y3 = Input("y3= ");
            int y4 = Input("y4= ");
            int y5 = Input("y5= ");
            double result = Pentagon(x1, x2, x3, x4, x5, y1, y2, y3, y4, y5);
            Console.WriteLine($"Площадь пятиугольника: {result}");
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static double Distance(double x1, double y1, double x2,double y2, double x3, double y3)
        {
            return Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2;
        }
        static double Pentagon (int x1, int x2, int x3, int x4, int x5, int y1, int y2, int y3, int y4, int y5)
        {
            double a = Distance(x1, y1, x2, y2, x3, y3);
            double b = Distance(x1, y1, x3, y3, x4, y4);
            double c = Distance(x1, y1, x4, y4, x5, y5);
            return a + b + c;
        }
    }
}
