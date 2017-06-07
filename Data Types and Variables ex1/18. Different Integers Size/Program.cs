using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = Console.ReadLine();
            try
            {
                long number = long.Parse(inputNumber);
                Console.WriteLine("{0} can fit in:", number);
                //(sbyte < byte < short < ushort < int < uint < long).
                if (number >= -128 && number <= 127) //[-128 …127]: sbyte
                {

                    Console.WriteLine("* sbyte");
                }
                if (number >= 0 && number <= 255)   //[0 … 255]: byte
                {
                    Console.WriteLine("* byte");
                }
                if (number <= 32767 && number >= -32768) //[-32 768 … 32 767]: short

                {
                    Console.WriteLine("* short");
                }
                if (number >= 0 && number <= 65535) //ushort [0 … 65 535]: 
                {
                    Console.WriteLine("* ushort");
                }
                if (number <= 2147483647 && number >= -2147483648) //int
                {
                    Console.WriteLine("* int");
                }
                if (number <= 4294967295 && number > 0)//uint
                {
                    Console.WriteLine("* uint");
                }
                if (number <= long.MaxValue && number >= long.MinValue) //long
                {
                    Console.WriteLine("* long");
                }
            }
            catch(Exception)
            {
                Console.WriteLine($"{inputNumber} can't fit in any type");
            }        
            
        }
    }
}
