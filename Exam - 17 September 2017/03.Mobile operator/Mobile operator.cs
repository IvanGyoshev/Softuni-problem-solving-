using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string planTime = Console.ReadLine();
            string typePlan = Console.ReadLine();
            string internet = Console.ReadLine();
            sbyte months = sbyte.Parse(Console.ReadLine());
            double bill = 0.00d;
            if (planTime == "one")
            {
                switch (typePlan)
                {
                    case "Small": bill = 9.98d; break;
                    case "Middle": bill = 18.99d; break;
                    case "Large": bill = 25.98d; break;
                    case "ExtraLarge": bill = 35.99d; break;
                }
            }
            else if (planTime == "two")
            {
                switch (typePlan)
                {
                    case "Small": bill = 8.58d; break;
                    case "Middle": bill = 17.09d; break;
                    case "Large": bill = 23.59d; break;
                    case "ExtraLarge": bill = 31.79d; break;
                }                
            }
            if (internet == "yes")
            {
                if (bill <= 10) bill += 5.50d;
                else if (bill > 10 && bill <= 30) bill += 4.35d;
                else if (bill > 30) bill += 3.85d;
            }
            bill *= months;
            if (planTime == "two") bill *= 0.9625d;
            Console.WriteLine("{0:f2} lv.", bill);
        }
    }
}
