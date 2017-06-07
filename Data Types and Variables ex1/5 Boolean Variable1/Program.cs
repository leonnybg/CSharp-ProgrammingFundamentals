using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Boolean_Variable1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            bool output = Convert.ToBoolean(input);

            Console.WriteLine(output  "Yes" : "No");
        }
    }
}
