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
    public partial class FormDoctores : Form
    {
        private ModeloDoctores doctores = new ModeloDoctores();
        public FormDoctores()
        {
            InitializeComponent();
            panel_doctores.Enabled = false;
        }
        public void ListarDoctores()
        {
            try
            {
                dgv_Doctores.DataSource = doctores.GetAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormDoctores_Load(object sender, EventArgs e)
        {
            ListarDoctores();
        }

        private void btb_Buscar_Click(object sender, EventArgs e)
        {
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            dgv_Doctores.DataSource = doctores.BuscarDoctores(txt_Buscar.Text);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            doctores.Nombre = txt_Nombre.Text;
            doctores.Exequatur = txt_Exequatur.Text;
            doctores.Especialidad = txt_Especialidad.Text;

            bool valid = new Soportes.DatosValidacion(doctores).Validado();
            if (valid == true)
            {
                string result = doctores.GuardarCambios();
                MessageBox.Show(result);
                ListarDoctores();
                Restart();
            }
        }

        private void Restart()
        {
            panel_doctores.Enabled = false;
            txt_Nombre.Clear();
            txt_Exequatur.Clear();
            txt_Especialidad.Clear();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            panel_doctores.Enabled = true;
            doctores.estado = EstadoEntidad.Added;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_Doctores.SelectedRows.Count>0)
            {
                panel_doctores.Enabled = true;
                doctores.estado = EstadoEntidad.Modified;
                doctores.Id_Doctor1 = Convert.ToInt32(dgv_Doctores.CurrentRow.Cells[0].Value);
                txt_Nombre.Text = dgv_Doctores.CurrentRow.Cells[1].Value.ToString();
                txt_Exequatur.Text = dgv_Doctores.CurrentRow.Cells[2].Value.ToString();
                txt_Especialidad.Text = dgv_Doctores.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila del DataGridView para Editarla");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Doctores.SelectedRows.Count > 0)
            {
                doctores.estado = EstadoEntidad.Deleted;
                doctores.Id_Doctor1 = Convert.ToInt32(dgv_Doctores.CurrentRow.Cells[0].Value);
                string result = doctores.GuardarCambios();
                MessageBox.Show(result);
                ListarDoctores();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila del DataGridView para Eliminar");
            }
        }
    }
}
