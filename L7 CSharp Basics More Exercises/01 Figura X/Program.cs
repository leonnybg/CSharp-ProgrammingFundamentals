using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Figura_X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("x{0}x", new string (' ',n));
            var middle = (n - 1) / 2;
            for (int i=1; i<=middle;i++)
            {
                for (int j = 1; j <= i; j++)
                { Console.WriteLine("{0}x{1}x", new string(' ', j), new string(' ',i)); }
            }
        }
    }
}
