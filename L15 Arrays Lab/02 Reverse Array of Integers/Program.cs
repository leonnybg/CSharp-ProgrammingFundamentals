using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];           
            int length = array.Length;
            int[] reversedArray = new int[length];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                reversedArray[n - 1 - i] = array[i];
            }
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ",reversedArray[i]);
            }
            Console.WriteLine();         

        }
    }
}
