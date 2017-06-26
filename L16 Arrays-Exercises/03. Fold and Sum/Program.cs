using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = inputArray.Length / 4;
            int[] leftArray = new int[k];
            int[] middleArray = new int[2 * k];
            int[] rightArray = new int[k];
            int[] resultArray = new int[2 * k];

            for (int i = 0; i < k; i++) //leftArray elements
            {
                leftArray[i] = inputArray[i];
            }

            for (int i = 0; i < 2*k; i++) //middleArray elements
            {
                middleArray[i] = inputArray[i + k];
            }

            for (int i = 0; i < k; i++) //rightArray elements
            {
                rightArray[i] = inputArray[3 * k + i];
            }

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            for (int i = 0; i < k; i++)
            {
                resultArray[i] = leftArray[i] + middleArray[i];
                resultArray[i + k] = rightArray[i] + middleArray[i + k];
            }
            Console.WriteLine(string.Join(" ",resultArray));         
           
        }
    }
}
