using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            decimal total = 1;
            for (int i = 1; i <= n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                total = total * num;
            }
            Console.WriteLine(total);
        }
    }
}