using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object niz = hello + " " + world;
            // first way: string endGreeting = (string)niz; 
            //second way:
            string endGreeting = niz.ToString();
            Console.WriteLine(endGreeting);
        }
    }
}
