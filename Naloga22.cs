using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace homeworkCSharp2020
{

    class nal22
    {

        public static void func()
        {

            try
            {
                Console.WriteLine("Vnesi niz:");
                string userInput = Console.ReadLine();
                string path = @"F:\out\mojiNizi.txt";


                File.AppendAllText(path, userInput + Environment.NewLine);
                Console.WriteLine("Zelis vpisati se en niz? Y/N");
                userInput = Console.ReadLine();

                if (userInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {

                    func();
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }


    }



}
