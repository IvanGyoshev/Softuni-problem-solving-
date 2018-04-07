using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MoneyPrise
{
    class Program
    {
        static void Main(string[] args)
        {
            uint parts = uint.Parse(Console.ReadLine());
            double moneyOfEveryPart = double.Parse(Console.ReadLine());
            uint totalParts = 0u; 
            for (int i=1; i<=parts; i++)
            {
                uint input = uint.Parse(Console.ReadLine());
                if (i % 2 == 0) totalParts += 2 * input;
                else totalParts += input;
            }
            Console.WriteLine("The project prize was {0:f2} lv.",
                totalParts* moneyOfEveryPart);
        }
    }
}
