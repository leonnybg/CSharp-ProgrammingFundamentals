using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd_January2017Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            int maxCountLeft = ScanFromLeft(firstArray, secondArray);
            int maxCountRight = ScanFromRight(firstArray, secondArray);

            if (maxCountLeft == 0 && maxCountRight == 0)
            {
                Console.WriteLine(0);
            }
            else if (maxCountLeft > maxCountRight)
            {
                Console.WriteLine(maxCountLeft);
            }
            else
            {
                Console.WriteLine(maxCountRight);
            }
        }
        // secondMethod - scan array from right
        public static int ScanFromRight(string[] firstArray, string[] secondArray)
        {
            int count = 0;
            int maxCount = 0;

            if (firstArray.Length > secondArray.Length)
            {
                int longArrayIndex = firstArray.Length - 1; //index for longer first array

                for (int i = secondArray.Length - 1; i >= 0; i--) //two arrays are with different length
                {
                    if (firstArray[longArrayIndex] == secondArray[i]) //if last element in two arrays are equal.
                    {
                        count++;
                    }
                    else
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                        }
                        count = 0;
                    }

                    longArrayIndex--; //reduse this index in every iteration
                }
            }
            else //if secondArray is longer than firstArray
            {
                int longArrayIndex = secondArray.Length - 1; //last index in secondArray

                for (int i = firstArray.Length - 1; i >= 0; i--) //two arrays are with different length
                {
                    if (secondArray[longArrayIndex] == firstArray[i]) //if last element in two arrays are equal.
                    {
                        count++;
                    }
                    else
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                        }
                        count = 0;
                    }

                    longArrayIndex--; //reduse this index in every iteration
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            return maxCount;
        }

        //first method - scan array from left
        public static int ScanFromLeft(string[] firstArray, string[] secondArray)
        {
            int count = 0;
            int maxCount = 0;
            int minLength = Math.Min(firstArray.Length, secondArray.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
                else
                {
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            return maxCount;
        }
    }
}
