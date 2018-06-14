using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            uint oneCoins = uint.Parse(Console.ReadLine());
            uint twoCoins = uint.Parse(Console.ReadLine());
            uint fiveCoins = uint.Parse(Console.ReadLine());
            uint sum = uint.Parse(Console.ReadLine());
            for (uint i=0; i<=oneCoins; i++)
                for (uint j=0; j<=twoCoins ; j++)
                    for (uint k = 0; k <= fiveCoins; k++)
                        if (sum == 1 * i + 2 * j + 5 * k)
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.",
                                i, j, k, sum);
        }
    }
}
