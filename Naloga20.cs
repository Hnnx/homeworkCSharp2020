using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal20
    {


        //AVG ARRAY
        public static int averageArray(int[] arr)
        {
            int arrSize = arr.Length;

            int total = 0;

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
                Console.WriteLine(arr[i]+" ");

            }
        }




    }
}
