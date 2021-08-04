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
    public partial class MostrarCitas : Form
    {
        public MostrarCitas()
        {
            InitializeComponent();
        }

        private void MostrarCitas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.MostrarCitas' Puede moverla o quitarla según sea necesario.
            this.MostrarCitasTableAdapter.Fill(this.DataSetPrincipal.MostrarCitas);

            this.reportViewer1.RefreshReport();
        }
    }
}
