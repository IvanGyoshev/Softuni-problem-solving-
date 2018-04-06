using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Donate
{
    class Program
    {
        static void Main(string[] args)
        {
            uint days = uint.Parse(Console.ReadLine());
            uint cookers = uint.Parse(Console.ReadLine());
            uint cakes = uint.Parse(Console.ReadLine());
            uint gofrets = uint.Parse(Console.ReadLine());
            uint pancakes = uint.Parse(Console.ReadLine());
            double donation = days * cookers*
                (cakes*45d+gofrets*5.8d+pancakes*3.2d) * 7 / 8;
            Console.WriteLine("{0:f2}", donation);
        }
    }
}
