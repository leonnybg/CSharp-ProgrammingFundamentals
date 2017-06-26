using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            if (text.EndsWith("y"))
            {
                text = text.Remove(text.Length - 1);
                text = text + "ies";
                Console.WriteLine(text);
            }
            //in o, ch, s, sh, x or z 
            else if (text.EndsWith("o") || text.EndsWith("ch") || text.EndsWith("s") ||
                text.EndsWith("sh") || text.EndsWith("x") || text.EndsWith("z"))
            {
                text = text + "es";
                Console.WriteLine(text);
            }
            else
            {
                text += "s";
                Console.WriteLine(text);
            }
        }
    }
}


