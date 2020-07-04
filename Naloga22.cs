using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace homeworkCSharp2020
{

    //Napiši program, ki bo uporabnika vprašal naj vnese poljuben niz. Vneseni niz naj nato zapiše v datoteko mojiNizi.txt. Program naj ohrani prej zabeležene nize.


    class nal22
    {

        public static void writeFile()
        {
            Console.WriteLine("Vnesi niz:");
            string userInput = Console.ReadLine();

            File.AppendAllText("mojiNizi.txt", userInput);


        }

    }
}
