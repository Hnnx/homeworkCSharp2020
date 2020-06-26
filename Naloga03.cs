using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{

    class nal3
    {

        public static void func(double premer)
        {

            const double PI = 3.141592653589;

            double polmer = premer / 2;

            double o = (2 * PI) * polmer;
            double S = PI * Math.Pow(polmer, 2);

            Console.WriteLine("Obseg kroga s premerom {0}: " + o, premer);
            Console.WriteLine("Ploscina kroga s premerom {0}: " + S, premer);

        }


    }
}
