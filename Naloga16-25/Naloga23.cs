using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace homeworkCSharp2020
{
    class nal23
    {

        public static void readNums()
        {

            string pathOld = @"F:\out\stevila.txt";
            int lineCount = 0;
            double total = 0;

            string[] stevilaArray = File.ReadAllLines(pathOld);
            double[] doubleArr = new double[stevilaArray.Length];


            for (int i = 0; i < stevilaArray.Length; i++)
            {

                lineCount++;

                Console.WriteLine("{0}) {1}", lineCount, stevilaArray[i]);


                doubleArr[i] = Double.Parse(stevilaArray[i], CultureInfo.InvariantCulture);

                total += doubleArr[i];

            }


            Console.WriteLine("Total: " + total);





            //Best to copy file before overwriting old one
            string pathNew = @"F:\out\stevila2.txt";
            if (!File.Exists(pathNew))
            {

            File.Copy(pathOld, pathNew);

            }
            

            //USE PATHNEW TO APPEND TO NEW FILE OR PATHOLD TO APPEND TO ORIGINAL FILE
            File.AppendAllText(pathOld, Environment.NewLine+total.ToString());

 
        }
    }

}
