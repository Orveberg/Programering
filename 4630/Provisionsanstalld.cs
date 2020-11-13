using System;
using System.Collections.Generic;

namespace _4630
{

     class Provisionsanstalld : Anstalld
    {
        protected double provision;
        protected double forsaljning;

        public Provisionsanstalld(String FNamn, String ENamn, double PProvision, double Pforsaljning)
        {
            fornamn = FNamn;
            efternamn = ENamn;
            provision = PProvision;
            forsaljning = Pforsaljning;


        }

        public override double Beraknalon()
        {

            return (provision / 100) * forsaljning;

        }

        public override string ToString()
        {
            return base.ToString() +  Environment.NewLine + " Provision: " + provision + " försäljning (SEK): " + forsaljning;
        }



        
    }





}