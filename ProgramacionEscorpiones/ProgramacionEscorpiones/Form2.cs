using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace ProgramacionEscorpiones
{
    public partial class Form2 : Form
    {
        //La línea que guarda la IP del servidor MySql, el usuario y la pass
        String cadenaConexion;

        //Conector que almacena la conexión a la BBDD
        MySqlConnection conexion;

        //Comando que quiero que se ejecute
        MySqlCommand comando;

        //Consulta
        String sentenciaSQL;

        //Resultado de la consulta
        MySqlDataReader resultado;


        public Form2()
        {


            InitializeComponent();
            try
            {
                cadenaConexion = "Server = sql2.freesqldatabase.com; Database = sql28127; Uid = sql28127; Pwd= lI9%vS2*; Port=3306";
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

            }
            catch (MySqlException ex)
            {
                //para controlar los posibles fallos del mysql
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("No se puede conectar al servidor.  Contactar al administrador");
                        break;

                    case 1045:
                        MessageBox.Show("Nombre/contraseña incorrecta, intente de nuevo");
                        break;
                }

            }


        }





        private void button1_Click(object sender, EventArgs e)
        {


            //Primero obtengo la clave primaria más alta almacenada en la tabla de jugadores
            //En id_jugador_maximo guardaré el resultado de la query para saber cuál es el MAX id de jugador en la tabla
            int id_usuario_maximo = 0;
            sentenciaSQL = "Select MAX(id_usuario) from sql28127.usuarios";
            comando = new MySqlCommand(sentenciaSQL, conexion);
            resultado = comando.ExecuteReader();
            if (resultado.Read())
            {
                id_usuario_maximo = resultado.GetInt32(0);
                id_usuario_maximo++;
            }


            /*Por si se usa en un futuro-------- DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");*/
            /*
             *  string date = "30/07:2012 15:54:22";
            DateTime time;
            DateTime.TryParse(date, out time);
            string s = string.Format("select * from customers where EntryDate='{0}'", date);
             * 
             * 
             * /if your date format in db is like MM/dd/yyyy do:
             *string strDate = dateTimePicker1.Value.ToString("MM/dd/yyyy"); //change format accordinlgy to your format in DB!
             
             
             
             
             */

            sentenciaSQL = "INSERT INTO sql28127.usuarios" +
                "(id_usuario, email, pw, alias, hora_alta, fecha_alta, ultima_conexion)" + "VALUES ('"
                        + id_usuario_maximo + "','"
                        + textBox4.Text.ToString() + "','"
                        + textBox2.Text.ToString() + "','"
                        + textBox1.Text.ToString() + "','"
                        + DateTime.Now.ToString("HH:mm:ss") + "','"
                        + DateTime.Now.ToString("yyyy-MM-dd") + "','"
                        + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand(sentenciaSQL, conexion);
            comando.ExecuteNonQuery();


            //MessageBox.Show("OLA");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 Index = new Form1();
            Index.Show();
        }

        private void Form2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }


    }
}
