using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Modelos;
using Negocio.ObjetosValores;

namespace Presentacion.Formularios
{
    public partial class FormCitas : Form
    {
        private ModeloCitas citas = new ModeloCitas();
        public FormCitas()
        {
            InitializeComponent();
            panel_citas.Enabled = false;
        }

        private void ListarCitas()
        {
            try
            {
                dgv_Citas.DataSource = citas.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void FormCitas_Load(object sender, EventArgs e)
        {
            ModeloDoctores instancia_doctores = new ModeloDoctores();
            ModeloPacientes instancia_pacientes = new ModeloPacientes();
            ListarCitas();

            cmbx_Doctores.DataSource = instancia_doctores.GetAll();
            cmbx_Doctores.DisplayMember = "Nombre";
            cmbx_Doctores.ValueMember = "Id_Doctor1";

            cmbx_Pacientes.DataSource = instancia_pacientes.GetAll();
            cmbx_Pacientes.DisplayMember = "Nombre";
            cmbx_Pacientes.ValueMember = "Id_Paciente";

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            panel_citas.Enabled = true;
            citas.estado = EstadoEntidad.Added;
        }
        private void Restar()
        {
            panel_citas.Enabled = false;
            txt_Hora.Clear();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            panel_citas.Enabled = true;
            if (dgv_Citas.SelectedRows.Count > 0)
            {
                citas.estado = EstadoEntidad.Modified;
                citas.Id_cita = Convert.ToInt32(dgv_Citas.CurrentRow.Cells[0].Value);
                timepicker_Citas.MinDate = Convert.ToDateTime(dgv_Citas.CurrentRow.Cells[1].Value);
                cmbx_Pacientes.Text = dgv_Citas.CurrentRow.Cells[2].Value.ToString();
                cmbx_Doctores.Text = dgv_Citas.CurrentRow.Cells[3].Value.ToString();
                txt_Hora.Text = dgv_Citas.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila del Data Grid View Para editarla");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(dgv_Citas.SelectedRows.Count > 0)
            {
                citas.estado = EstadoEntidad.Deleted;
                citas.Id_cita = Convert.ToInt32(dgv_Citas.CurrentRow.Cells[0].Value);
                string result = citas.GuardarCambios();
                MessageBox.Show(result);
                ListarCitas();
                Restar();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila del Data Grid View Para Eliminarla");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                citas.Fecha = timepicker_Citas.Value.Date;
                citas.Id_paciente_c = Convert.ToString(cmbx_Pacientes.SelectedValue);
                citas.Id_doctor_c = Convert.ToString(cmbx_Doctores.SelectedValue);
                citas.Hora = txt_Hora.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            bool valid = new Soportes.DatosValidacion(citas).Validado();
            string result = citas.GuardarCambios();
            MessageBox.Show(result);
            ListarCitas();
            Restar();
        }
    }
}
