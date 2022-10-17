using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.N_th_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; int n; int nDigit;
            Console.Write("number = ");
            number = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int q = Convert.ToInt32(Math.Pow(10, n - 1));
            nDigit = (number/q)%10;
            Console.WriteLine(nDigit);
        }
    }
}
