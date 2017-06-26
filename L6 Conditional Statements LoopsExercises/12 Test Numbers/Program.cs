using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            var totalSum = 0;
            var counter = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    totalSum = totalSum + (i * j * 3);
                    counter++;
                    if (totalSum >= maxSum)
                    {
                        Console.WriteLine("{0} combinations", counter);
                        Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations", counter);
            Console.WriteLine("Sum: {0}", totalSum);
        }
    }
}
