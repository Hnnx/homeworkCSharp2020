using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal8
    {

        public static void func(int x, int y)
        {

           Console.WriteLine("Napisi program, ki bo sprejel dva argumenta v obliki celih stevil ter izrisal pravokotnik z zvezdicami, kjer prvi argument predstavlja stevilo vrstic, drugi pa stevilo stolpcev oz. zvezdic v vrstici.");


            for (int i = 0; i < x; i++)
            {

                Console.WriteLine("");
                for (int j = 0; j < y; j++)
                {
                    Console.Write("*");

                }

            }


        }
    }
}
