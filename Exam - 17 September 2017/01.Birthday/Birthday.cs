using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Birthday
{
    class Birthday
    {
        static void Main(string[] args)
        {
            uint length = uint.Parse(Console.ReadLine());
            uint width = uint.Parse(Console.ReadLine());
            uint height = uint.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = (1-percent/100.00d)*length*width*height/1000.0d;
            Console.WriteLine("{0:f3}", volume);

        }
    }
}
