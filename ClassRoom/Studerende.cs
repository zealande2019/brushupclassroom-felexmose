using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Studerende
    {
        public string Navn;
        public int fødselsmåned;
        public int fødselsdag;


        public Studerende(string name, int fødselsmåned, int fødselsdag )
        {
            this.Navn = name;
            this.fødselsmåned = fødselsmåned;
            this.fødselsdag = fødselsdag;

        }


    }
}
