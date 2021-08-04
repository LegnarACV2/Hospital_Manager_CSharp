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
    public partial class FormProcesos : Form
    {
        public FormProcesos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormIngresos ventana_ingresos = new FormIngresos();
            ventana_ingresos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCitas ventana_citas = new FormCitas(); ;
            ventana_citas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAltasMedicas ventana_AltasMedicas = new FormAltasMedicas();
            ventana_AltasMedicas.ShowDialog();
        }
    }
}
