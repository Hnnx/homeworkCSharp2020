using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal12
    {

        public static void func(int userInput)
        {

            if( userInput > 99999 && userInput < 999999)
            {

                string full = userInput.ToString();

                string part1 = full.Substring(0, 3);
                string part2 = full.Substring(3);

                int part1Converted = Convert.ToInt32(part1);
                int part2Converted = Convert.ToInt32(part2);

                int result = part1Converted + part2Converted;

                Console.WriteLine("Sestevek prvih in zadnjih treh stevil ({0})  = {1}", userInput, result);
            }
            else
            {
                Console.WriteLine("Stevilo ne ustreza pogojem");
            }

        }
    }
}
