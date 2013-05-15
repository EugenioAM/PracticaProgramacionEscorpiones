using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgramacionEscorpiones
{
    class Twit
    {
        int id_twit, id_autor;
        string contenido, fecha;

        public Twit() { }

        public Twit(int id_autor, string contenido)
        {

            this.id_autor = id_autor;
            this.contenido = contenido;
        }
        //id_autor
        public int getId_autor()
        {
            return this.id_autor;
        }

        public void setId_autor(int id_autor)
        {
            this.id_autor = id_autor;
        }
        //id_twit
        public int getid_twit()
        {
            return this.id_twit;
        }

        public void setid_twit(int id_twit)
        {
            this.id_twit = id_twit;
        }
        //fecha
        public string getfecha()
        {
            return this.fecha;
        }

        public void setfecha(string fecha)
        {
            this.fecha = fecha;
        }

        //contenido
        public string getcontenido()
        {
            return this.contenido;
        }

        public void setcontenido(string contenido)
        {
            this.contenido = contenido;
        }

    }
}
