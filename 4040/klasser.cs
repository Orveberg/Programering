using System;
using System.Collections.Generic;

namespace _4040
{
    abstract class Sak
    {
        protected String titel;


        public String RTitel ()
        {
            return titel;
        }
        public virtual void Print()
        {


        }





    }
    class cd : Sak
    {
        private String Artist;
        public cd (String ptitel, String pauthor)
        {
            titel = ptitel;

            Artist = pauthor;





        }
        public override void Print()
        {
            Console.Write("Artist " + Artist + ", ");
        }
        
    }
    class dvd : Sak
    {
        private String Regissor;
        public dvd (String ptitel, String pauthor)
        {
            titel = ptitel;

            Regissor = pauthor;



        }
         public override void Print()
        {
            Console.Write("Regissor " + Regissor + ", ");
        }

    }
    class Bok : Sak
    {
        private String forfattare;
          public Bok (String ptitel, String pauthor)
        {
            titel = ptitel;

            forfattare = pauthor;



        }
        public override void Print()
        {
            Console.Write("forfattare " + forfattare + ", ");
        }




    }
    class databas

    {

       private List<Sak> Saker = new List<Sak>();

        public void Add(Sak enSak)
        {
            Saker.Add(enSak);


        }
        public void SkrivUt()
        {
            foreach (var item in Saker)
            {
                Console.WriteLine(item.GetType().Name);
                Console.WriteLine("Titel " + item.RTitel() );
                item.Print();
                
                


            }



        }


    }





}


