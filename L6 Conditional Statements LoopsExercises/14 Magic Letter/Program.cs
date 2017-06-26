using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char noLetter = char.Parse(Console.ReadLine());
            for (char i= firstLetter;i<=secondLetter;i++)
            {
                for (char j=firstLetter; j<=secondLetter;j++)
                {
                    for (char k=firstLetter;k<=secondLetter;k++)
                    {
                        if(i==noLetter||j==noLetter||k==noLetter)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
