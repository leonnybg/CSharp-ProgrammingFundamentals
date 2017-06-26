using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] counts = new int[65535];
            int maxCount = 0;
            int mostFrequentNumber = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                counts[inputArr[i]]++;
                if (counts[inputArr[i]] > maxCount)
                {
                    maxCount = counts[inputArr[i]];
                    mostFrequentNumber = inputArr[i];
                }
            }
            Console.WriteLine(mostFrequentNumber);
        }
    }
}
