using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal13
    {
        public static void func()
        {


        Console.WriteLine("Stevila deljiva s 5,11,13 hkrati (do 1400) so:");
            for (int i = 0; i < 14000; i++)
            {
                if (i % 5 == 0 && i % 11 == 0 && i % 13 == 0)
                {
                    Console.Write(i+" ");
                }

            }

        }
    }
}
