using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal19
    {

        public static void func()
        {

            int[] tab1 = new int[5];
            int[] tab2 = new int[5];

            tab1 = fillTable(tab1.Length, 10);
            tab2 = fillTable(tab2.Length, 10);


            displayTable(tab1);

        }

        private static int[] fillTable(int tabSize, int range)
        {

            Random r = new Random();
            int[] tab = new int[tabSize];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = r.Next(0, range + 1);

            }

            return tab;

        }


        private static void displayTable(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {

                if (i == tab.Length-1)
                {
                    Console.Write(tab[i]);
                }
                else
                {
                    Console.Write(tab[i]+", ");
                }


            }
        }
    }
}
