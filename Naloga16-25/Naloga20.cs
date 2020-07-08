using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal20
    {


        //AVG ARRAY
        public static double averageArray(int[] arr)
        {
            int arrSize = arr.Length;

            double total = 0;

            for (int i = 0; i < arrSize; i++)
            {
                total += arr[i];

            }

            return total / arrSize;


        }


        //DISPLAY ARRAY
        public static void displayTable(int[] arr)
        {


            for (int i = 0; i < arr.Length; i++)
            {


                if(i == arr.Length - 1)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write(arr[i]+", ");
                }


            }

        }




    }
}
