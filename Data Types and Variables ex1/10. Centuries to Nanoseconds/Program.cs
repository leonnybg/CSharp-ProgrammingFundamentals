using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)Math.Floor(years * 365.2422);
            long hours = 24 * days;
            long minutes = 60 * hours;
            long seconds = 60 * minutes;
            decimal milliseconds = 1000 * seconds;
            decimal microseconds = 1000 * milliseconds;
            decimal nanoseconds = 1000 * microseconds;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
