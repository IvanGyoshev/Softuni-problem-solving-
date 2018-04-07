using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fruit_coktails
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string volume = Console.ReadLine();
            uint countOfCoks = uint.Parse(Console.ReadLine());
            double price = 0.00d;

            if (volume == "small")
            {
                switch (fruit)
                {
                    case "Watermelon": price = 56.0d; break;
                    case "Mango": price = 36.66d; break;
                    case "Pineapple": price = 42.10d; break;
                    case "Raspberry": price = 20d; break;
                }
                price *= 2* countOfCoks;
            }
            else if (volume == "big")
            {
                switch (fruit)
                {
                    case "Watermelon": price = 28.70d; break;
                    case "Mango": price = 19.60d; break;
                    case "Pineapple": price = 24.80d; break;
                    case "Raspberry": price = 15.20d; break;
                }
                price *= 5* countOfCoks;
            }
            if (price >= 400 && price <= 1000) price *= 0.85d;
            else if (price >1000) price *= 0.5d;
            Console.WriteLine("{0:f2} lv.", price);
        }
    }
}
