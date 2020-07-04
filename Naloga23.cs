using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace homeworkCSharp2020
{
    class nal23
    {


        public static void rFile()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                StreamReader sr = new StreamReader(Path.Combine(filePath, "stevila.txt"));
            try
            {
                double total = 0;




                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    double ln = Convert.ToDouble(line);
                    Console.WriteLine(line);

                    total += ln;
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                sr.Close();
            }

        }

        public static void wFile()
        {

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            try
            {

                StreamWriter outFile = new StreamWriter(Path.Combine(filePath, "stevila.txt"), true);

                outFile.WriteLine("addText");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
