﻿using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal18
    {


        //IZBIRNI MENI
        private static void izbirniMeni()
        {

            Console.WriteLine("1 - Sestej");
            Console.WriteLine("2 - Odstej");
            Console.WriteLine("3 - Mnozi");
            Console.WriteLine("4 - Deli");
            Console.WriteLine("5 - Potenca");
            Console.WriteLine("6 - Kvadrat");
            Console.WriteLine("7 - Ostanek");
            Console.WriteLine("8 - Fibonacci (max 40)");
            Console.WriteLine("9 - Koren");
            Console.WriteLine("10 - Izhod");


            try
            {
                int izbira = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine("Napaka: {0}", e.Message);
            }

        }


        //SWITCH
        private static void stikalo(int izbira)
        {

            switch (izbira)
            {
                case 1:
                    sestej();
                    break;
                case 2:
                    odstej();
                    break;
                case 3:
                    mnozi();
                    break;
                case 4:
                    deli();
                    break;
                case 5:
                    potenca();
                    break;
                case 6:
                    kvadrat();
                    break;
                case 7:
                    ostanek();
                    break;
                case 8:
                    fib();
                    break;
                case 9:
                    koren();
                    break;
                case 10:
                    izhod();
                    break;
                default:
                    Console.WriteLine("Neveljaven ukaz");
                    break;
            }

        }

        private static void izhod()
        {
            //IMPLEMENT SYS.EXIT(1)
        }

        private static void koren()
        {
            //IMPLEMENT KOREN
        }

        private static void fib()
        {
            //IMPLEMENT FIB
        }

        private static void ostanek()
        {

            try
            {
                Console.WriteLine("Vnesi prvo stevilo");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vnesi drugo stevilo");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x % y;
                Console.WriteLine("{0} % {1} = {2}", x, y, z);
            }
            catch (Exception e)
            {
                Console.WriteLine("Napacen ukaz, opis napake:");
                Console.WriteLine(e.Message);
            }
        }

        private static void kvadrat()
        {

            try
            {

                Console.WriteLine("Vnesi stevilo");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x *=x);
            }
            catch (Exception e)
            {

                Console.WriteLine("Napacen ukaz, opis napake:");
                Console.WriteLine(e.Message);
            }
        }


        private static void potenca()
        {


            try
            {
                Console.WriteLine("Vnesi stevilo");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vnesi potenco");
                int y = Convert.ToInt32(Console.ReadLine());

                int z = (int)Math.Pow(x, y);

                Console.WriteLine("{0} na {1} potenco = {2}", x, y, z);

            }
            catch (Exception e)
            {
                Console.WriteLine("Napacen ukaz, opis napake:");
                Console.WriteLine(e.Message);

            }


        }

        private static void deli()
        {

            try
            {
                Console.WriteLine("Vnesi prvo stevilo");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vnesi drugo stevilo");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("{0} / {1} = {2}", x, y, z);
            }
            catch (Exception e)
            {
                Console.WriteLine("Napacen ukaz, opis napake:");
                Console.WriteLine(e.Message);
            }
        }

       private static void mnozi()
        {

            try
            {
                Console.WriteLine("Vnesi prvo stevilo");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vnesi drugo stevilo");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x * y;
                Console.WriteLine("{0} - {1} = {2}", x, y, z);
            }
            catch (Exception e)
            {
                Console.WriteLine("Napacen ukaz, opis napake:");
                Console.WriteLine(e.Message);
            }
        }

        private static void odstej()
        {

            try
            {
                Console.WriteLine("Vnesi prvo stevilo");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vnesi drugo stevilo");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x - y;
                Console.WriteLine("{0} - {1} = {2}", x, y, z);
            }
            catch (Exception e)
            {
                Console.WriteLine("Napacen ukaz, opis napake:");
                Console.WriteLine(e.Message);
            }
        }

        private static void sestej()
        {

            try
            {
                Console.WriteLine("Vnesi prvo stevilo:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vnesi drugo stevilo:");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x + y;

                Console.WriteLine("{0} + {1} = {2}", x, y, z);
            }
            catch (Exception e)
            {
                Console.WriteLine("Napacen ukaz, opis napake:");
                Console.WriteLine(e.Message);
            }


        }
    }
}
