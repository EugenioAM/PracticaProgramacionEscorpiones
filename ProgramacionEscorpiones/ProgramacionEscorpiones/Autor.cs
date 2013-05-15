using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEscorpiones
{
    class Autor
    {
        int id_autor;
        string nombre, url, fecha_publicacion;

        public Autor() { }

        public Autor(string url)
        {

            this.url = url;


        }

        // url
        public void SetUrl(string url)
        {

            this.url = url;


        }
        public string getUrl()
        {

            return this.url;

        }
        public void SetNombre(string url)
        {

            this.nombre = nombre;


        }
        public string getNombre()
        {

            return this.nombre;


        }
        public void Setfecha_publicacion(string url)
        {

            this.fecha_publicacion = fecha_publicacion;


        }
        public string getfecha_publicacion()
        {

            return this.fecha_publicacion;

        }
    }
}
