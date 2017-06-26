using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters_Lio
{
    class Program
    {
        static void Main(string[] args)
        {

            //var alphabet = new char['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
            //    'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
            ////char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            //string wordLetter = Console.ReadLine();
            //var wordArray = new char[Convert.ToChar(wordLetter)];
            //for (int i = 0; i < alphabet.Length; i++)
            //{
            //    for (int indexWord = 0; indexWord < wordArray.Length; indexWord++)
            //    {
            //       if( alphabet[i]==
            //    }
            //}
            //char[] letters = [a, z]          
            string text = Console.ReadLine();
            foreach (var letter in text)
            {
                Console.WriteLine(string.Join(" -> ", letter, letter - 'a'));
            }
        }
    }
}
