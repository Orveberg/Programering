using System;
using System.Collections.Generic;

namespace _4630
{

     class Fastanstalld : Anstalld
    {
        private double monadslon;

        public Fastanstalld(String FNamn, String ENamn, double Mlon)
        {
            fornamn = FNamn;
            efternamn = ENamn;
            monadslon = Mlon;


        }
        public override double Beraknalon()
        {
            return monadslon;
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Månadslön: " + Beraknalon();

        }







        
    }





}