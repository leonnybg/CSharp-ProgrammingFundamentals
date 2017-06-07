using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startWith = int.Parse(Console.ReadLine());
            int endWith = int.Parse(Console.ReadLine());
            char symbols1 = Convert.ToChar(startWith);
            char symbols2 = Convert.ToChar(endWith);
            for (char i = symbols1; i <= symbols2; i++)
            {                
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
        }
    }
}
