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
            /*
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
            nal4.func("2002");
            Console.WriteLine("\n");

            Console.WriteLine("Naloga 5:");
            Console.WriteLine("Napisi program, ki sprejme argument v obliki niza ter izpise vsako drugo crko.");
            nal5.func("123456789012345");
            Console.WriteLine("Naloga 6:");
            Console.WriteLine("Napisi program, ki sprejme argument v obliki niza. Program naj izpise nakljucno crko iz niza ter drugo in predzadnjo crko iz niza.");
            nal6.func("AZBESTOS");


            Console.WriteLine("Naloga 7:");
            Console.WriteLine("Program naj sprejme argument v obliki niza in preveri ali je niz palindrom.");
            nal7.func("FRACA");
            nal7.func("ANAANA");

            Console.WriteLine("Naloga 8:");
            Console.WriteLine("Napisi program, ki bo sprejel dva argumenta v obliki celih stevil ter izrisal pravokotnik z zvezdicami, kjer prvi argument predstavlja stevilo vrstic, drugi pa stevilo stolpcev oz. zvezdic v vrstici.");
            nal8.func(5, 5);


            Console.WriteLine("Naloga 9:");
            Console.WriteLine("Napisi program k z zvezdicami izpise nakljucno velik trikotnik. Trikotnik naj bo obrnjen navzdol visina trikotnika naj bo vsaj 3 in največ 15 vrstic.");
            nal9.func();
            nal9.func();


            Console.WriteLine("Naloga 9 - Bonus");
            Console.WriteLine("Napisi program ki z zvezdicami izpise jelko. Visina krosnje naj bo 9 vrstic, deblo pa 2 vrstici sirina debla pa 3 zvezdice.");
            Console.WriteLine("BONUS2: Program naj visino krosnje prejme prek argumenta. Deblo je vedno 2 vrstici in 3 zvezdice.");

            for (int i = 3; i < 9; i++)
            {

                nal9_01.func(i);

            }


            Console.WriteLine("Naloga 10:");
            Console.WriteLine("Program naj sprejeme argument tipa String, nato naj izpise koliko krat se v sprejetem nizu pojavta crki ‘a’  in ’t’. Stevilo pojavitev naj izpise v stevilu in v procentih.");
            nal10.func("Torta");

            Console.WriteLine("Naloga 11:");
            Console.WriteLine("Program naj sprejme argument v obliki celega stevila. Program naj izpise ime meseca, katerega koledarsko zaporedje se ujema z vnesenim stevilom.\nCe vneseno stevilo ni enako nobenemu mesecu naj program izpiše: \"Great Scott!\".");
            nal11.func(3);


            Console.WriteLine("Naloga 12");
            Console.WriteLine("Napisi program, ki preko argumenta sprejme 6 mestno stevilo. Ce vnešeno Stevilo ni 6 mestno naj se izpiše:\n\"Stevilo ne ustreza pogojem\".\nCe vneseno stevilo ustreza pogojem, naj program sesteje prve tri števila z zadnjimi tremi.");
            nal12.func(111111);


            Console.WriteLine("Naloga 13");
            Console.WriteLine("Program naj izpise vsa stevila med 0 in 14000, ki so hkrati deljiva z 5, 11 in 13.");
            nal13.func();



            Console.WriteLine("naloga 14");
            Console.WriteLine("V programu definiraj 2 dimenzionalno tabelo tipa int[14][9] ter jo napolni z naključnimi števili vrednosti med 1 in 70.");
            Console.WriteLine("Program naj izpiše tabelo\nProgram naj izpiše vsa števila v tabeli, ki so deljiva s 7\nProgram naj sešteje vsa števila v tabeli in izpiše rezultat");
            nal14.func();
            nal14.showTable();
            nal14.showSeven();
            nal14.calcAll();



            Console.WriteLine("Naloga 15:");
            Console.WriteLine("V programu definiraj 4 dimenzionalno tabelo tipa int poljubne velikosti.\nTabelo napolni z nakljucnimi vrednostmi med 1 in 10 ter tabelo izpisi.");
            nal15.fourDimDisplay();



            Console.WriteLine("Naloga 16:");
            Console.WriteLine("Program naj od uporabnika zahteva vnos 2 števil, ki predstavljata velikost dvo dimenzionalne tabele tipa int[][].\n Program naj tabelo napolni z naključnimi števili vrednosti med 1 in 170." +
                "\n\n\nProgram naj izpiše tabelo\nProgram naj sešteje in izpiše vrednost vseh števil v tabeli." +
                "\nProgram naj sešteje in izpiše vrednost posameznih vrstic tabele.\nProgram naj sešteje in izpiše vrednost posameznih stolpcev tabele.");
            nal16.func();



            Console.WriteLine("Naloga 17:");
            Console.WriteLine("V programu definiraj tabelo String[][] nakljucne velikosti med 1 in 5 (Math.random()).\nProgram naj uporabnika vprasa naj vnese niz za vsako celico tabele.Program naj nato tabelo izpiše.");
            nal17.func();



            Console.WriteLine("Naloga 18:");
            Console.WriteLine("Kalkulatorju, ki smo ga naredili na vajah dodaj se vsaj dve funkciji. (referenca - Java calculator)");
            nal18.izbirniMeni();


            Console.WriteLine("Naloga 19:");
            Console.WriteLine("Program z vaje Metode3.java spremeni tako, da se za zadnjim številom v tabeli ne izpiše vejica.");
            nal19.func();


            Console.WriteLine("Naloga 20");
            Console.WriteLine("Napiši program, ki ima poleg metode main še dve metodi:\n" +
                "Prva metoda je tipa double in sprejme 1 dimenzionalno tabelo tipa int - vrne naj povprečno vrednost vseh števil v tabeli\n" +
                "Druga metoda je tipa void in sprejme 1 dimenzionalno tabelo tipa int -prejeto tabelo naj izpiše\n" +
                "V metodi main deklariraj 1 dimenzionalno tabelo, tipa int, velikosti 50 in jo napolni z naključnimi števili vrednosti med 1000 in 5000);");

            //DECLARE ARR
            int[] exampleArray = new int[20];

            for (int i = 0; i < exampleArray.Length; i++)
            {
                exampleArray[i] = i;
            }


            nal20.displayTable(exampleArray);
            Console.WriteLine("\nAverage: " + nal20.averageArray(exampleArray));


            Console.WriteLine("Naloga 21");
            Console.WriteLine("Programu Kalkulator 2, ki smo ga naredili na vajah dopolni prazne metode in mu dodaj še vsaj tri poljubne funkcije.");
            nal21.izbirniMeni();

            */

            Console.WriteLine("Naloga 22");
            Console.WriteLine("Napiši program, ki bo uporabnika vprašal naj vnese poljuben niz. Vneseni niz naj nato zapiše v datoteko mojiNizi.txt. Program naj ohrani prej zabeležene nize.");
            nal22.writeFile();







        }
    }
}
