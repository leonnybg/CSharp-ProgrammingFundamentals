﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
             
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int currentNum = num;
                while (currentNum > 0)
                {
                    sumOfDigits += currentNum % 10;
                    currentNum = currentNum / 10;
                }
                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{num} -> {isSpecial}");
               
            }

        }
    }
}
