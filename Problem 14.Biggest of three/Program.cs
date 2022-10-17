using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Biggest_of_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a; int b; int c;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("Max = a" + "(" + a + ")");
            }
            if (b > a && b > c)
            {
                Console.WriteLine("Max = b" + "(" + b + ")");
            }
            if (c > a && c > b)
            {
                Console.WriteLine("Max = c" + "(" + c + ")");
            }
        }
    }
}
