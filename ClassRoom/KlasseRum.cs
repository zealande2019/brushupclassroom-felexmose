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

        public string Årstid(Studerende st)
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

        public void HvorMangeHarFdslHvertÅrtid(List<Studerende> lst)
        {

        }
    }
}
