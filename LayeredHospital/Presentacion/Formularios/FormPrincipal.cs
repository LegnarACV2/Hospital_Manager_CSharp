using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMantenimientos ventana_mantenimientos = new FormMantenimientos();
            ventana_mantenimientos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConsultas ventana_consultas = new FormConsultas();
            ventana_consultas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProcesos ventana_FormProcesos = new FormProcesos();
            ventana_FormProcesos.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormReportes ventana_reportes = new FormReportes();
            ventana_reportes.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
