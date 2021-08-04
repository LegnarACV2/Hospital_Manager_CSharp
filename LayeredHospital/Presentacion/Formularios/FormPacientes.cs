using Presentacion.Soportes;
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
    public partial class FormPacientes : Form
    {
        private ModeloPacientes pacientes = new ModeloPacientes();
        public FormPacientes()
        {
            InitializeComponent();
            panel_pacientes.Enabled = false;
        }

        private void ListarPacientes()
        {
            try
            {
                dgv_Pacientes.DataSource = pacientes.GetAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void FormPacientes_Load(object sender, EventArgs e)
        {
            ListarPacientes();

            var datasource = new List<Asegurado>();
            datasource.Add(new Asegurado() { Name = "Asegurado", Value = "Asegurado" });
            datasource.Add(new Asegurado() { Name = "No Asegurado", Value = "No Asegurado" });

            this.cmbx_SeguroMedico.DataSource = datasource;
            this.cmbx_SeguroMedico.DisplayMember = "Name";
            this.cmbx_SeguroMedico.ValueMember = "Value";

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            panel_pacientes.Enabled = true;
            pacientes.estado = EstadoEntidad.Added;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_Pacientes.SelectedRows.Count > 0)
            {
                panel_pacientes.Enabled = true;
                pacientes.estado = EstadoEntidad.Modified;
                pacientes.Id_Paciente = Convert.ToInt32(dgv_Pacientes.CurrentRow.Cells[0].Value);
                txt_Cedula.Text = dgv_Pacientes.CurrentRow.Cells[1].Value.ToString();
                txt_Nombre.Text = dgv_Pacientes.CurrentRow.Cells[2].Value.ToString();
                cmbx_SeguroMedico.Text = dgv_Pacientes.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila del DataGridView Para editarla");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Pacientes.SelectedRows.Count > 0)
            {
                pacientes.estado = EstadoEntidad.Deleted;
                pacientes.Id_Paciente = Convert.ToInt32(dgv_Pacientes.CurrentRow.Cells[0].Value);
                string result = pacientes.GuardarCambios();
                MessageBox.Show(result);
                ListarPacientes();
                Restar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila del DataGridView Para Eliminarla");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            pacientes.Cedula = txt_Cedula.Text;
            pacientes.Nombre = txt_Nombre.Text;
            pacientes.Asegurado = cmbx_SeguroMedico.Text;

            bool valid = new Soportes.DatosValidacion(pacientes).Validado();
            if (valid == true)
            {
                string result = pacientes.GuardarCambios();
                MessageBox.Show(result);
                ListarPacientes();
                Restar();
                
            }
        }

        private void Restar()
        {
            panel_pacientes.Enabled = false;
            txt_Cedula.Clear();
            txt_Nombre.Clear();
        }
    }
}
