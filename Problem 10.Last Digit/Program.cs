using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; int LastDigit;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            LastDigit = n % 10;
            Console.WriteLine(LastDigit);
        }
    }
}
