using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkCSharp2020
{
    class nal4
    {

        public static void func(string letnica)
        {

            if(letnica.Length != 4)
            {
                Console.WriteLine("Please insert a valid year of birth");
            }
            else
            {
                try
                {
                    int currentYear = DateTime.Now.Year;
                    int age = currentYear - (Convert.ToInt32(letnica));

                    if(age == 17)
                    {
                        Console.WriteLine("Sorry, you're too young({0}) - you can vote next year", age);
                    }
                    else if(age < 18)
                    {
                        int difference = 18 - age;
                        Console.WriteLine("Sorry, you're too young({0}) - you can vote in {1} years",age, difference );
                    }
                    else
                    {
                        Console.WriteLine("You are {0} years old and are eligible to vote", age);
                    }

                   
                }
                catch
                {
                    Console.WriteLine("Your input cannot be converted to a number - please use a valid input (e.g 1980)");
                }
            }



        }
    }
}
