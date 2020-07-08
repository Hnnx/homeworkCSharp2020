using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal9_01
    {
        public static void func(int treeSize)
        {

            //KROSNJA
            for (int i = 0; i <= treeSize; i++)
            {
                Console.WriteLine("");

                //PRESLEDKI
                for (int p = treeSize; p >= i; p--)
                {
                    Console.Write(" ");
                }

                //ZVEZDICE
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }


                //ZVEZDICE DESNA STRAN

                for (int ds = 0; ds < i; ds++)
                {
                    Console.Write("*");
                }


            }
            Console.WriteLine("");

            //DEBLO

            string empty = " ";
            string offset = "";

            for (int offSize = 0; offSize < treeSize ; offSize++)
            {

                offset += empty;

            }

            Console.Write(offset); Console.WriteLine("***");
            Console.Write(offset); Console.WriteLine("***");


        }
    }
}
