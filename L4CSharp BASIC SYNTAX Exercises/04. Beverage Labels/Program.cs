using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());
            var energykcal = (energy * volume) / 100;
            var sugarIngram = (volume * sugar) / 100;
            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energykcal, sugarIngram);
        }
    }
}
