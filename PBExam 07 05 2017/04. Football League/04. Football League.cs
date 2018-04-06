using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Football_League
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            uint seats = uint.Parse(Console.ReadLine());
            uint fans = uint.Parse(Console.ReadLine());
            char sector = ' ';
            uint sectorA = 0;
            uint sectorB = 0;
            uint sectorV = 0;
            uint sectorG = 0;
            for (int i=0; i<fans; i++)
            {
                sector = char.Parse(Console.ReadLine());
                switch (sector)
                {
                    case 'A': sectorA++; break;
                    case 'B': sectorB++; break;
                    case 'V': sectorV++; break;
                    case 'G': sectorG++; break;
                }
            }
            double fansVsSeats = fans * 100.0d / seats;
            Console.WriteLine("{0:f2}%", sectorA * 100.0d / fans);
            Console.WriteLine("{0:f2}%", sectorB * 100.0d / fans);
            Console.WriteLine("{0:f2}%", sectorV * 100.0d / fans);
            Console.WriteLine("{0:f2}%", sectorG * 100.0d / fans);
            Console.WriteLine("{0:f2}%", fansVsSeats);

        }
    }
}
