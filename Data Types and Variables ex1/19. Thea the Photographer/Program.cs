using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pictureCount = int.Parse(Console.ReadLine());
            var singlePictureFilterTimeSeconds = int.Parse(Console.ReadLine());
            var filterPersentage = int.Parse(Console.ReadLine());
            var singlePictureUploadTimeSeconds = int.Parse(Console.ReadLine());
            var filterTimeSeconds = (long)pictureCount * singlePictureFilterTimeSeconds;
            var picturesToUploadCount = (long)Math.Ceiling((pictureCount) * (filterPersentage / 100d));
            var uploadTimeSeconds = picturesToUploadCount * singlePictureUploadTimeSeconds;
            var totalTimeNeededSeconds = filterTimeSeconds + uploadTimeSeconds;
            var totalTimeNeededSecondsSpan = TimeSpan.FromSeconds(totalTimeNeededSeconds);
            Console.WriteLine(totalTimeNeededSecondsSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
