using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal15
    {
        static int arrSize1 = getRdm();
        static int arrSize2 = getRdm();
        static int arrSize3 = getRdm();
        static int arrSize4 = getRdm();

        static int[,,,] myArray = new int[arrSize1,arrSize2,arrSize3,arrSize4];


        public static void fourDimDisplay()
        {

            for (int i = 0; i < myArray.GetLength(0); i++)
            {

                Console.WriteLine("");

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("");

                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.WriteLine("");

                        for (int l = 0; l < myArray.GetLength(3); l++)
                        {

                            Random rdm = new Random();

                            myArray[i, j, k, l] = rdm.Next(1, 11);


                            
                            Console.Write(myArray[i,j,k,l]+" ");

                        }

                    }

                }

            }


        }



        static int getRdm()
        {

            Random rdm = new Random();
            int arrSize = rdm.Next(2, 10);
            return arrSize;

        }

    }
}
