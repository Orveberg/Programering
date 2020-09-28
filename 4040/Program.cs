using System;
using System.Collections.Generic;

namespace _4040
{
    class Program
    {
        static void Main(string[] args)
        {
          databas myDatabas = new databas();
          myDatabas.Add(new dvd("hejhej", "joakim"));
          
          myDatabas.SkrivUt();

          
        }
    }
}
