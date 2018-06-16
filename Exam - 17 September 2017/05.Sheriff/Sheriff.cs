using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sheriff
{
    class Sheriff
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}x{0}", new string('.', (3 * n - 1) / 2));
            Console.WriteLine("{0}/x\\{0}", new string('.', (3 * n -3) / 2));
            Console.WriteLine("{0}x|x{0}", new string('.', (3 * n - 3) / 2));
            for (int i=(n-1)/2; i>=1; i--)
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', i),
                    new string ('x',(3*n-1-2*i)/2));
            Console.WriteLine("{0}|{0}", new string('x', (3 * n - 1) / 2));
            for (int i = 1; i <= (n - 1) / 2; i++)
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', i),
                    new string('x', (3 * n - 1 - 2 * i) / 2));
            Console.WriteLine("{0}/x\\{0}", new string('.', (3 * n - 3) / 2));          
            Console.WriteLine("{0}\\x/{0}", new string('.', (3 * n - 3) / 2));
            for (int i = (n - 1) / 2; i >= 1; i--)
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', i),
                    new string('x', (3 * n - 1 - 2 * i) / 2));
            Console.WriteLine("{0}|{0}", new string('x', (3 * n - 1) / 2));
            for (int i = 1; i <= (n - 1) / 2; i++)
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', i),
                    new string('x', (3 * n - 1 - 2 * i) / 2));
            Console.WriteLine("{0}x|x{0}", new string('.', (3 * n - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (3 * n - 3) / 2));
            Console.WriteLine("{0}x{0}", new string('.', (3 * n - 1) / 2));
        }
    }
}
