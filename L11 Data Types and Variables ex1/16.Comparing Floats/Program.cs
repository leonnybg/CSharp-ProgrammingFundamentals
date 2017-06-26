using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var eps = 0.000001D;
            var diff = Math.Abs(a - b);
            bool isEps = true;
            if (diff < eps)
            {
                Console.WriteLine(isEps);
            }
            else
            {
                Console.WriteLine(!isEps);
            }
        }
    }
}
