using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double grade = 0.00d;
            int poor = 0;
            int satisfy = 0;
            int good = 0;
            int veryGood = 0;
            int excellent = 0;
            double result = 0.00d;
            for (int i=1; i<n+1;i++)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade >= 0 && grade < 22.5) poor +=1;
                if (grade >= 22.5 && grade < 40.5) satisfy +=1;
                if (grade >= 40.5 && grade < 58.5) good +=1;
                if (grade >= 58.5 && grade < 76.5) veryGood += 1;
                if (grade >= 76.5 && grade <= 100) excellent += 1;
            }
            Console.WriteLine("{0:f2}% poor marks", poor * 100.00d / n);
            Console.WriteLine("{0:f2}% satisfactory marks", satisfy * 100.00d / n);
            Console.WriteLine("{0:f2}% good marks", good * 100.00d / n);
            Console.WriteLine("{0:f2}% very good marks", veryGood * 100.00d / n);
            Console.WriteLine("{0:f2}% excellent marks", excellent * 100.00d / n);
        }
    }
}
