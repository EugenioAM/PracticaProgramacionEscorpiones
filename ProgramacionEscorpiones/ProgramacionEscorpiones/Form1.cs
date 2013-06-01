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
    public partial class Form1 : Form
    {

        //La línea que guarda la IP del servidor MySql, el usuario y la pass
        String cadenaConexion;

        //Conector que almacena la conexión a la BBDD
        MySqlConnection conexion;

        //Comando que quiero que se ejecute
        MySqlCommand comando;

        Usuario_Activo datos = Usuario_Activo.Instance();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cadenaConexion = "Server = sql2.freesqldatabase.com; Database = sql28127; Uid = sql28127; Pwd= lI9%vS2*; Port=3306";
                //cadenaConexion = "Server = localhost; Database = liga; Uid = root; Pwd = ; Port = 3306;";
                conexion = new MySqlConnection(cadenaConexion);
                comando = new MySqlCommand("SELECT * from sql28127.usuarios WHERE alias='" + this.textBox1.Text + "' AND pw='" + this.textBox2.Text + "'; ", conexion);
               // comando = new MySqlCommand("SELECT * from test.usuarios WHERE alias='" + this.textBox1.Text + "' AND pw='" + this.textBox2.Text + "'; ", conexion);
                MySqlDataReader resultado;
                conexion.Open();
                resultado = comando.ExecuteReader();
                int contador = 0;
                while (resultado.Read())
                {
                    contador += 1;
                    //abre la conexion y confirma la conexion y contraseña el contador sera 1, si esta repetida te pondra el contado a 2 
                }
                if (contador == 1)
                {
                    int id_usr =  resultado.GetInt32("id_usuario");



                    datos.id = resultado.GetInt32("id_usuario");
                    datos.email = resultado.GetString("email");
                    datos.pw = resultado.GetString("pw");
                    datos.alias = resultado.GetString("alias");
                    datos.hora_alta = resultado.GetString("hora_alta");
                    datos.fecha_alta = resultado.GetString("fecha_alta");
                    datos.ultima_conexion = resultado.GetString("ultima_conexion");

                    this.Hide();

                    Form3 principal = new Form3();
                    principal.Show();
                }

                else if (contador > 1)
                {
                    MessageBox.Show("DUPLICADO DE NOMBRE O CONTRASEÑA! LLAMAR A LOS GURÚS!");
                }
                else
                    MessageBox.Show("Alias/Contraseña INCORRECTOS");
                conexion.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            //  MessageBox.Show(""+textBox2.Text.ToString());  Muestra la contraseña, muestra que se oculta la pass pero no cambia de valor
            Form2 Registrar = new Form2();
            Registrar.Show();


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



        private void Form1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


       

    }
}
