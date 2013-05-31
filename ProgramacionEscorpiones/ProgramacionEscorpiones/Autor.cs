using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEscorpiones
{
    public class Autor
    {
        private static Autor autor_twit;

        private Autor()
        {
        }

        public static Autor Instance()
        {
            if (autor_twit == null)
            {
                autor_twit = new Autor();
            }

            return autor_twit;
        }

        public int id_autor { get; set; }
        public string nombre { get; set; }
        public string url_autor { get; set; }
        public string fecha_alta_autor { get; set; }


    }
}