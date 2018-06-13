using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int cake = width*height;
            string pieces = string.Empty;
            while (pieces != "STOP")
            {
                pieces = Console.ReadLine();
                if (pieces != "STOP" && cake>=0) cake -= Convert.ToInt32(pieces);                             
                else break;
            }
            if (cake <= 0)
                Console.WriteLine("No more cake left! You need {0} pieces more.",
                    Math.Abs(cake));
            else if (cake>0)
                Console.WriteLine("{0} pieces are left.",
                    cake);
        }
    }
}
