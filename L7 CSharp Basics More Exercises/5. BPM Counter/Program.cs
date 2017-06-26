using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bpm = double.Parse(Console.ReadLine());
            var numberBeats = double.Parse(Console.ReadLine());
            var bars = numberBeats / 4;

            var minutes = numberBeats / bpm;
            var second = (minutes*60)%60;
            { 
                Console.WriteLine("{0} bars - {1}m {2}s", Math.Round(bars,1) ,Math.Floor(minutes),Math.Floor(second));
            }
           
        }
    }
}
