using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int startIndex = 0;
            int lenght = 1;
            int maxStartindex = 0;
            int maxLenth = 1;
            for (int i = 1; i < arrayInput.Length; i++)
            {
                if (arrayInput[i] > arrayInput[i - 1])
                {
                    lenght++;
                }
                else
                {
                    startIndex = i;
                    lenght = 1;
                }
                if (lenght > maxLenth)
                {
                    maxLenth = lenght;
                    maxStartindex = i - lenght + 1; //maxStartindex=startIndex
                
                }
            }

            int[] arrayOutput = arrayInput
                .Skip(maxStartindex)
                .Take(maxLenth)
                .ToArray();
            Console.WriteLine(string.Join(" ", arrayOutput));
        }
    }
}
