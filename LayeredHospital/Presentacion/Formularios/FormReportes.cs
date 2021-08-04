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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarPacientes mostrarPacientes = new MostrarPacientes();
            mostrarPacientes.Show();
        }

        private void btn_doctores_report_Click(object sender, EventArgs e)
        {
            MostrarDoctores mostrarDoctores = new MostrarDoctores();
            mostrarDoctores.ShowDialog();
        }

        private void btn_habitaciones_report_Click(object sender, EventArgs e)
        {
            MostrarHabitaciones mostrarHabitaciones = new MostrarHabitaciones();
            mostrarHabitaciones.ShowDialog();
        }

        private void btn_citas_report_Click(object sender, EventArgs e)
        {
            MostrarCitas mostrarCitas = new MostrarCitas();
            mostrarCitas.ShowDialog();
        }

        private void btn_ingresos_report_Click(object sender, EventArgs e)
        {
            MostrarIngresos mostrarIngresos = new MostrarIngresos();
            mostrarIngresos.ShowDialog();
        }
    }
}
