using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
            var vinter =
                from Studerende in lst
                where Studerende.fødselsmåned == 12 || Studerende.fødselsmåned == 1 || Studerende.fødselsmåned == 2
                select Studerende;

            var forår =
                from Studerende in lst
                where Studerende.fødselsmåned == 3 || Studerende.fødselsmåned == 4 || Studerende.fødselsmåned == 5
                select Studerende;

            var sommer =
                from Studerende in lst
                where Studerende.fødselsmåned == 6 || Studerende.fødselsmåned == 7 || Studerende.fødselsmåned == 8
                select Studerende;

            var efterår =
                from Studerende in lst
                where Studerende.fødselsmåned == 9 || Studerende.fødselsmåned == 10 || Studerende.fødselsmåned == 11
                select Studerende;

            Console.WriteLine($"{vinter.Count()} har fødselsdag om vinteren");
            Console.WriteLine($"{forår.Count()} har fødselsdag om foråret");
            Console.WriteLine($"{sommer.Count()} har fødselsdag om sommeren");
            Console.WriteLine($"{efterår.Count()} har fødselsdag om efteråret");


            //int vinter = 0;
            //int forår = 0;
            //int sommer = 0;
            //int efterår = 0;

            //foreach (int item in studentQuery)
            //{
            //    if (item == 12 || item == 1 || item == 2 )
            //    {
            //        vinter++;
            //    }
            //    else if (item == 3 || item == 4 || item == 5)
            //    {
            //        forår++;
            //    }
            //    else if (item == 6 || item == 7 || item == 8)
            //    {
            //        sommer++;
            //    }
            //    else
            //    {
            //        efterår++;
            //    }

            //}


            //foreach (Studerende item in lst)                    
            //{
            //    if (item.fødselsmåned == 12 || item.fødselsmåned == 1 || item.fødselsmåned == 2)
            //    {
            //        vinter++;
            //    }
            //    else if (item.fødselsmåned == 3 || item.fødselsmåned == 4 || item.fødselsmåned == 5)
            //    {
            //        forår++;
            //    }
            //    else if (item.fødselsmåned == 6 || item.fødselsmåned == 7 || item.fødselsmåned == 8)
            //    {
            //        sommer++;
            //    }
            //    else
            //    {
            //        efterår++;
            //    }
            //}


        }
    }
}
