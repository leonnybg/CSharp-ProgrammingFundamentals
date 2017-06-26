using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] charArr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arrA = charArr1;
            char[] arrB = charArr2;
            int index = 0;
            while (true)
            {
                if (charArr1[index] < charArr2[index]) break;
                if (charArr1[index] > charArr2[index])
                {
                    arrA = charArr2;
                    arrB = charArr1;
                    break;
                }
                else
                {
                    index++;
                    if (index == charArr1.Length) break;
                    else if (index == charArr2.Length)
                    {
                        arrA = charArr2;
                        arrB = charArr1;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join("", arrA));
            Console.WriteLine(string.Join("", arrB));
        }
    }
}
