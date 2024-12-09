using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x1 = Input("x1= ");
            var x2 = Input("x2= ");
            var x3 = Input("x3= ");
            var y1 = Input("y1= ");
            var y2 = Input("y2= ");
            var y3 = Input("y3= ");
            var side1 = Side(x1, y1, x2, y2);
            var side2 = Side(x2, y2, x3, y3);
            var side3 = Side(x3, y3, x1, y1);
            String Type1 = Type(side1, side2, side3);
            Console.WriteLine($"Тип треугольника: {Type1}");
        }
        static double Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        public static double Side(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
        }
        public static string Type(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Равносторонний";
            }
            else if (side1 == side2 && side2 <= side3 && side2 >= side3)
            {
                return "Равнобедренный";
            }
            else if (Pefagor(side1,side2,side3))
            {
                return "Прямоугольный"; 
            }
            else
            {
                return "Обычный";
            }
        }
        public static bool Pefagor(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
