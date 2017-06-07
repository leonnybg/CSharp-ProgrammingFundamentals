using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:\na = 5\nb = 10");
            var newa = b;
            b = a;
            Console.WriteLine($"After:\na = {newa}\nb = {b}");
        }
    }
}
