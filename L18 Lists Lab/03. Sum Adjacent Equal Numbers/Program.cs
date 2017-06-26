using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            double previousNum = nums[0];

            for (int i = 1; i < nums.Count; i++)
            {
                double currentNum = nums[i];

                if (currentNum == previousNum)
                {
                    double sum = currentNum + previousNum;
                    nums[i - 1] = sum;
                    nums[i] = sum;
                    nums.RemoveAt(i);
                    previousNum = nums[0];
                    i = 0;
                }
                else
                {
                    previousNum = nums[i];
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
            //var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //List<int> outputNumbers = new List<int>();
            //for (int i = 0; i < numbers.Count-1; i++)
            //{
            //    for (int j = 1; j < numbers.Count; j++)
            //    {
            //        if (numbers[i]==numbers[j])
            //        {
            //            int sum = numbers[i] + numbers[j];


            //        }
            //        else
            //        {
            //            continue;
            //        }
            //        outputNumbers[i] = numbers[i];
            //    }
            //}
            //Console.WriteLine(string.Join(" ", outputNumbers));
        

