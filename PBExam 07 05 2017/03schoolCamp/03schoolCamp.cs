using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03schoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            uint students = uint.Parse(Console.ReadLine());
            uint days = uint.Parse(Console.ReadLine());
            string sport = null;
            if (season=="Winter")
            {
                switch (groupType)
                {
                    case "boys": sport = "Judo"; break;
                    case "girls": sport = "Gymnastics"; break;
                    case "mixed": sport = "Ski"; break;
                }
            }
            else if (season == "Spring")
            {
                switch (groupType)
                {
                    case "boys": sport = "Tennis"; break;
                    case "girls": sport = "Athletics"; break;
                    case "mixed": sport = "Cycling"; break;
                }
            }
            else if (season == "Summer")
            {
                switch (groupType)
                {
                    case "boys": sport = "Football"; break;
                    case "girls": sport = "Volleyball"; break;
                    case "mixed": sport = "Swimming"; break;
                }
            }
            double price = 0.00d;
            if (groupType == "boys" || groupType == "girls")
            {
                switch (season)
                {
                    case "Winter": price = 9.6d; break;
                    case "Spring": price = 7.2d; break;
                    case "Summer": price = 15.0d; break;
                }
            }
            else if (groupType == "mixed")
            {
                switch (season)
                {
                    case "Winter": price = 10.0d; break;
                    case "Spring": price = 9.5d; break;
                    case "Summer": price = 20.0d; break;
                }
            }
            if (students >= 10 && students < 20) price *= 0.95;
            else if (students >= 20 && students < 50) price *= 0.85;
            else if (students >= 50) price *= 0.5;
            double totalPrice = price * days*1.0d*students;
            Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
        }
    }
}
