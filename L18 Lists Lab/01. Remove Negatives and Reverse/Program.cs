using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Reverse();
            List<int> nums = new List<int>();
            int count = 0;
            foreach (var num in numbers)
            {
                if (num >= 0)
                {
                    count++;
                    nums.Add(num);
                    Console.Write("{0} ", num);
                }
                else if (num<0)
                {
                    nums.Remove(num);                 
                   
                }
            } 
              
            if (count==0)
            {
                Console.Write("empty");
            }
            Console.WriteLine();
        }
    }
}
