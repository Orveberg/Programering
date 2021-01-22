using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frågesport
{
    class Questioncard
    {
        public String question { get; }

        public String answer { get; }

        public Questioncard(string q, string ans)
            {
                question = q;
                answer = ans;
            }



    }
}
