using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal16
    {

        public static void func()
        {
            //DEFINE ARRAY SIZE
            Console.WriteLine("Insert array X size:");
            int arrayX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert array Y size:");
            int arrayY = Convert.ToInt32(Console.ReadLine());

            //DECLARE MULTI ARR
            int[,] multiArr = new int[arrayX, arrayY];

            //DECALRE VAR TO STORE TOTAL
            int total = 0;

            //DECLARE VAR TO STORE TOTAL X/Y AXIS
            int totalX = 0;
            int totalY = 0;




            for (int i = 0; i < multiArr.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < multiArr.GetLength(1); j++)
                {
                    //FILL WITH RANDOM 1-170
                    Random rdm = new Random();
                    multiArr[i, j] = rdm.Next(1, 5);


                    //DISPLAY TABLE
                    Console.Write(multiArr[i, j] + " ");


                    //COUNT ALL
                    total += multiArr[i, j];


                }
            }
                    Console.WriteLine("\nTotal: {0}",total);



            for (int i = 0; i < multiArr.GetLength(0); i++)
            {

                for (int j = 0; j < multiArr.GetLength(1); j++)
                {

                    totalX += multiArr[0,j];
                    totalY += multiArr[i,0];

                }
            }

            Console.WriteLine("Total x: {0}", totalX);
            Console.WriteLine("Total y: {0}", totalY);







        }
    }
}
