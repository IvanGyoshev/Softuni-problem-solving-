using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            uint nDays = uint.Parse(Console.ReadLine());
            double yeniRaki = 0.00d;
            double grades = 0.00d;
            double volume = 0.00d;
            double sumGrades = 0.00d;
            for (int i=0; i< nDays; i++)
            {
                yeniRaki = double.Parse(Console.ReadLine());
                grades = double.Parse(Console.ReadLine());
                volume += yeniRaki;
                sumGrades += yeniRaki * grades;
            }
            Console.WriteLine("Litter:{0:f2}", volume);
            Console.WriteLine("Degrees:{0:f2}", sumGrades/volume);
            if (sumGrades/volume<38)
            Console.WriteLine("Not good, you should baking!");
            else if (sumGrades / volume >= 38 && sumGrades / volume <42)
                Console.WriteLine("Super!");
            else if (sumGrades / volume >42)
                Console.WriteLine("Dilution with distilled water!");
        }
    }
}
