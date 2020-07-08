using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal5
    {

        public static void func(string userInput)
        {

            Console.WriteLine("Input: " + userInput);
            Console.WriteLine("Every second char: ");

            for(int i = 0; i < userInput.Length; i+=2)
            {
                Console.Write(userInput[i] + " ");
            }

        }
    }
}
