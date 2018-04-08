using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            uint steps = uint.Parse(Console.ReadLine());
            uint dancers = uint.Parse(Console.ReadLine());
            uint days = uint.Parse(Console.ReadLine());
            double stepsPerDay = (100d*steps / days) / steps * 1.0d;            
            double stepsPersentPerDancer = Math.Ceiling(stepsPerDay) / dancers * 1.0d;
            if (stepsPerDay <= 13)
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.",
                    stepsPersentPerDancer);
            else Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.",
                    stepsPersentPerDancer);
        }
    }
}
