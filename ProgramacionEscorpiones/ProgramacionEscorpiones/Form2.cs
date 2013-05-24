using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

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



        ComprobarMail util = new ComprobarMail();

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

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string str1 = textBox2.Text.ToString();
            string str2 = textBox3.Text.ToString();
            if (str1 == str2)
            {
                if (util.IsValidEmail(textBox4.Text.ToString()))
                {
                    MessageBox.Show("Datos Validos");


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
                    try
                    {
                        comando.ExecuteNonQuery();
                    }

                    catch (MySqlException ex)
                    {
                        switch (ex.Number)
                        {
                            case 1062:
                                MessageBox.Show("Alias o Email EN USO");
                                break;
                            default:
                                MessageBox.Show(ex.ToString());/*para poder controlar los errores asi veo como salen*/
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Correo Invalido");
                }

            }
            else
            {

                MessageBox.Show("Contraseñas diferentes");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();//-----------NO TERMINA DE CERRARSE SI LE DAS AL BOTON DE ATRAS!! HAY QUE INVESTIGAR
            Form1 Index = new Form1();
            Index.Show();
        }

        private void Form2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

    }
}
