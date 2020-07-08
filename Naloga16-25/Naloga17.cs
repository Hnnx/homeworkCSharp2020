using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal17
    {

        public static void func()
        {

            Random r = new Random();


            int arrX = r.Next(1, 6);
            int arrY = r.Next(1, 6);

            string[,] myArr = new string[arrX, arrY];


            for (int i = 0; i < myArr.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < myArr.GetLength(1); j++)
                {
                    Console.WriteLine("Vnesi besedo:");
                    myArr[i, j] = Console.ReadLine();

                }
            }

            displayTable(myArr);

        }


        static void displayTable(string[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < tab.GetLength(1); j++)
                {

                    Console.Write(tab[i, j]+" ");

                }

            }
        }
    }
}
