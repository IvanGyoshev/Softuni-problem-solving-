using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02toysshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());
            int toysNumber = puzzle + doll + bear + minion + truck;
            double income = puzzle * 2.6d + doll * 3.00d + bear * 4.10d +
                minion * 8.20d + truck * 2.0d;
            if (toysNumber >= 50) income *= 0.75;
            income *= 0.9;
            if (income>=tripPrice)
                Console.WriteLine("Yes! {0:f2} lv left.",
                    income-tripPrice);
            else Console.WriteLine("Not enough money! {0:f2} lv needed.",
                    tripPrice-income);
        }
    }
}
