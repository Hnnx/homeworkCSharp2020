using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal6
    {

        public static void func(string userInput)
        {

            Random rdmObj = new Random();
            int rdm = rdmObj.Next(0, userInput.Length);

            Console.WriteLine("Random letter from string {0}: ", userInput);
            Console.WriteLine(userInput[rdm]);

            Console.WriteLine("Second letter from string {0}: ", userInput);
            Console.WriteLine(userInput[1]);

            Console.WriteLine("Second to last letter from string {0}: ", userInput);
            Console.WriteLine(userInput[userInput.Length-2]);

        }
    }
}
