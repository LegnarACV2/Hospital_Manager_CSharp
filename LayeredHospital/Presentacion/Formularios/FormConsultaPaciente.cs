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
    public partial class FormConsultaPaciente : Form
    {
        public FormConsultaPaciente()
        {
            InitializeComponent();
        }

        private void FormConsultaPaciente_Load(object sender, EventArgs e)
        {
            var datasource = new List<Asegurado>();
            datasource.Add(new Asegurado() { Name = "Asegurado", Value = "Asegurado" });
            datasource.Add(new Asegurado() { Name = "No Asegurado", Value = "No Asegurado" });

            this.cmbx_condultapaciente.DataSource = datasource;
            this.cmbx_condultapaciente.DisplayMember = "Name";
            this.cmbx_condultapaciente.ValueMember = "Value";
        }
    }
}
