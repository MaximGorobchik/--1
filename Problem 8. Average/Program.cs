using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Average
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
            double average = (double)(a + b + c) / 3;
            Console.WriteLine("Average = " + average);
        }
    }
}
