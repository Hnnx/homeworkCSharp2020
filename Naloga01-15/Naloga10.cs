using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal10
    {

        public static void func(string userInput)
        {

            int tCount, aCount;
            tCount = aCount = 0;

            double tPerc, aPerc;
            tPerc = aPerc = 0.0;

            for (int i = 0; i < userInput.Length; i++)
            {

                if ( Char.ToUpper(userInput[i]) == 'T'){
                    tCount++;
                }
                
                if ( Char.ToUpper(userInput[i]) == 'A'){
                    aCount++;
                }

            }

            tPerc = (double)tCount / (double)userInput.Length * 100;
            aPerc = (double)aCount / (double)userInput.Length * 100;

            Console.WriteLine("Letter t is repeated {0} times. Percentage: {1}%", tCount, tPerc);
            Console.WriteLine("Letter a is repeated {0} times. Percentage: {1}%", aCount, aPerc);
        }
    }
}
