using System;
using System.Collections.Generic;

namespace _4630
{

     class Test
    {
        public List<Anstalld> anstallda = new List<Anstalld>();

        public void Run()
        {

            anstallda.Add(new Timanstalld("Joakim ", "Orveberg", 100, 300));

              foreach (var anstalld in anstallda)
            {
                Console.WriteLine(anstalld.ToString());
            }

        }

        
    
    }





}