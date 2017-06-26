using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstWordArray = Console.ReadLine().Split(' ').ToArray(); //var arr1=CRL().Split();
            string[] secondWordArray = Console.ReadLine().Split(' ').ToArray(); //var arr2=CRL().Split();
                        
            //string[] array1 = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //string[] array2 = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int leftCount = 0;
            int rightCount = 0;
            var smallerArrayLength = Math.Min(firstWordArray.Length, secondWordArray.Length);
            for (int i = 0; i <smallerArrayLength ; i++)
            {
                if (firstWordArray[i] == secondWordArray[i])
                {
                    leftCount++;
                }
                if (firstWordArray[firstWordArray.Length - 1 - i] == secondWordArray[secondWordArray.Length - 1 - i])
                //if (arr1[arr1.Length-1]==arr2.Length-1])
                {
                    rightCount++;
                }
            }
            //Console.WriteLine(Math.Max(leftCount, rightCount));
            if (leftCount >= rightCount)
                Console.WriteLine(leftCount);
            else
                Console.WriteLine(rightCount);
        }
    }
}
