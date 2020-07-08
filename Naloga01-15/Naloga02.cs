using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naloga02
{

    class nal2
    {
        public static void func(int num1, int num2, int num3, int num4, int num5)
        {
         
            int[] numsArray = { num1, num2, num3, num4, num5 };

            int min = numsArray.Min();
            int max = numsArray.Max();
            int tot = 0;            

            foreach(int num in numsArray)
                tot += num;                

            int avg = tot / 5;

            Console.WriteLine("Najmanjse stevilo: "+ min);
            Console.WriteLine("Najvecje stevilo: " + max);
            Console.WriteLine("Povprecna vrednost stevil: " + avg);




        }

    }
}

