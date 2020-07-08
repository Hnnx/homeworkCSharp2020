using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal11
    {

        public static void func(int userInput)
        {

            Console.Write("Vneseno celo stevilo {0} - Mesec ", userInput);
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Januar"); 
                    break;
                case 2:
                    Console.WriteLine("Februar");
                    break;
                case 3:
                    Console.WriteLine("Marec");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("Maj");
                    break;
                case 6:
                    Console.WriteLine("Junij");
                    break;
                case 7:
                    Console.WriteLine("Julij");
                    break;
                case 8:
                    Console.WriteLine("Avgust");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("Oktober");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Great Scott!");
                    break;
            }

        }
    }
}
