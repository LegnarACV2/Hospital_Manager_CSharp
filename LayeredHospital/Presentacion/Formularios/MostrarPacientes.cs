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
    public partial class MostrarPacientes : Form
    {
        public MostrarPacientes()
        {
            InitializeComponent();
        }

        private void MostrarPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.ListarPacientes' Puede moverla o quitarla según sea necesario.
            this.ListarPacientesTableAdapter.Fill(this.DataSetPrincipal.ListarPacientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
