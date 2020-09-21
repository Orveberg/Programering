using System;
using System.Collections.Generic;

namespace HelloWorld
{
class Program
  {
      static void Main(string[] args)
      {
         
          Uppgift_spel();

       
      }
            static void Uppgift_spel()
            { 
                List<QuestionCard> questions = new List<QuestionCard>();

                 questions.Add(new QuestionCard("Vad är Norges huvudstad", "Oslo", "Stockholm", "Helsingfors", "Köpenhamn","Oslo"));
                questions.Add(new QuestionCard ("Vad är Finlands huvudstad", "Stockholm", "Köpenhamn", "Helsingfors", "Oslo", "Helsingfors"));
                   questions.Add(new QuestionCard ("Vad är Danmakrs huvudstad", "Helsingfors", "Köpenhamn", "Stockholm", "Oslo", "Köpenhamn"));
                
              foreach (var item in questions)
              {
                  askQuestion(item);

                  
              }



            }



                static void askQuestion (QuestionCard Q)

                {
                    Console.WriteLine(Q.question);
                    Console.WriteLine("");


                    Console.WriteLine(Q.alt1 + " " + Q.alt2);
                    Console.WriteLine(Q.alt3 + " " + Q.alt4);

                    String svar = Console.ReadLine();

                    if (svar == Q.answer)
                    {
                        Console.WriteLine("Du gissade rätt!");

                       


                    }
                    else{
                        
                        Console.WriteLine("Du gissade fel");

                
                    }

                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {



                    }

                    Console.Clear();

                    
                        
                    
            

                







                }
                
                







                



            }
}
            




  