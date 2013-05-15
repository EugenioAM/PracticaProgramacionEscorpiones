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
    public partial class Form3 : Form
    {
        Usuario usuario_activo = new Usuario();

        public Form3()
        {
            InitializeComponent();
            usuario_activo.setId(22);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //acceso ventana configuracion
            Hide();
            Form7 Registrar = new Form7();
            Registrar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton añadir autor
            Hide();
            Form8 Registrar = new Form8();
            Registrar.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //ventana añadir autor
            Hide();
            Form8 Registrar = new Form8();
            Registrar.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form7 Registrar = new Form7();
            Registrar.Show();
        }


        
        
        
        
    }
}
