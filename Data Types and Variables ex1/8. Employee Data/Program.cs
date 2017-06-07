using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var gender = char.Parse(Console.ReadLine());
            var personalID = long.Parse(Console.ReadLine());
            var numberEmployee = uint.Parse(Console.ReadLine());
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}",secondName);
            Console.WriteLine("Age: {0}",age);
            Console.WriteLine("Gender: {0}",gender);
            Console.WriteLine("Personal ID: {0}",personalID);
            Console.WriteLine("Unique Employee number: {0}", numberEmployee); 

        }
    }
}
