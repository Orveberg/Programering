using System;
using System.Collections.Generic;


class Userinterface
{
    public void Run()
    {
        Console.WriteLine("1, Lägg till en Anställd");
        Console.WriteLine("2, Skriv ut uppgifter om alla anställda");
        Console.WriteLine("3, Skriv ut namn på alla Anställd");
        Console.WriteLine("4, Ändra på uppgifter om en anställd");
        Console.WriteLine("a, Avsluta");
        Console.ReadLine();
        String choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.WriteLine("Vilken sorts anställd");
            Console.WriteLine("1, Provisionanställd");
            Console.WriteLine("2, Bas och provision anställd");
            Console.WriteLine("3, Fastanställd");
            Console.WriteLine("4, Timanställd");

        }

        
    
    }



}