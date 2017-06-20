using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_ArrayToNumber_StrangeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metod sys spisyci...
            List<int> intList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            for (int i = intList.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < intList.Count; j++)
                {
                    if (j + 1 < intList.Count)
                    {
                        intList[j] += intList[j + 1];
                    }
                    else
                    {
                        intList.RemoveRange(intList.Count - 1, 1);
                    }
                }
            }

            Console.WriteLine(intList[0]);
        }
    }
}
