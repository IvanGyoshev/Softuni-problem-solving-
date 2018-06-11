using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            double incomePerPerson = double.Parse(Console.ReadLine());
            double gradeStatus = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());
            double socialBonus = 0.35*minimalSalary;
            double excellentBonus = gradeStatus *25.0d;
            if (incomePerPerson < minimalSalary && gradeStatus > 4.5 && gradeStatus<5.5)              
                Console.WriteLine("You get a Social scholarship {0} BGN",
                     Math.Floor(socialBonus));           
            else if (gradeStatus >= 5.5 && socialBonus <= excellentBonus)
                Console.WriteLine("You get a scholarship for excellent results {0} BGN"
                    , Math.Floor(excellentBonus));
            else if (gradeStatus >= 5.5 && socialBonus > excellentBonus)
                Console.WriteLine("You get a scholarship for excellent results {0} BGN"
                    , Math.Floor(excellentBonus));
            else 
                Console.WriteLine("You cannot get a scholarship!");
        }
    }
}
