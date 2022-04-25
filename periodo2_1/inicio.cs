using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace periodo2_1
{
    public partial class inicio_frm : Form
    {
        public inicio_frm()
        {
            InitializeComponent();
        }

        private void inicio_frm_Load(object sender, EventArgs e)
        {

        }
        public struct datos
        { public string nombre; }

        private void button1_Click(object sender, EventArgs e)
        {
            datos informacion;
            informacion.nombre = textBox1.Text;
            final obj = new final(informacion);
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea salir?", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (respuesta == DialogResult.Yes)
            { this.Close(); }

        }
    }
}
