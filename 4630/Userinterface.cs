using System;
using System.Collections.Generic;

namespace _4630
{
    class UserInterfaces
    {
        static PersonalHanterare ph = new PersonalHanterare();

        public void Run(){
            PrintMenu();
            String svar = Console.ReadLine();
            while (svar != "a")
            {
                if (svar == "1")
                {
                    Console.WriteLine("");
                    ph.LäggTillAnställd();
                    Console.WriteLine("");                }

                else if (svar =="2")
                {
                   Console.WriteLine(""); 
                   ph.PrintAnställd(); 
                }

                else if (svar =="3")
                {
                    Console.WriteLine("");
                    ph.Printnamnet();
                    Console.WriteLine("");
                }

                else
                {
                    Console.WriteLine("Fel inmatning!");
                }

                PrintMenu();
                svar = Console.ReadLine();
            
            }
        }
        public void PrintMenu()
        {
            Console.WriteLine("Välkommen");
            Console.WriteLine("1. Lägg till en ny anställd");
            Console.WriteLine("2. Skriv ut uppgifter om alla anställda");
            Console.WriteLine("3. Skriv ut namn på alla anställda");
            Console.WriteLine("a. Avsluta");
        }
    }
}