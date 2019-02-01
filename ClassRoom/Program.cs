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
            KlasseRum Semester3 = new KlasseRum();
            Semester3.KlasseNavn = "3B";
            Semester3.SemesterStart = new DateTime(2018,9,4);

            Studerende felex = new Studerende("felex", 12,27);
            Studerende hasan = new Studerende("hasan", 03, 10);
            Studerende claus = new Studerende("claus", 11, 14);

            Semester3.Klasseliste.Add(felex);
            Semester3.Klasseliste.Add(hasan);
            Semester3.Klasseliste.Add(claus);

        }
    }
}
