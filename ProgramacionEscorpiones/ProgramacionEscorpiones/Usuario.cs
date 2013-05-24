using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEscorpiones
{
    class Usuario
    {  
        
        public Usuario()
        {
            // TODO: Complete member initialization
        }


        int id;
        string email, pw, alias, fecha_alta, hora_alta, ultima_conexion;

        public  Usuario(int id, string email, string pw, string alias, string fecha_alta, string hora_alta, string ultima_conexion)
        {
            this.id = id;
            this.email = email;
            this.pw = pw;
            this.alias = alias;
            this.fecha_alta = fecha_alta;
            this.hora_alta = hora_alta;
            this.ultima_conexion = ultima_conexion;
        }

      


        // id
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }


        // email
        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getemail()
        {
            return this.email;
        }


        // pw  
        public void setPw(string pw)
        {
            this.pw = pw;
        }
        public string getPw()
        {
            return this.pw;
        }


        // alias
        public void setAlias(string alias)
        {
            this.alias = alias;
        }
        public string getAlias()
        {
            return this.alias;
        }


        // fecha_alta         
        public void setFecha_alta(string fecha_alta)
        {
            this.fecha_alta = fecha_alta;
        }
        public string getFecha_alta()
        {
            return this.fecha_alta;
        }


        // hora_alta
        public void setHora_alta(string hora_alta)
        {
            this.hora_alta = hora_alta;
        }
        public string getHora_alta()
        {
            return this.hora_alta;
        }


        // ultima_conexion
        public void setultima_conexion(string ultima_conexion)
        {
            this.ultima_conexion = ultima_conexion;
        }
        public string getUltima_conexion()
        {
            return this.ultima_conexion;
        }
    }
}
