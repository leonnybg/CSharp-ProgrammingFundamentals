using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    sum = i + j;
                    counter++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicNumber}");
                        return;
                    }               
                }
            }
           Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
        }
    }
}

