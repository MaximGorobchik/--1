using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Sign_of_product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a; double b; double c; string product = "1";
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            if (a < 0 || b < 0 || c < 0)
            {
                product = "negative";
            }
            if (a < 0 && b < 0 && c < 0)
            {
                product = "negative";
            }
            if (a > 0 && b > 0 && c > 0)
            {
                product = "positive";
            }
            if (a > 0 && b < 0 && c < 0)
            {
                product = "positive";
            }
            if (a < 0 && b < 0 && c > 0)
            {
                product = "positive";
            }
            if (a < 0 && b > 0 && c < 0)
            {
                product = "positive";
            }
            Console.WriteLine(product);
        }
    }
}
