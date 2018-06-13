using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            uint picturesCount = uint.Parse(Console.ReadLine());
            string size = Console.ReadLine();
            string typeOfOrder = Console.ReadLine();
            double bill = 0.00d;
            switch(size)
            {
                case "9X13":
                    bill = picturesCount * 0.16d;
                    if (picturesCount > 50) bill *= 0.95d;
                    break;
                case "10X15":
                    bill = picturesCount * 0.16d;
                    if (picturesCount > 80) bill *= 0.97d;
                    break;
                case "13X18":
                    bill = picturesCount * 0.38d;
                    if (picturesCount > 50 && picturesCount<=100) bill *= 0.97d;
                    else if (picturesCount > 100) bill *= 0.95d;
                    break;
                case "20X30":
                    bill = picturesCount * 2.90d;
                    if (picturesCount > 10 && picturesCount <= 50) bill *= 0.93d;
                    else if (picturesCount > 50) bill *= 0.91d;
                    break;
            }
            if (typeOfOrder == "online") bill *= 0.98d;             
            Console.WriteLine("{0:f2}BGN", bill);
        }
    }
}
