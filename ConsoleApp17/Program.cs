using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value_1 = Input("value_1= ");
            int value_2 = Input("value_2= ");
            int value_3 = Input("value_3= ");
            int value_4 = Input("value_4= ");
            int value_5 = Input("value_5= ");
            int value_6 = Input("value_6= ");
            int value_7 = Input("value_7= ");
            int value_8 = Input("value_8= ");
            int max = Max8(value_1, value_2, value_3, value_4, value_5, value_6, value_7, value_8);
            Console.WriteLine($"{max}");
            Console.Read();
        }
        static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        static int Max2(int value, int value2)
        {
            return value > value2 ? value : value2;
        }
        static int Max8(int value_1,  int value_2, int value_3, int value_4, int value_5, int value_6, int value_7, int value_8)
        {
            int max1 = Max2(value_1, value_2);
            int max2 = Max2(value_3, value_4);
            int max3 = Max2(value_5, value_6);
            int max4 = Max2(value_7, value_8);
            int max12 = Max2(max1, max2);
            int max24 = Max2(max3, max4);
            int max = Max2(max12, max24);
            return max;
        }
    }
}
