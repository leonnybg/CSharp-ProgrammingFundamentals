using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int colloni = 1; colloni <= row; colloni++)
                {
                    Console.Write(" {0}",row);
                }
                Console.WriteLine();

            }

        }
    }
}
