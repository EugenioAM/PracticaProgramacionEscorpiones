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
    public partial class Form4 : Form
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
        public Form4()
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


        private void textBox1_click(object sender, EventArgs e)
        {
            textBoxNuevoAlias.Text = "";
         
        }

        private void textBox2_click(object sender, EventArgs e)
        {
            //textBoxNuevoAlias.Text = "";
            //sentenciaSQL = "UPDATE usuarios SET pw=" + textBoxPw.Text +"where id_usuario=" + usuario_activo.getId() +";";

            //comando = new MySqlCommand(sentenciaSQL, conexion);
            //resultado = comando.ExecuteReader();


          

            // Se pone a blancos
            textBoxPw.Text = "";
            // Se muestra el texto escrito como asteriscos
            textBoxPw.PasswordChar = '•';
            // Dejara un maximo de 30 caracteres al igual que la BBDD
            textBoxPw.MaxLength = 30;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string alias = textBoxNuevoAlias.Text.ToString();
            string confirm = textBox1.Text.ToString();
            if (alias == confirm) 
            {
                if (textBoxPw.Text == usuario_activo.getPw())
                {
                    sentenciaSQL = "UPDATE usuarios SET alias=" + textBoxNuevoAlias.Text + "where id_usuario=" + usuario_activo.getId() + ";";
                    comando = new MySqlCommand(sentenciaSQL, conexion);
                    resultado = comando.ExecuteReader();

                }
                else
                {
                    MessageBox.Show("Este Alias ya Existe");
                }
            
            }
            else
            {
                MessageBox.Show("Comprobar Alias");
            }



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form7 configur = new Form7();
            configur.Show();
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {

            textBox1.Text = "";

        }
    }
}
