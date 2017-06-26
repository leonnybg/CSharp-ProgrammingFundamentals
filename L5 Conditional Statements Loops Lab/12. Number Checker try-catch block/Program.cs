using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Number_Checker_try_catch_block
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            try
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
