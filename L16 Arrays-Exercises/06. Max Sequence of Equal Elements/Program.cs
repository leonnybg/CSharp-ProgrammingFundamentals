using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray(); //var arrayInput=...
            var startIndex = 0;
            var bestStartIndex = 0;
            var sequenceLength = 1;
            var bestSiquenceLength = 1; 

            for (int i=1; i<arr.Length;i++)
            {
                if(arr[i]==arr[i-1])
                {
                    sequenceLength++;
                }
                else
                {
                    startIndex = i;
                    sequenceLength = 1;
                }
                if(sequenceLength>bestSiquenceLength)
                {
                    bestSiquenceLength = sequenceLength;
                    bestStartIndex = i - sequenceLength + 1; 
                   
                }
            }
            for (int i = bestStartIndex; i < bestStartIndex+bestSiquenceLength; i++)
            {
                Console.Write(arr[i] + " ");
                // int[] arrayOutput = arrayInput
                //.Skip(maxStartindex)
                //.Take(maxLenth)
                //.ToArray();
                //Console.WriteLine(string.Join(" ", arrayOutput));
            }
            Console.WriteLine();
        }
    }
}
