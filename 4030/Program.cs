using System;
using System.Collections.Generic;

namespace _4030
{
    class Program
    {
        static void Main(string[] args)
        {
             String Catmjau = Console.ReadLine();
             int Catmjauint = Convert.ToInt32(Catmjau);
             Cat minKatt = new Cat(Catmjauint);
             minKatt.Act();
             
             Console.WriteLine();

             String Dogvov = Console.ReadLine();
             int Dogvovint = Convert.ToInt32(Dogvov);
             Dog minDog = new Dog(Dogvovint);
             minDog.Act();

             Console.WriteLine();

             Zoo mittZoo = new Zoo();
             mittZoo.Act();




        }
    }
}
