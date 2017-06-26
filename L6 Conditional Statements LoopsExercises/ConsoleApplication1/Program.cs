using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string strvar = "abc+";
                bool x;
                x = strvar.EndsWith("c+");
                Console.WriteLine(x.ToString());
            }

        }
    }
}
