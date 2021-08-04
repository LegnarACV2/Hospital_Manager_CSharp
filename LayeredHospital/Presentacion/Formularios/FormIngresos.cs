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
    public partial class FormIngresos : Form
    {
        private ModeloIngresos ingresos = new ModeloIngresos();
        public FormIngresos()
        {
            InitializeComponent();
            panel_ingresos.Enabled = false;
        }
        private void ListarIngresos()
        {
            try
            {
                dgv_Ingresos.DataSource = ingresos.GetAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
        }

        private void FormIngresos_Load(object sender, EventArgs e)
        {
            ModeloPacientes instancia_paciente = new ModeloPacientes();
            ModeloHabitaciones instancia_habitacion = new ModeloHabitaciones();
            ListarIngresos();

            cmbx_Pacientes.DataSource = instancia_paciente.GetAll();
            cmbx_Pacientes.DisplayMember = "Nombre";
            cmbx_Pacientes.ValueMember = "Id_Paciente";

            cmbx_habitaciones.DataSource = instancia_habitacion.GetAll();
            cmbx_habitaciones.DisplayMember = "Numero";
            cmbx_habitaciones.ValueMember = "Id_Habitacion";
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            panel_ingresos.Enabled = true;
            ingresos.estado = EstadoEntidad.Added;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            panel_ingresos.Enabled = true;
            if (dgv_Ingresos.SelectedRows.Count > 0)
            {
                ingresos.estado = EstadoEntidad.Modified;
                ingresos.Id_ingreso = Convert.ToInt32(dgv_Ingresos.CurrentRow.Cells[0].Value);
                cmbx_Pacientes.Text = dgv_Ingresos.CurrentRow.Cells[1].Value.ToString();
                cmbx_habitaciones.Text = dgv_Ingresos.CurrentRow.Cells[2].Value.ToString();
                timepicker_Ingresos.MinDate = Convert.ToDateTime(dgv_Ingresos.CurrentRow.Cells[3].Value);
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila del Data Grid View Para editarla");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Ingresos.SelectedRows.Count > 0)
            {
                ingresos.estado = EstadoEntidad.Deleted;
                ingresos.Id_ingreso = Convert.ToInt32(dgv_Ingresos.CurrentRow.Cells[0].Value);
                string result = ingresos.GuardarCambios();
                MessageBox.Show(result);
                ListarIngresos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                ingresos.Id_paciente_i = Convert.ToString(cmbx_Pacientes.SelectedValue);
                ingresos.Id_habitacion_i = Convert.ToString(cmbx_habitaciones.SelectedValue);
                ingresos.Fecha_inicio = timepicker_Ingresos.Value.Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            bool valid = new Soportes.DatosValidacion(ingresos).Validado();
            string result = ingresos.GuardarCambios();
            MessageBox.Show(result);
            ListarIngresos();
            panel_ingresos.Enabled = false;
        }
    }
}
