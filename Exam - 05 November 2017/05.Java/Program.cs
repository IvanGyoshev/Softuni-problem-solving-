using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i=1; i<=n; i++)
            Console.WriteLine("{0}~ ~ ~ {1}", new string(' ', n), new string(' ', 2 * n));

            Console.WriteLine("{0} ", new string('=', 3*n+5));

            //Console.WriteLine("{0} ", new string('=', 3 * n + 5));

            Console.WriteLine("{0}   ", new string('=', 3 * n));

        }
    }
}
