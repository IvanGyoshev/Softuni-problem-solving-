using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double john = double.Parse(Console.ReadLine());
            double peter = double.Parse(Console.ReadLine());
            double sam = double.Parse(Console.ReadLine());
            double uncleBob = double.Parse(Console.ReadLine());
            double brothers = ((1/(1/john + 1/peter + 1/sam))*1.15d);
            double timeLeft = uncleBob - brothers;
            Console.WriteLine("Cleaning time: {0:f2}", brothers);
            if (uncleBob > brothers)
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.",
                    Math.Floor(uncleBob - brothers));
            else Console.WriteLine("No, there isn’t a surprise - shortage of time -> {0} hours.",
                Math.Ceiling(brothers-uncleBob));
        }
    }
}
