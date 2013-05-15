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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Autor autor = new Autor();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 Registrar = new Form2();
            Registrar.Show();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //aceptar
            Hide();
            Form3 Registrar = new Form3();
            Registrar.Show();


        }

        
    }
}

