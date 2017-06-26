using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());
            var product = num * multiplier;
            if (multiplier>10)
            {
                Console.WriteLine($"{num} X {multiplier} = {product}");
            }
            if (multiplier<=10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num*i}");
                }
            }
        }
    }
}
