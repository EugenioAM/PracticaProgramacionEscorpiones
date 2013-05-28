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
        RecolectarDatos datos = RecolectarDatos.Instance();

        public Form3()
        {
            InitializeComponent();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //acceso ventana configuracion
            this.Close();

            Form7 Registrar = new Form7();
            Registrar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton añadir autor
            this.Close();

            Form8 Registrar = new Form8();
            Registrar.Show();
        }
    }
}
