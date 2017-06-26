using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var numberItems = int.Parse(Console.ReadLine());
            var sumTotal = 0.00;
            var totalPrice = 0.00;
            for (int i = 0; i < numberItems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());
                totalPrice = itemPrice * itemCount;
                sumTotal = sumTotal + totalPrice;
                if (itemCount>1)
                {
                    itemName = itemName + "s";
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }

            }
            Console.WriteLine("Subtotal: ${0:f2}",sumTotal);
            if (budjet >= sumTotal)
            {
                var diff = budjet - sumTotal;
                Console.WriteLine("Money left: ${0:f2}",diff );
                    }
            else
            {
                var diff1 = sumTotal - budjet;
                Console.WriteLine("Not enough. We need ${0:f2} more.",diff1);
            }
        }
    }
}
