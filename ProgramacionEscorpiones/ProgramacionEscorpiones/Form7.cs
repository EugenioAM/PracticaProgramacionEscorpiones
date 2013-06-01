using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionEscorpiones
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // botón cambiar nombre
            Hide();
            Form4 Registrar = new Form4();
            Registrar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // botón cambiar pass
            Hide();
            Form6 pass = new Form6();
            pass.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
          

            //botón cambiar mail
            Hide();
            Form5 email = new Form5();
            email.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Volver a la ventana principal , Botón aceptar

            Hide();
            Form3 Aceptar = new Form3();
            Aceptar.Show();
        }
    }
}
