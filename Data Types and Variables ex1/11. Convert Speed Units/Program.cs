using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceInMeters = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            decimal distnaceInMiles = distanceInMeters / 1609m;
            float metersPerSeconds = (float)distanceInMeters / (float)totalSeconds;
            float kilometersPerHours = ((float)distanceInMeters / 1000) / ((float)totalSeconds / 3600);
            float milesPerHours = (float)distnaceInMiles / ((float)totalSeconds / 3600);
            Console.WriteLine(metersPerSeconds);
            Console.WriteLine(kilometersPerHours);
            Console.WriteLine(milesPerHours);
        }
    }
}
