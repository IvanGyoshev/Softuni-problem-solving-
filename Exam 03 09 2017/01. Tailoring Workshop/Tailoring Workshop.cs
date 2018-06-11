using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            uint tables = uint.Parse(Console.ReadLine());
            double aSideOfTable = double.Parse(Console.ReadLine());
            double bSideOfTable = double.Parse(Console.ReadLine());
            double aSideOfCover = aSideOfTable + 2*0.3d;
            double bSideOfCover = bSideOfTable + 2*0.3d;
            double sideOfKare = aSideOfTable /2.0d;
            double bill = tables * (aSideOfCover*bSideOfCover*7.00d+
                sideOfKare*sideOfKare*9.00d)*1.0d;
            Console.WriteLine("{0:f2} USD", bill);
            Console.WriteLine("{0:f2} BGN", bill*1.85d);

        }
    }
}
