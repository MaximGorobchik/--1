using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Pure_Divisor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; bool result;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            if (n % 9 == 0 || n % 11 == 0 || n % 13 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            Console.WriteLine(result);
        }
    }
}
