using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n+1]; //all prime numbers in range [1…n]. 
                                           //Assign primes[0…n] = true
            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;

            for (int i = 0; i <= n; i++)
            {
                if(!primes[i])
                {
                    continue;
                }
                Console.Write(i + " ");
                for (int p = 2*i; p <= n; p+=i)
                {
                    primes[p] = false;
                }
            }
            Console.WriteLine();
        }
    }
}
