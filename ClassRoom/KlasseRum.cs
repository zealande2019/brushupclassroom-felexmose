using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string KlasseNavn;
        public List<Studerende> Klasseliste;
        public DateTime SemesterStart;



        public KlasseRum()
        {

        }

        public static string Årstid(Studerende st)
        {
            if(st.fødselsmåned == 12 || st.fødselsmåned == 1 || st.fødselsmåned==2)
            {
                return "Vinter";
            } else if (st.fødselsmåned==3 || st.fødselsmåned==4 || st.fødselsmåned == 5)
            {
                return "Forår";
            } else if (st.fødselsmåned == 6 || st.fødselsmåned == 7 || st.fødselsmåned == 8)
            {
                return "Sommer";
            } else //if (st.fødselsmåned == 9 || st.fødselsmåned == 10 || st.fødselsmåned == 11)
            {
                return "Efterår";
            }
        }

        public static void HvrMngeHarFdslHvrtÅrtd(List<Studerende> lst)
        {
            int vinter = 0;
            int forår = 0;
            int sommer = 0;
            int efterår = 0;
            
            foreach(Studerende item in lst)
            {
                if (item.fødselsmåned == 12 || item.fødselsmåned == 1 || item.fødselsmåned == 2)
                {
                    vinter++;
                } else if (item.fødselsmåned == 3 || item.fødselsmåned == 4 || item.fødselsmåned == 5)
                {
                    forår++;
                }else if (item.fødselsmåned == 6 || item.fødselsmåned == 7 || item.fødselsmåned == 8)
                {
                    sommer++;
                } else
                {
                    efterår++;
                }
            }

            Console.WriteLine($"{vinter} har fødselsdag om vinteren");
            Console.WriteLine($"{forår} har fødselsdag om foråret");
            Console.WriteLine($"{sommer} har fødselsdag om sommeren");
            Console.WriteLine($"{efterår} har fødselsdag om efteråret");
        }
    }
}
