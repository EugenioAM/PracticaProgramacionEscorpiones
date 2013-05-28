using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEscorpiones
{


    public class RecolectarDatos
    {
        private static RecolectarDatos datos;

        private RecolectarDatos()
        {
        }

        public static RecolectarDatos Instance()
        {
            if (datos == null)
            {
                datos = new RecolectarDatos();
            }

            return datos;
        }

        public int id { get; set; }
        public string  email{ get; set; }
        public string  pw{ get; set; }
        public string  alias{ get; set; }
        public string  fecha_alta{ get; set; }
        public string  hora_alta{ get; set; }
        public string  ultima_conexion{ get; set; }
    }
}
