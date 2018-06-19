using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Lutenitsa
{
    class Lutenitsa
    {
        static void Main(string[] args)
        {
            double tomatoesKiloes = double.Parse(Console.ReadLine());
            int cases = int.Parse(Console.ReadLine());
            int jars = int.Parse(Console.ReadLine());
            double lutenitsa = tomatoesKiloes / 5.0d;
            Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(lutenitsa));
            double neededJars = lutenitsa*1000/535d;
            double result = Math.Abs(neededJars - cases * jars);
            if (neededJars>jars*cases)
            {
                Console.WriteLine("{0} boxes left.", Math.Floor(result/jars) );
                Console.WriteLine("{0} jars left.", Math.Floor(result));
            }
            else if (neededJars<jars*cases)
            {
                Console.WriteLine("{0} more boxes needed.", Math.Floor(result / jars));
                Console.WriteLine("{0} more jars needed.", Math.Floor(result));
            }
        }
    }
}
