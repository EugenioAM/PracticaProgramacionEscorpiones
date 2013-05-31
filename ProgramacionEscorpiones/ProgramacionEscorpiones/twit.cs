using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgramacionEscorpiones
{
    public class Twit_Actual
    {
        private static Twit_Actual twit_actual;

        private Twit_Actual()
        {
        }

        public static Twit_Actual Instance()
        {
            if (twit_actual == null)
            {
                twit_actual = new Twit_Actual();
            }

            return twit_actual;
        }

        public int id_twit { get; set; }
        public int id_autor { get; set; }
        public string contenido { get; set; }
        public string fecha_twit{ get; set; }
        public string hora_twit { get; set; }
        

    }
}
