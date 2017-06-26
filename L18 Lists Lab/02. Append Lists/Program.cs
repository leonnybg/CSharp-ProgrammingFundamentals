using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {          
            List<string> numString = Console.ReadLine().Split('|').ToList();
            for (int i = 0; i < numString.Count; i++)
            {
                List<int> result = numString[i].Split(new[] { " " }, StringSplitOptions.
                    RemoveEmptyEntries).Select(int.Parse).ToList();
                numString[i] = string.Join(" ", result);
            }
            numString.Reverse();
            Console.WriteLine(string.Join(" ", numString));
        }
    }
}


