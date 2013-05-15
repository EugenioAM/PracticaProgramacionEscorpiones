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
            //cambiar nombre
            Hide();
            Form4 Registrar = new Form4();
            Registrar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cambiar pass
            Hide();
            Form6 Registrar = new Form6();
            Registrar.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //cambiar mail
            Hide();
            Form5 Registrar = new Form5();
            Registrar.Show();

        }
    }
}
