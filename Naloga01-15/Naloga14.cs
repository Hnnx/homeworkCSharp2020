using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal14
    {
        //DECLARE MULTI ARRAY
        static int[,] multiArr = new int[14, 9];

        public static void func()
        {

            //FILL ARRAY WITH RDM NUMS (1-70)
            for (int i = 0; i < multiArr.GetLength(0); i++)
            {
                for (int j = 0; j < multiArr.GetLength(1); j++)
                {

                    Random r = new Random();
                    multiArr[i, j] = r.Next(1, 71);

                }
            }
        }





        //DISPLAY ARRAY IN CONSOLE
        public static void showTable()
        {
            Console.WriteLine("\n\nDisplay table:");
            for (int i = 0; i < multiArr.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < multiArr.GetLength(1); j++)
                {
                    Console.Write(multiArr[i, j] + " ");
                }
            }

        }



        //DIVISIBLE BY 7
        public static void showSeven()
        {
            Console.WriteLine("\n\nShow nums divisible by 7:");
            for (int i = 0; i < multiArr.GetLength(0); i++)
            {
                for (int j = 0; j < multiArr.GetLength(1); j++)
                {

                    if (multiArr[i, j] % 7 == 0)
                    {
                        Console.Write("{0} ", multiArr[i, j]);
                    }

                }

            }
        }



        //COUNT ALL NUMS
        public static void calcAll()
        {
            Console.WriteLine("\n\nReturn total of all nums:");

            int result = 0;


            for (int i = 0; i < multiArr.GetLength(0); i++)
            {
                for (int j = 0; j < multiArr.GetLength(1); j++)
                {

                    result += multiArr[i, j];

                }

            }


            Console.WriteLine(result);


        }






    }
}
