using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GroupName
{
    class GroupName
    {
        static void Main(string[] args)
        {
            char firstLetter = Char.Parse(Console.ReadLine());
            char secondLetter = Char.Parse(Console.ReadLine());
            char thirdLetter = Char.Parse(Console.ReadLine());
            char fourthLetter = Char.Parse(Console.ReadLine());
            sbyte lastFigure = SByte.Parse(Console.ReadLine());
            int counter = 0;
            for (char i='A'; i<=firstLetter; i++)
                for (char j = 'a'; j <= secondLetter; j++)
                    for (char k = 'a'; k <= thirdLetter; k++)
                        for (char l = 'a'; l <= fourthLetter; l++)
                            for (sbyte m = 0; m <= lastFigure; m++)
                            {
                                  //Console.Write("{0}{1}{2}{3}{4} ",
                                   // i, j, k, l, m);
                                counter++;
                            }
            Console.WriteLine("{0}", counter-1);
        }
    }
}
