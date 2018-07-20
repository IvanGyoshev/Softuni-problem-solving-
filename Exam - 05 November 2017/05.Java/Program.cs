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
            //top
            for (int i=1; i<=n; i++)
            Console.WriteLine("{0}~ ~ ~ {1}", new string(' ', n), new string(' ', 2 * n));
            //1-line
            Console.WriteLine("{0} ", new string('=', 3*n+5));
            //cup top first half
            if (n%2==0) Console.WriteLine("|{0}|{1}| ", new string('~', 2 * n + 4),
                new string(' ', n - 1));
            for (int j = 1; j<=(n-3)/2; j++)
                Console.WriteLine("|{0}|{1}| ", new string('~', 2 * n + 4),
                new string(' ', n - 1));                
            //middle of cup JAVA 
             Console.WriteLine("|{0}JAVA{0}|{1}| ", new string('~', n),
             new string(' ', n - 1));
            //cup top first half
            for (int j = 1; j <= (n - 3) / 2; j++)
                Console.WriteLine("|{0}|{1}| ", new string('~', 2 * n + 4),
     new string(' ', n - 1));
            //2-nd Line
            Console.WriteLine("{0}   ", new string('=', 3 * n+5));            
            //bottom lines
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("{1}\\{0}/{1}{2}",
                    new string('@', 2 * n + 4 - 2 * i), new string(' ', i),
                    new string(' ', n));
            }
            //last Line
            Console.WriteLine("{0}   ", new string('=', 2 * n + 6));
        }
    }
}
