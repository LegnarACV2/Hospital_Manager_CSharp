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
    public partial class FormMantenimientos : Form
    {
        public FormMantenimientos()
        {
            InitializeComponent();
        }

        private void image_Habitacion_MouseHover(object sender, EventArgs e)
        {
            image_Habitacion.Size = new System.Drawing.Size(250, 215);

        }

        private void image_Habitacion_MouseLeave(object sender, EventArgs e)
        {
            image_Habitacion.Size = new System.Drawing.Size(218, 198);
        }

        private void image_Habitacion_Click(object sender, EventArgs e)
        {
            FormHabitaciones ventana_habitaciones = new FormHabitaciones();
            ventana_habitaciones.ShowDialog();
        }

        private void image_Doctor_Click(object sender, EventArgs e)
        {
            FormDoctores ventana_doctores = new FormDoctores();
            ventana_doctores.ShowDialog();
        }

        private void image_registro_Click(object sender, EventArgs e)
        {
            FormPacientes ventana_pacientes = new FormPacientes();
            ventana_pacientes.ShowDialog();
        }

        private void image_Doctor_MouseHover(object sender, EventArgs e)
        {
            image_Doctor.Size = new System.Drawing.Size(200, 210);
        }

        private void image_Doctor_MouseLeave(object sender, EventArgs e)
        {
            image_Doctor.Size = new System.Drawing.Size(190, 197);
        }

        private void image_registro_MouseHover(object sender, EventArgs e)
        {
            image_registro.Size = new System.Drawing.Size(220, 210);

        }

        private void image_registro_MouseLeave(object sender, EventArgs e)
        {
            image_registro.Size = new System.Drawing.Size(202, 198);
        }
    }
}
