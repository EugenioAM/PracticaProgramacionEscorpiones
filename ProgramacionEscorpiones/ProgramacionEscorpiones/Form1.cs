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
    {    //necesitamos unas variables 
        //la linea que guarda el ip del servidor, el usuario y la pass
        String cadenaConexion;

        //conector que almacena la conexion a la BBDD
        MySqlConnection conexion;

        //necesitamos un comando para que se ejecute
        MySqlCommand comando;

        //Consulta
        String sentenciaSQL;

        //resultado de la consulta 
        MySqlDataReader resultado;

        //bool vUsuario, vPassword = true;

        public Form1()
        {

            InitializeComponent();
            try
            {
                cadenaConexion = "Server = sql2.freesqldatabase.com ; Database = sql28127; Uid = sql28127; Pwd = lI9%vS2*; Port = 3306";
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
            textBox2.PasswordChar = '*';
            // Dejara un maximo de 30 caracteres al igual que la BBDD
            textBox2.MaxLength = 30;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Hide();
            Form3 principal = new Form3();
            principal.Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       


    }
}
