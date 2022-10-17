using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Big_and_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; bool result;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            if (n > 20 && n % 2 != 0)
            {
                result = true;
                Console.WriteLine(result);
            }
            else
            {
                result = false;
                Console.WriteLine(result);
            }
        }
    }
}
