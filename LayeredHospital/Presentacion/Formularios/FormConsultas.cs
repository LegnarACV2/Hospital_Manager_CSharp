using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Modelos;
using Negocio.ObjetosValores;

namespace Presentacion.Formularios
{
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
        }




      private void button1_Click(object sender, EventArgs e)
        {
        ModeloPacientes InstaciaPaciente = new ModeloPacientes();
        dgv_Consultas.DataSource = InstaciaPaciente.BuscarPaciente(txt_buscar.Text);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            ModeloDoctores InstaciaDoctor = new ModeloDoctores();
            dgv_Consultas.DataSource = InstaciaDoctor.BuscarDoctores(txt_buscar.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ModeloHabitaciones instanciahabitacion = new ModeloHabitaciones();
            dgv_Consultas.DataSource = instanciahabitacion.BuscarHabitacion(cmbx_consultas.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModeloCitas instanciaCitas = new ModeloCitas();
            dgv_Consultas.DataSource = instanciaCitas.BuscarCitas(txt_buscar.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModeloIngresos instanciaIngresos = new ModeloIngresos();
            dgv_Consultas.DataSource = instanciaIngresos.BuscarIngreso(txt_buscar.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModeloCitas instanciaCitas = new ModeloCitas();
            dgv_Consultas.DataSource = instanciaCitas.IngresosFecha(dateTimePicker1.Value.Date);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ModeloIngresos instanciaIngresos = new ModeloIngresos();
            dgv_Consultas.DataSource = instanciaIngresos.IngresosFecha(dateTimePicker1.Value.Date);
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModeloAltas modeloAltas = new ModeloAltas();
            dgv_Consultas.DataSource = modeloAltas.FiltrarAltas(txt_buscar.Text);

        }
    }
}
