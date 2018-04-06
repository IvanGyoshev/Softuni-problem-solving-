using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            uint mNum = uint.Parse(Console.ReadLine());
            uint nNum = uint.Parse(Console.ReadLine());
            uint lNum = uint.Parse(Console.ReadLine());
            uint specialNum = uint.Parse(Console.ReadLine());
            uint checkNum = uint.Parse(Console.ReadLine());
            string number = null;
            string message = null;
            uint nums = 0;
            string pw = "yes";
            for (uint i = mNum; i>=1; i--)
                for (uint j = nNum; j >= 1; j--)
                    for (uint k = lNum; k >= 1; k--)
                    {
                        if (pw == "yes")
                        {
                            number = Convert.ToString(i) +
                                Convert.ToString(j) + Convert.ToString(k);
                            nums = uint.Parse(number);
                            if (nums % 3 == 0) specialNum += 5;
                            else if (k == 5) specialNum -= 2;
                            else if (nums % 2 == 0) specialNum *= 2;
                            if (specialNum >= checkNum)
                            {
                                pw = "no";
                                message = "Yes! Control number was reached! Current special number is "
                                    + Convert.ToString(specialNum) + ".";
                            }
                            else if (specialNum < checkNum)
                            {
                                message = "No! "
                                    + Convert.ToString(specialNum) + " is the last reached special number.";
                            }
                        }
                        else break;                        
                    }
            Console.WriteLine(message);
        }
    }
}
