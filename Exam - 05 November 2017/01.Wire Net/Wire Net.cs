using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfPlace = int.Parse(Console.ReadLine());
            int widthOfPlace = int.Parse(Console.ReadLine());
            double heightOfNet = double.Parse(Console.ReadLine());
            double priceOfNetPerMeter = double.Parse(Console.ReadLine());
            double weightOfNetPerMeter = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}\n{1:f2}\n{2:f3}", 2 * (lengthOfPlace + widthOfPlace),
                2 * (lengthOfPlace + widthOfPlace)*priceOfNetPerMeter,
               2 * (lengthOfPlace + widthOfPlace) * heightOfNet * weightOfNetPerMeter );
            
            
        }
    }
}
