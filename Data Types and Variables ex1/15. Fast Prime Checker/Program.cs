using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int digits = 2; digits <= number; digits++)
            {
                bool itTrue = true;
                for (int divider = 2; divider <= Math.Sqrt(digits); divider++)
                {
                    if (digits % divider == 0)
                    {
                        itTrue = false;
                        break;
                    }
                }
                Console.WriteLine($"{digits} -> {itTrue}");
            }
        }
    }
}
