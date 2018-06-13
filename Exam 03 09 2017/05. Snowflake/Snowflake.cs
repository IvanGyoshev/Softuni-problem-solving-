using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top
            for (int i = 0; i < n - 1; i++)
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string('.', i), new string('.', n-i));
            //middle part 1st line uppon
            Console.WriteLine("{0}{1}{0}",
                new string('.', n-1), new string ('*', 5));
            //middle part - center
            Console.WriteLine(new string('*', 2 * n + 3));
            //middle part 1st line downstairs
            Console.WriteLine("{0}{1}{0}",
                new string('.', n - 1), new string('*', 5));
            //bottom
            for (int i = n - 1; i >0 ; i--)
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string('.', i-1), new string('.', n - i+1));
        }
    }
}
