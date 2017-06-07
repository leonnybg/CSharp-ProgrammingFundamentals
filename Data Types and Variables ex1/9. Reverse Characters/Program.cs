using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters1 = char.Parse(Console.ReadLine());
            var letters2 = char.Parse(Console.ReadLine());
            var letters3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{letters3}{letters2}{letters1}");
        }
    }
}
