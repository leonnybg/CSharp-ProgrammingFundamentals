using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //To “rotate an array on the right” means to move its last element first: {1, 2, 3}  {3, 1, 2}.
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationCount = int.Parse(Console.ReadLine());
            int[] sumArray = new int[arr.Length];

            for (int i=0; i<rotationCount;i++)
            {
                RotateArray(arr);
                for (int j=0;j<arr.Length;j++)
                {
                    sumArray[j] += arr[j];
                }
            }
            Console.WriteLine(string.Join(" ",sumArray));
        }

        public static void RotateArray(int[] arr)
        {
            var lastElement = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastElement;
        }        
    }
}
