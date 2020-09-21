using System;

namespace HelloWorld
{
    class QuestionCard
    {
        public String question;

        public String Question
        {
            get
            {

                return question;
            }



        }


        public String alt1 {get;}

        public String alt2 {get;}

        public String alt3 {get;}

        public String alt4 {get;}

        public String answer {get;}

        public QuestionCard(String pQuestion, String pAlt1, String pAlt2, String pAlt3, String pAlt4, String pAnswer)
        {
            question = pQuestion;

            alt1 = pAlt1;

            alt2 = pAlt2;

            alt3 = pAlt3;

            alt4 = pAlt4;

            answer = pAnswer;






        }






    }





}
