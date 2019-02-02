using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum Semester3 = new KlasseRum
            {
                KlasseNavn = "3B",
                SemesterStart = new DateTime(2018, 9, 4),

            };
            //Studerende james = new Studerende("james", 13, 25);
            Studerende felex = new Studerende("felex", 12,27);
            Studerende hasan = new Studerende("hasan", 03, 10);
            Studerende claus = new Studerende("claus", 11, 14);

            Semester3.Klasseliste = new List<Studerende>
            {
                //james,
                felex,
                hasan,
                claus
            };

            foreach (Studerende item in Semester3.Klasseliste)
            {
                Console.WriteLine($"Navn:{item.Navn} og fødselsdato:{item.fødselsdag}/{item.fødselsmåned}");
               
            }

            KlasseRum.HvrMngeHarFdslHvrtÅrtd(Semester3.Klasseliste);
            
                   
        }
    }
}
