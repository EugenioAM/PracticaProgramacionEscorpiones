using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEscorpiones
{


    public class Usuario_Activo
    {
        private static Usuario_Activo usuario_activo;

        private Usuario_Activo()
        {
        }

        public static Usuario_Activo Instance()
        {
            if (usuario_activo == null)
            {
                usuario_activo = new Usuario_Activo();
            }

            return usuario_activo;
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
