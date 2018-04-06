using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // top
            Console.WriteLine("@{0}@{0}@", new string(' ', n - 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', n - 3));
            //middle base
            for (int i = 1; i <= n / 2 - 2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                  new string('.', i), new string(' ', n - 3 - 2 * i),
                  new string('.', 2 * i - 1));
            }
            Console.WriteLine("*{0}*{1}*{0}*",
               new string('.', n / 2 - 1),
               new string('.', n - 3));
            if (n % 2 == 0)
            {
                Console.WriteLine("*{0}{1}.{1}{0}*",
                    new string('.', n / 2), new string('*', (n / 2 - 2)));
            }
            else
            {
                Console.WriteLine("*{0}{1}.{1}{0}*",
                    new string('.', n / 2 + 1), new string('*', (n / 2 - 2)));
            }

            for (int i = 0; i < 2; i++)
                Console.WriteLine(new string('*', 2 * n - 1));
        }
    }
}
