using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var employee = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Employee ID: {0:D8}",employee);
            Console.WriteLine($"Salary: {salary:F2}");
        }
    }
}
