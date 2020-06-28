using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal9
    {

        public static void func()
        {
            int triSize = getRdm();


            for (int i = triSize; i >= 0; i--)
            {
                Console.WriteLine("");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
            }
        }


        static int getRdm()
        {
            Random rdm = new Random();
            int rdmNUm = rdm.Next(3, 16);
            return rdmNUm;

        }
    }
}
