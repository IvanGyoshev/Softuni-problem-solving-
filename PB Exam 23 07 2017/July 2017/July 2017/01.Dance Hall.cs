using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double aSide = double.Parse(Console.ReadLine());
            double dancers = (height * width * 9000.0 - aSide * aSide * 10000.0d) / 7040;
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
