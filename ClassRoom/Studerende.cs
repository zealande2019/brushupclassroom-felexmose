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
            // adding a constraint or requirement on a constructor parameter?
            // for at sørger for at der indtastes te tal mellem 1-12 som fødselsmåned
            // kræver det premium bruger, kode er såledels : Contract.Requires(fødselsmåned<12 && fødselsmåned >1);

            if (fødselsmåned<1 && fødselsmåned > 12)
            {
                 throw new ArgumentNullException();
                
            } else
            {
                this.Navn = name;
                this.fødselsmåned = fødselsmåned;
                this.fødselsdag = fødselsdag;
            }
            

        }


    }
}
