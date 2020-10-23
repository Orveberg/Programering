using System;
using System.Collections.Generic;

namespace _4630
{
    class Program
    {

        static void Main(string[] args)
        {
            Test test = new Test();
            
            test.Run(test.Anstallda); 

            Userinterface Userinterface = new Userinterface();
            Userinterface.Run();

        }
        
    }
}
