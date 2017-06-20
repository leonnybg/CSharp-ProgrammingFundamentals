using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = array.Length;
            if (n==1)
            {
                Console.WriteLine($"{{ {array[0]} }}");
            }
            else if (n%2==0)
            {
                Console.WriteLine($"{{ {array[n/2-1]}, {array[n/2]} }} ");
            }
            else if (n%2==1)
            {
                Console.WriteLine($"{{ {array[n / 2 - 1]}, {array[n / 2]}, {array[n/2+1]} }} ");
            }
        }
    }
}
