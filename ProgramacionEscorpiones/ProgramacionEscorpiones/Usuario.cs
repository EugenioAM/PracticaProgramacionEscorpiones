using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEscorpiones
{
    class Usuario
    {
        int id;
        string email, pw, alias, fecha_alta, hora_alta, ultima_conexion;

        public Usuario(){}

        public Usuario(string email, string pw, string alias)
        {
            this.email = email;
            this.pw = pw;
            this.alias = alias;
        }

        // pw
        public string getPw()
        {
            return this.pw;
        }

        public void setPw(string pw)
        {
            this.pw = pw;
        }

        // alias
        public string getAlias()
        {
            return this.alias;
        }

        public void setAlias(string alias)
        {
            this.alias = alias;
        }

        // fecha_alta
        public string getFecha_alta() 
        {
            return this.fecha_alta;
        }

        public void setFecha_alta(string fecha_alta) 
        { 
            this.fecha_alta = fecha_alta;
        }

        // ultima_conexion
        public string getUltima_conexion()
        {
            return this.ultima_conexion;
        }
        public void setultima_conexion(string ultima_conexion)
        {
            this.ultima_conexion = ultima_conexion;
        }
        // hora_alta
        public string getHora_alta()
        {
            return this.hora_alta;
        }

        public void setHora_alta(string hora_alta)
        {
            this.hora_alta = hora_alta;
        }


        // Email
        public string getemail() 
        {
            return this.email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }

        // id
        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        
        
        
    }

}
