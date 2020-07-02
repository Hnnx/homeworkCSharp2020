using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal18
    {


        //IZBIRNI MENI
        public static void izbirniMeni()
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
                stikalo(izbira);

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
            Console.WriteLine("Zelis zakljuciti program? Y/N");

            string choice = Console.ReadLine();

            if(choice.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                Environment.Exit(0);
            }
            else
            {
                izbirniMeni();
            }

            
        }

        private static void koren()
        {

            try
            {
                Console.WriteLine("Vnesi stevilo");
                int x = Convert.ToInt32(Console.ReadLine());
                double y = Math.Sqrt(x);
                Console.WriteLine("Koren stevila {0} je {1}", x, y);
                repeat();


            }
            catch (Exception e)
            {
                Console.WriteLine("Napacen ukaz, opis napake:");
                Console.WriteLine(e.Message);
            }



        }

        private static void fib()
        {
            //IMPLEMENT FIB
            repeat();
        }

        private static void ostanek()
        {

            try
            {
                Console.WriteLine("Vnesi prvo stevilo");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vnesi drugo stevilo");
                int y = Convert.ToInt32(Console.ReadLine());
                double z =  x % y;
                Console.WriteLine("{0} % {1} = {2}", x, y, z);
                repeat();
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
                Console.WriteLine("Kvadrat stevila {0} je {1}", x, x *= x);
                repeat();
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

                double z = Math.Pow(x, y);

                Console.WriteLine("{0} na {1} potenco = {2}", x, y, z);
                repeat();

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

                repeat();
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
                repeat();
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
                repeat();
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
                repeat();
            }
            catch (Exception e)
            {
                Console.WriteLine("Napacen ukaz, opis napake:");
                Console.WriteLine(e.Message);
            }


        }

        private static void repeat()
        {
            Console.WriteLine("Nadaljuj? Y/N");

            try
            {
                string choice = Console.ReadLine();
                if( choice.Equals("Y", StringComparison.OrdinalIgnoreCase)){
                    izbirniMeni();
                }
                else
                {
                    Environment.Exit(0);
                }
            } catch(Exception e)
            {
                Console.WriteLine("Prislo je do napake:");
                Console.WriteLine(e.Message);
            }
             
        }
    }
}
