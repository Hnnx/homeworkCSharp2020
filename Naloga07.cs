using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace homeworkCSharp2020
{
    class nal7
    {

        public static void func(string pal)
        {
            string reversed = "";

            for(int i = pal.Length - 1; i >= 0; i--)
            {
                reversed += pal[i];
            }

            if (checkString(pal, reversed))
            {
                Console.WriteLine("string {0} is a palindrome", pal);
            }
            else
            {
                Console.WriteLine("string {0} is *NOT* a palindrome", pal);
            }

        }

        static bool checkString(string input, string palindrome)
        {
            return input.Equals(palindrome) ? true : false;
            
        }
    }
}
