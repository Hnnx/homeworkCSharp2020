using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace homeworkCSharp2020
{

    //Napiši program, ki bo uporabnika vprašal naj vnese poljuben niz. Vneseni niz naj nato zapiše v datoteko mojiNizi.txt. Program naj ohrani prej zabeležene nize.


    class nal22
    {


        public static void writeToFile()
        {

            string path = @"C:\Users\anhjje\source\repos\HNNX\homeworkCSharp2020";
            string userInput = "";




            try
            {
                //userInput = Console.ReadLine();

                if (!File.Exists(path))
                {

                    using (StreamWriter sw = File.CreateText(path))
                    {

                        sw.WriteLine("Test");
                    }

                }

                using (StreamReader sr = File.OpenText(path))
                {

                    string line;
                    while( (line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



        public static void writeFile()
        {
            Console.WriteLine("Vnesi niz:");
            string userInput = Console.ReadLine();

            File.AppendAllText("mojiNizi.txt", userInput);




        }

    }
}
