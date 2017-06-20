using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < Math.Max(arr1.Length,arr2.Length); i++)
            {
                if (arr1.Length==arr2.Length)          
                {
                    int sum = arr1[i] + arr2[i];
                    Console.Write("{0} ",sum);
                }
                           
                else if (arr1.Length != arr2.Length)
                {
                    
                    if (arr1.Length > arr2.Length)
                    {
                        int[] result = new int[Math.Max(arr1.Length, arr2.Length)];
                        result[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
                        Console.Write("{0} ", result[i]);
                    }
                    else
                    {
                        int[] result = new int[Math.Max(arr1.Length, arr2.Length)];
                        result[i] = arr2[i % arr2.Length] + arr1[i % arr1.Length];
                        Console.Write("{0} ", result[i]);
                    }
                }                                
            }
            Console.WriteLine();
        }
    }
}
