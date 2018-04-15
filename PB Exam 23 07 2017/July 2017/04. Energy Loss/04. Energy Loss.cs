using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort nDays = ushort.Parse(Console.ReadLine());
            ushort dancers = ushort.Parse(Console.ReadLine());
            ushort hours = 0;
            double energyCapacity = 100d * dancers * nDays ;
            double wastedEnergy = 0.00d;
            for (int i=1; i<=nDays; i++)
            {
                hours = ushort.Parse(Console.ReadLine());
                if (i % 2 != 0 && hours % 2 != 0) wastedEnergy += dancers * 30;
                else if (i % 2 != 0 && hours % 2 == 0) wastedEnergy += dancers * 49;
                else if (i % 2 == 0 && hours % 2 == 0) wastedEnergy += dancers * 68;
                else if (i % 2 == 0 && hours % 2 != 0) wastedEnergy += dancers * 65;
            }
            double result = (energyCapacity - wastedEnergy) / nDays / dancers;
            if (result > 50)
                Console.WriteLine("They feel good! Energy left: {0:f2}",result);
            else if (result <= 50)
                Console.WriteLine("They are wasted! Energy left: {0:f2}", result);

        }
    }
}
