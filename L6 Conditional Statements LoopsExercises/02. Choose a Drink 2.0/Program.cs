using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var totalPrice = 0.00;
            if (profession == "Athlete")
            {
                 totalPrice = quantity * 0.70;               
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {

                totalPrice = quantity * 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                totalPrice = quantity * 1.70;
            }
            else
            {
                totalPrice = quantity * 1.20;
            }
            Console.WriteLine("The {0} has to pay {1:f2}.", profession, totalPrice);
        }
    }
}
