using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            string check = "no";
            for (int i = 1; i <= 30; i++)
                for (int j = i + 1; j <= 30; j++)
                    for (int k = j + 1; k <= 30; k++)
                    {
                        if (i < j && j < k && i < k && i + j + k == n)
                        {
                            Console.WriteLine("{0} + {1} + {2} = {3}",
                                i, j, k, n);
                            check = "yes";
                        }
                        if (i > j && j > k && i > k && i * j * k == n)
                        {
                            Console.WriteLine("{0} * {1} * {2} = {3}",
                                i, j, k, n);
                            check = "yes";
                        }
                    }
            for (int i = 30; i >= 1; i--)
                for (int j = i - 1; j >= 1; j--)
                    for (int k = j - 1; k >= 1; k--)
                    {
                        if (i > j && j > k && i > k && i * j * k == n)
                        {
                            Console.WriteLine("{0} * {1} * {2} = {3}",
                                i, j, k, n);
                            check = "yes";
                        }
                    }            
            if (check == "no") Console.WriteLine("No!"); 
        }
    }
}
