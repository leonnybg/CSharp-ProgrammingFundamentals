﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayString = Console.ReadLine().Split(' ').ToArray();
            for (int i = arrayString.Length-1; i >=0 ; i--)
            {
                Console.Write("{0} ", arrayString[i]);
            }
            Console.WriteLine();
        }
    }
}
