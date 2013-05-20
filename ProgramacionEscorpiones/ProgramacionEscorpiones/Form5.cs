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
        Usuario usuario_activo = new Usuario();
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
        public Form5()
        {   

            InitializeComponent();
            try
            {
                cadenaConexion = cadenaConexion = "Server = sql2.freesqldatabase.com ; Database = sql28127; Uid = sql28127; Pwd = lI9%vS2*; Port = 3306"; 
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form7 configuracion = new Form7();
            configuracion.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string correo1 = textBox1.Text.ToString();
            string correo2 = textBox3.Text.ToString();
            if (correo1 == correo2)
            {
                if (textBox1.Text == usuario_activo.getemail())
                {
                    sentenciaSQL = "UPDATE usuarios SET email=" + textBox1 + "WHERE id_usuario =" + usuario_activo.getemail() + ";";
                    comando = new MySqlCommand(sentenciaSQL, conexion);
                    resultado = comando.ExecuteReader();

                }
                else
                {
                    MessageBox.Show("este correo ya existe");
                }
            }

            else
            {
                MessageBox.Show("comprobar correo");
            }
        }
                

        

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

      

        
    }
}
