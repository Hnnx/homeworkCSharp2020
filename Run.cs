using Naloga01;
using Naloga02;
using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class Run
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Naloga 1:");
            Console.WriteLine("Napisi program, ki bo izracunal in izpisal rezultata racunov:\n"+
            "1) (10 + 5) / 3 = ?\n"+
            "2) (22 + 99) * (113 / 14)\n" );
            nal1.func();
            Console.WriteLine("\n");

            Console.WriteLine("Naloga 2:");
            Console.WriteLine("Program naj sprejme 5 argumentov v obliki celega stevila. Program naj izpise najmanjse stevilo,\nnajvecje stevilo in povprecno vrednost vseh stevil.\n");
            nal2.func(1,2,3,4,5);
            Console.WriteLine("\n");

            Console.WriteLine("Naloga 3:");
            Console.WriteLine("Program naj sprejme en parameter tipa double. Podani argument predstavlja premer kroga.\nProgram naj izračuna in izpiše obseg in ploščino kroga. Za pi uporabi vrednost 3,141592653589.");
            nal3.func(12.5);
            Console.WriteLine("\n");

            Console.WriteLine("Naloga 4:");
            Console.WriteLine("Program naj sprejme 1 argument v obliki celega stevila. Podan argument naj bo 4 mestno stevilo, ki predstavlja letnico rojstva.\n" +
                "Program naj izpise: \"Stari ste XX let.Lahko se udelezite volitev.\",\nce je starost 18 ali vec, ce pa je manj pa naj izpise: \"Zal ste premladi.Volitev se lahko udelezite cez XX let.\n" +
                "Na mestu XX naj se izpisejo primerne stevilske vrednosti glede na vneseno letnico.");




        }
    }
}
