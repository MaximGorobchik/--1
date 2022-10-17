using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17.Calculate_N_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; int factorial = 1;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n;i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
