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
using Presentacion.Soportes;

namespace Presentacion.Formularios
{
    public partial class FormHabitaciones : Form
    {
        private ModeloHabitaciones habitaciones = new ModeloHabitaciones();
        public FormHabitaciones()
        {
            InitializeComponent();
            panel_habitaciones.Enabled = false;
        }

        private void ListarHabitaciones()
        {
            try
            {
                dgv_habitaciones.DataSource = habitaciones.GetAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormHabitaciones_Load(object sender, EventArgs e)
        {
            ListarHabitaciones();

            var datasource = new List<Asegurado>();
            datasource.Add(new Asegurado() { Name = "Doble", Value = "Doble" });
            datasource.Add(new Asegurado() { Name = "Privada", Value = "Privada" });
            datasource.Add(new Asegurado() { Name = "Suit", Value = "Suit" });

            this.cmbx_TipoHabitacion.DataSource = datasource;
            this.cmbx_TipoHabitacion.DisplayMember = "Name";
            this.cmbx_TipoHabitacion.ValueMember = "Value";
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            panel_habitaciones.Enabled = true;
            habitaciones.estado = EstadoEntidad.Added;
        }
        private void Restart()
        {
            panel_habitaciones.Enabled = false;
            txt_NumeroHabitacion.Clear();
            txt_PrecioHabitacion.Clear();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_habitaciones.SelectedRows.Count>0)
            {
                panel_habitaciones.Enabled = true;
                habitaciones.estado = EstadoEntidad.Modified;
                habitaciones.Id_Habitacion = Convert.ToInt32(dgv_habitaciones.CurrentRow.Cells[0].Value);
                txt_NumeroHabitacion.Text = dgv_habitaciones.CurrentRow.Cells[1].Value.ToString();
                cmbx_TipoHabitacion.Text = dgv_habitaciones.CurrentRow.Cells[2].Value.ToString();
                txt_PrecioHabitacion.Text = dgv_habitaciones.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila del DataGridView para modificar");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_habitaciones.SelectedRows.Count > 0)
            {
                habitaciones.estado = EstadoEntidad.Deleted;
                habitaciones.Id_Habitacion = Convert.ToInt32(dgv_habitaciones.CurrentRow.Cells[0].Value);
                string result = habitaciones.GuardarCambios();
                MessageBox.Show(result);
                ListarHabitaciones();
                Restart();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila del DataGridView para modificar");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                habitaciones.Numero = txt_NumeroHabitacion.Text;
                habitaciones.Tipo = cmbx_TipoHabitacion.Text;
                habitaciones.Precio = Convert.ToDouble(txt_PrecioHabitacion.Text);

                bool valid = new Soportes.DatosValidacion(habitaciones).Validado();
                if (valid == true)
                {
                    string result = habitaciones.GuardarCambios();
                    MessageBox.Show(result);
                    ListarHabitaciones();
                    Restart();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("El Campo Precio no puede contener letras, ni quedar vacio");
            }
           

           
        }
    }
}
