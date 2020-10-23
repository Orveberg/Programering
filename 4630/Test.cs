using System;
using System.Collections.Generic;

namespace _4630
{

     class Test
    {
        public List<Anstalld> Anstallda = new List<Anstalld>();

        public void Run(List<Anstalld> list)
        {

            Anstallda.Add(new Timanstalld("Joakim ", "Orveberg", 100, 300));

              foreach (var anstalld in list)
            {
                Console.WriteLine(anstalld.ToString());
            }

        }

        
    
    }





}