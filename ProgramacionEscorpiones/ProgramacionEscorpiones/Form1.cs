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
        Usuario usuario_activo = new Usuario;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cadenaConexion = "Server = sql2.freesqldatabase.com; Database = sql28127; Uid = sql28127; Pwd= lI9%vS2*; Port=3306";
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                MySqlCommand comando = new MySqlCommand("SELECT * from sql28127.usuarios WHERE alias='" + this.textBox1.Text + "' AND pw='" + this.textBox2.Text + "'; ", conexion);
                MySqlDataReader resultado;
                conexion.Open();
                resultado = comando.ExecuteReader();
                int contador = 0;
                while (resultado.Read())
                {

                    usuario_activo.setId(resultado.GetInt32("id_usuario"));
                    usuario_activo.setEmail(resultado.GetString("email"));
                    usuario_activo.setPw(resultado.GetString("pw"));
                    usuario_activo.setAlias(resultado.GetString("alias"));
                    usuario_activo.setHora_alta(resultado.GetString("hora_alta"));
                    usuario_activo.setFecha_alta(resultado.GetString("fecha_alta"));
                    usuario_activo.setultima_conexion(resultado.GetString("ultima_conexion"));

                    contador += 1;
                    //abre la conexion y confirma la conexion y contraseña el contador sera 1, si esta repetida te pondra el contado a 2 
                }
                if (contador == 1)
                {
                    this.Hide();
                    Form3 principal = new Form3();
                    principal.ShowDialog();
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
            Registrar.ShowDialog();


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
