using System;
using System.Collections.Generic;


namespace _4630
{
    abstract class Anstalld
    {
        protected String fornamn;
        protected String efternamn;
        public String Namn
        {
            get

            {
                return fornamn + efternamn;
                
            }
            
        }

        abstract public double Beraknalon();
        public override string ToString()
        {
                return fornamn + efternamn;

         }
       





    

        
        



    }







}