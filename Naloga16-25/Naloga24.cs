using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace homeworkCSharp2020
{
    class nal24
    {

        public static void readBigFile()
        {

            //Read File, Lines (array) to String, Split to Array, Convert to INT array
            string path = @"C:\out\st.txt";
            string deljivaPath = @"C:\out\deljiva.txt";
            string primePath = @"C:\out\prime.txt";
            string[] readNumFile = File.ReadAllLines(path);
            string arrToStr = String.Concat(readNumFile);
            string[] stringNumz = arrToStr.Split(";");
            int total = 0;

            int[] intNumz = new int[stringNumz.Length];

            for (int i = 0; i < intNumz.Length; i++)
            {
                //Convert to INT
                intNumz[i] = Convert.ToInt32(stringNumz[i]);


                //Pokni v Deljiva.txt
                if (intNumz[i] % 3 == 0 && intNumz[i] % 5 == 0 && intNumz[i] % 11 == 0)
                {
                    File.AppendAllText(deljivaPath, intNumz[i].ToString());

                }

                //Izpisi total v terminal
                total += intNumz[i];

                /*
                //Pokni v prime.txt
                if (!File.Exists(primePath))
                {
                if (isPrime(intNumz[i]))
                {
                File.AppendAllText(primePath, intNumz[i].ToString() + Environment.NewLine);
                }
                }

                */
            }

            int avg = total / intNumz.Length;
            Console.WriteLine("Average vseh stevilk je: {0}", avg);

        }


        private static Boolean isPrime(int n)
        {
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    counter++;
                }
            }

            return counter == 2;

        }

    }
}
