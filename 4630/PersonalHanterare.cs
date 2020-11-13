using System;
using System.Collections.Generic;

namespace _4630
{



class PersonalHanterare
{
    
    public List<Anstalld> Panstalld = new List<Anstalld>();

    public void LäggTillAnställd()
    {
        Console.WriteLine("");
        Console.WriteLine("Välj typ av anställd");
        Console.WriteLine("Vilken sorts anställd");
        Console.WriteLine("1, Provisionanställd");
        Console.WriteLine("2, Bas och provision anställd");
        Console.WriteLine("3, Fastanställd");
        Console.WriteLine("4, Timanställd");
        Console.WriteLine("a. Avsluta");
        String val = Console.ReadLine();

         if (val == "3")
           {
               Console.WriteLine("");
               Console.WriteLine("Namn: ");
               String fornamn = Console.ReadLine();
               String efternamn = Console.ReadLine();
               Console.WriteLine("Månadslön: ");
               String lönen = Console.ReadLine();
               Panstalld.Add(new Fastanstalld(fornamn, efternamn, Convert.ToDouble(lönen)));
           }

           else if (val =="1")
           {
               Console.WriteLine("");
               Console.WriteLine("Namn: ");
               String fornamn = Console.ReadLine();
               String efternamn = Console.ReadLine();
               Console.WriteLine("Provision(%): ");
               String provision = Console.ReadLine();
               Console.WriteLine("Försäljning: ");
               String forsaljning = Console.ReadLine();
               Panstalld.Add(new Provisionsanstalld(fornamn, efternamn, Convert.ToDouble(provision), Convert.ToDouble(forsaljning)));
            }

            else if (val =="2")
            {
                Console.WriteLine("");
                Console.WriteLine("Namn: ");
                String fornamn = Console.ReadLine();
                String efternamn = Console.ReadLine();
                Console.WriteLine("Provision: ");
                String provision = Console.ReadLine();
                Console.WriteLine("Försäljning: ");
                String forsaljning = Console.ReadLine();
                Console.WriteLine("Lön: ");
                String lönen = Console.ReadLine();
                Panstalld.Add(new BasOchProvisionsAnstalld(fornamn, efternamn, Convert.ToDouble(provision), Convert.ToDouble(forsaljning), Convert.ToDouble(lönen)));



            }

            else if (val =="4")
            {
                Console.WriteLine("");
                Console.WriteLine("Namn: ");
                String fornamn = Console.ReadLine();
                String efternamn = Console.ReadLine();
                Console.WriteLine("Timlön: ");
                String timlon = Console.ReadLine();
                Console.WriteLine("Arbetade timmar: ");
                String timmarna = Console.ReadLine();
                Panstalld.Add(new Timanstalld(fornamn, efternamn, Convert.ToDouble(timlon), Convert.ToDouble(timmarna)));

            }

            else
            {
                Console.WriteLine("Fel syntax");
                LäggTillAnställd();
                
            }

       }

       public void PrintAnställd()
       {
           foreach (Anstalld item in Panstalld)
           {
               Console.WriteLine(item.ToString());
               Console.WriteLine("");
           }
       }

       public void Printnamnet()
       {
           foreach (Anstalld info in Panstalld)
           {
               Console.WriteLine(info.Namn);
           }
       }
    }
}
       
    

    





