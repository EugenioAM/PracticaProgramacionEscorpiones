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
    public partial class Form5 : Form
    {

        Usuario_Activo usuario_activo = Usuario_Activo.Instance();

        //la linea que guarda la ip del servidor MySql, el usuario y la pass
        String cadenaConexion;

        //Conector que almacena la conexión a la BBDD
        MySqlConnection conexion;

        //comando que quiero que se ejecute
        MySqlCommand comando;

        //Consulta
        String sentenciaSQL;

        //resultado de la consulta
        MySqlDataReader resultado;


        ComprobarMail util = new ComprobarMail();

        public Form5()
        {

            InitializeComponent();
            try
            {
                cadenaConexion = "Server = sql2.freesqldatabase.com ; Database = sql28127; Uid = sql28127; Pwd = lI9%vS2*; Port = 3306";
                // cadenaConexion = "Server = localhost; Database = liga; Uid = root; Pwd = ; Port = 3306;";
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Form7 configuracion = new Form7();
            configuracion.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string correo1 = textBox1.Text.ToString();
            string correo2 = textBox3.Text.ToString();
            if (correo1 == correo2)
            {
                if (this.textBox2.Text.ToString() == usuario_activo.pw)
                {
                    if (util.IsValidEmail(textBox1.Text.ToString()))
                    {
                        
                            sentenciaSQL = "UPDATE sql28127.usuarios SET email='" + this.textBox1.Text + "' WHERE id_usuario = '" + usuario_activo.id + "' ;";
                            //sentenciaSQL = "UPDATE liga.usuarios SET email='"  + this.textBox1.Text +  "' WHERE id_usuario = '" + usuario_activo.id + "' ;";
                            comando = new MySqlCommand(sentenciaSQL, conexion);

                            try
                            {
                                resultado = comando.ExecuteReader();
                                MessageBox.Show("Cambio completado", "Aceptado");
                                this.Close();

                                Form3 principal = new Form3();
                                principal.Show();
                            }
                            catch (MySqlException ex)
                            {
                                switch (ex.Number)
                                {
                                    case 1062:
                                        MessageBox.Show("Email EN USO","ERROR");
                                        break;
                                    default:
                                        MessageBox.Show(ex.ToString(),"AVISAR A LOS GURUS DEL PROGRAMA");/*para poder controlar los errores asi veo como salen*/
                                        break;
                                }
                            }
                    }
                    else
                    {
                        MessageBox.Show("Este email es erroneo","ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña erronea","ERROR");
                }

            }

            else
            {
                MessageBox.Show("Igualar email","ERROR");
            }
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            // Se pone a blancos
            textBox2.Text = "";
            // Se muestra el texto escrito como asteriscos
            textBox2.PasswordChar = '•';
            // Dejara un maximo de 30 caracteres al igual que la BBDD
            textBox2.MaxLength = 30;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }


    }
}
