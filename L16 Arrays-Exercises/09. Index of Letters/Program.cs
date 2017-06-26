using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //string alpha = "ABCDEFGHIJKLMNOPQRSTUVQXYZ";
            //for (int i = 0; i < 26; ++i)
            //{
            //    Console.WriteLine(alpha[i]);
            //}

            //foreach (char c in alpha)
            //{
            //    Console.WriteLine(c);
            //}
            //******************************************************
           // char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            //**************************************************************
            //char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            //foreach (var c in az)
            //{
            //    Console.WriteLine(c);
            //}
            //**********************************************************
            var word = Console.ReadLine().ToLower();
            var chars = new char['z' - 'a' + 1];
            for (int i = 'a'; i <= 'z'; i++)
            {
                chars[i - 'a'] = (char)i;
            }
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {Array.IndexOf(chars, word[i])}");
            }
        }
    }
}
