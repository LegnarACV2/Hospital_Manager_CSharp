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
    public partial class MostrarDoctores : Form
    {
        public MostrarDoctores()
        {
            InitializeComponent();
        }

        private void MostrarDoctores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.ListarMedicos' Puede moverla o quitarla según sea necesario.
            this.ListarMedicosTableAdapter.Fill(this.DataSetPrincipal.ListarMedicos);

            this.reportViewer1.RefreshReport();
        }
    }
}
