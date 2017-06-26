using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberImage = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var sizeBytes = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var hight = int.Parse(Console.ReadLine());
            //Name: DSC_0035.jpg
            Console.WriteLine($"Name: DSC_{numberImage:D4}.jpg");
            //Date Taken: 25/12/2003 12:03
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            //Size: 1.5MB
            if (sizeBytes<1000)
            {
                Console.WriteLine("Size: {0}B", sizeBytes);
            }
            else if (sizeBytes<1000000)
            {
                sizeBytes = sizeBytes / 1000;
                Console.WriteLine("Size: {0}KB", sizeBytes);
            }
            else 
            {
                sizeBytes = sizeBytes / 1000000;
                Console.WriteLine("Size: {0:}MB", sizeBytes);
            }
          
            //Resolution: 5334x3006 (landscape)
            if (width > hight)
            {
                Console.WriteLine($"Resolution: {width}x{hight} (landscape)");
            }
            else if (width<hight)
            {
                Console.WriteLine($"Resolution: {width}x{hight} (portrait)");
            }
            else { Console.WriteLine($"Resolution: {width}x{hight} (square)"); }
        }
    }
}
