using System;
using System.Collections.Generic;

namespace _4630
{

     class Timanstalld : Anstalld
    {
        private double timlon;
        private double arbetstimmar;

          public Timanstalld(String FNamn, String ENamn, double PTimlon, double PArbetstimmar)
          {
                 
            fornamn = FNamn;
            efternamn = ENamn;
            timlon = PTimlon;
            arbetstimmar = PArbetstimmar;


      }

         public override double Beraknalon()
        {
            return timlon * arbetstimmar;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + " Timlön: " + timlon + Environment.NewLine + " Arbetstimmar: " + arbetstimmar + Environment.NewLine + " Beräknadlön: " + Beraknalon();
        }



        
    }





}