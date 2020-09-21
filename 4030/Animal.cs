using System;
using System.Collections.Generic;

namespace _4030
{
    class Cat 
    {
        public int age {get;}

        public Cat(int publicAge)
        {
            age = publicAge;

        }

        public void Act()
        {
        for (int i = 0; i < age; i++)
        {
            Console.Write("mjau, ");


        }
        }
    }

    class Dog 
    {
        public int age {get;}

        public Dog(int publicAge)
        {
            age = publicAge;

        }

        public void Act()
        {
        for (int i = 0; i < age; i++)
        {
            Console.Write("vov, ");


        }
        Console.WriteLine();
        }
    }

    class Ko
      {
        public int age {get;}

        public Ko(int publicAge)
        {
            age = publicAge;

        }

        public void Act()
        {
        for (int i = 0; i < age; i++)
        {
            Console.Write("Mu, Muu");


        }
        Console.WriteLine();
        }
    }
    class Zoo
    {
        List<Cat> cats = new List<Cat>();
        List<Dog> dogs = new List<Dog>();

        List<Ko> kossa = new List<Ko>();

        public Zoo()
        {
            cats.Add(new Cat(3));

            cats.Add(new Cat(3));

            cats.Add(new Cat(3));

            dogs.Add(new Dog(3));

            dogs.Add(new Dog(3));

            kossa.Add(new Ko(1));
            
            kossa.Add(new Ko(1));

            kossa.Add(new Ko(1));

            




        }

        public void Act()
        {
            foreach (var item in cats)
            {
                item.Act();
                

             
            }
             foreach (var item in dogs)
            {
                item.Act();
                

             
            }
            foreach (var item in kossa)
            {
                item.Act();
                
            }



        }



    }
}