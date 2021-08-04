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
    public partial class FormAltasMedicas : Form
    {
        private ModeloAltas altas = new ModeloAltas();
        public FormAltasMedicas()
        {
            InitializeComponent();
            panel_altasNoEnble.Enabled = false;
            panel_AltasMedicas.Enabled = false;
        }
        private void ListarAltas()
        {
            try
            {
                dgv_AltasMedicas.DataSource = altas.GetAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormAltasMedicas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hOSPITALDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
            this.habitacionesTableAdapter.Fill(this.hOSPITALDataSet.Habitaciones);
            // TODO: esta línea de código carga datos en la tabla 'hOSPITALDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
            ListarAltas();
        }

        private void btn_recuperar_Click(object sender, EventArgs e)
        {
            ModeloIngresos ingresos = new ModeloIngresos();
            dgv_AltasMedicas.DataSource = ingresos.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv_AltasMedicas.DataSource = altas.GetAll();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_AltasMedicas.SelectedRows.Count > 0)
                {
                    panel_AltasMedicas.Enabled = true;
                    altas.estado = EstadoEntidad.Added;
                    txt_Ingreso_Id.Text = Convert.ToString(dgv_AltasMedicas.CurrentRow.Cells[0].Value);
                    txt_Pacientes.Text = dgv_AltasMedicas.CurrentRow.Cells[1].Value.ToString();
                    txt_Habitaciones.Text = dgv_AltasMedicas.CurrentRow.Cells[2].Value.ToString();
                    timepicker_fecha_inicio.MinDate = Convert.ToDateTime(dgv_AltasMedicas.CurrentRow.Cells[3].Value);

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fial de ingreso para dar de alta");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Debe recuperar un registro de ingresos");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            altas.Id_ingreso_a = Convert.ToInt32(txt_Ingreso_Id.Text);
            altas.Fecha_ingreso = timepicker_fecha_inicio.Value.Date;
            altas.Paciente = txt_Pacientes.Text;
            altas.Habitacion = txt_Habitaciones.Text;
            altas.Id_habitacion = Convert.ToDouble(comboBox1.SelectedIndex);
            altas.Fecha_salidad = dateTimePicker1.Value.Date;

            bool valid = new Soportes.DatosValidacion(altas).Validado();
            if (valid ==  true)
            {
                string result = altas.GuardarCambios();
                MessageBox.Show(result);
                ListarAltas();
                panel_AltasMedicas.Enabled = false;
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_AltasMedicas.SelectedRows.Count > 0)
            {
                altas.estado = EstadoEntidad.Deleted;
                altas.Id_alta = Convert.ToInt32(dgv_AltasMedicas.CurrentRow.Cells[0].Value);
                string result = altas.GuardarCambios();
                MessageBox.Show(result);
                ListarAltas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fial de ingreso para dar de alta");
            }
        }
    }
}
