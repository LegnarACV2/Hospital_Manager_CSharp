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
    public partial class MostrarHabitaciones : Form
    {
        public MostrarHabitaciones()
        {
            InitializeComponent();
        }

        private void MostrarHabitaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.ListarHabitaciones' Puede moverla o quitarla según sea necesario.
            this.ListarHabitacionesTableAdapter.Fill(this.DataSetPrincipal.ListarHabitaciones);

            this.reportViewer1.RefreshReport();
        }
    }
}
