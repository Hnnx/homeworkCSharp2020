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

            string filePath = @"C:\out\st.txt";

            try
            {

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string vrstica;
                    int vsotaVsehStevil = 0;
                    int steviloStevil = 0;

                    while( (vrstica  = sr.ReadLine()) != null)
                    {
                        string[] strNumz = vrstica.Split(";");
                        int[] intNumz = new int[strNumz.Length];


                        for (int i = 0; i < intNumz.Length; i++)
                        {
                            intNumz[i] = Convert.ToInt32(strNumz);
                            vsotaVsehStevil += intNumz[i];
                        }

                        steviloStevil += intNumz.Length;



                        //DELJIVA.TXT


                    // PRIME.TXT


                    //SESTEJ VRSTIC


                    }
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Napaka pri branju datoteke {0}, opis napake: "+e.Message, filePath);
                Console.WriteLine("Strack trace: " +e.StackTrace);
            }

        }

        private static Boolean isPrime(int n)
        {
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) counter++;
            }

            return counter == 2;
        }

    }
}
