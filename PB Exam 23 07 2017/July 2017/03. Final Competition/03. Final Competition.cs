using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte dancers = sbyte.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            if (place=="Bulgaria")
            {
                switch (season)
                {
                    case "summer": points = points * dancers * 0.95d; break;
                    case "winter": points = points * dancers * 0.92d; break;
                }
            }
            else if (place=="Abroad")
            {
                switch (season)
                {
                    case "summer": points = points * dancers *1.5* 0.9d; break;
                    case "winter": points = points * dancers * 1.5*0.85d; break;
                }
            }
            double charity = 0.75d*points;
            double moneyPerDancer = 0.25d*points/dancers;
            Console.WriteLine("Charity - {0:f2}", charity);
            Console.WriteLine("Money per dancer - {0:f2}", moneyPerDancer);
        }
    }
}
