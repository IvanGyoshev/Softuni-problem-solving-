using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WordSwimRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
            double selfResult = timePerMeter * distance +
                Math.Floor( distance / 15) * 12.5d;
            Console.WriteLine("{0:f2}, {1:f2}, {2:f2}", selfResult,
                timePerMeter * distance, Math.Floor(distance / 15) * 12.5d);
            if (selfResult < record)
                Console.WriteLine("Yes, he succeeded! The new world record is " +
                    "{0:f2} seconds.", selfResult);
            else
                Console.WriteLine("No, he failed! He was " +
                    "{0:f2} seconds slower.", Math.Abs(record - selfResult));
        }
    }
}
