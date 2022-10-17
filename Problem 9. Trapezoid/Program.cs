using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Trapezoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a; double b; double h; double area;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            h = double.Parse(Console.ReadLine());
            area = ((a + b) / 2) * h;
            Console.WriteLine(area);
        }
    }
}
