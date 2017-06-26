using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_metod
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (IsOdd(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
    }
}
