using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", new string('#', 4 * n + 1));
            //top
            for (int i = 0; i < n; i++)
            {
                if (i == n / 2 )
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                    new string('.', i + 1),
                    new string('#', 2 * n - 1 - 2 * i),
                    new string(' ', i - 1));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('.', i + 1),
                    new string('#', 2 * n - 1 - 2 * i),
                    new string(' ', 2 * i + 1));
                }
            }                
            //bottom
            for (int i=0; i<n; i++)
            Console.WriteLine("{0}{1}{0}", new string('.',n+1+i),
                new string('#', 2*n - 1-2*i));
        }
    }
}
