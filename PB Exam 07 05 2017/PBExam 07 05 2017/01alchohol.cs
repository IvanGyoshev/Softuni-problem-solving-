using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchohol { 
    class Program
    {
        static void Main(string[] args)
        {
        double wiskeyPrice = double.Parse(Console.ReadLine());
        double beer = double.Parse(Console.ReadLine());
        double wine = double.Parse(Console.ReadLine());
        double raki = double.Parse(Console.ReadLine());
        double wiskey = double.Parse(Console.ReadLine());
        double money = 0.00d;
        money = beer * wiskeyPrice * 0.5 * 0.2 +
            wine * wiskeyPrice * 0.5 * 0.6 +
            raki * wiskeyPrice * 0.5 +
            wiskey * wiskeyPrice;
        Console.WriteLine("{0:f2}",money);
        }
    }
}
