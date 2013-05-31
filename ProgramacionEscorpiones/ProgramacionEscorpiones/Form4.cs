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
        public Form4()
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


        private void textBox1_click(object sender, EventArgs e)
        {
            textBoxNuevoAlias.Text = "";
         
        }

        private void textBox2_click(object sender, EventArgs e)
        {
           


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
                if (this.textBoxPw.Text == usuario_activo.pw)
                {
                    sentenciaSQL = "UPDATE sql28127.usuarios SET alias='" + this.textBoxNuevoAlias.Text + "' where id_usuario= '" + usuario_activo.id + "' ;";
                    // sentenciaSQL = "UPDATE test.usuarios SET alias='" + this.textBoxNuevoAlias.Text + "' where id_usuario= '" + usuario_activo.id + "' ;";
                    comando = new MySqlCommand(sentenciaSQL, conexion);
                    resultado = comando.ExecuteReader();
                    this.Close();

                    Form3 principal = new Form3();
                    principal.Show();

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
            this.Close();

            Form7 configur = new Form7();
            configur.Show();
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {

            textBox1.Text = "";

        }
    }
}
