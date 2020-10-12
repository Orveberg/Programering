using System;
using System.Collections.Generic;

namespace _4630
{

     class BasOchProvisionsAnstalld : Provisionsanstalld
    {
        private double fastlon;

        public BasOchProvisionsAnstalld(String FNamn, String ENamn, double PProvision, double Pforsaljning, double Plon) : base(FNamn, ENamn, PProvision, Pforsaljning)
        {

            fastlon = Plon;
        }

        public override double Beraknalon()
        {
            return (provision / 100) * forsaljning;
        }

        public override string ToString()
        {
            return base.ToString() + ", Provision: " + provision + ", försäljning (SEK): " + forsaljning;
        }







        
    }





}