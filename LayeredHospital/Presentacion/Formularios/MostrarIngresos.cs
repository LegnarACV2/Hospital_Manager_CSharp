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
    public partial class MostrarIngresos : Form
    {
        public MostrarIngresos()
        {
            InitializeComponent();
        }

        private void MostrarIngresos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.MostrarIngresados' Puede moverla o quitarla según sea necesario.
            this.MostrarIngresadosTableAdapter.Fill(this.DataSetPrincipal.MostrarIngresados);

            this.reportViewer1.RefreshReport();
        }
    }
}
