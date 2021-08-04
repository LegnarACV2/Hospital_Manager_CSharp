namespace Presentacion.Formularios
{
    partial class FormCitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.panel_citas = new System.Windows.Forms.Panel();
            this.cmbx_Pacientes = new System.Windows.Forms.ComboBox();
            this.cmbx_Doctores = new System.Windows.Forms.ComboBox();
            this.timepicker_Citas = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Hora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Citas = new System.Windows.Forms.DataGridView();
            this.panel_citas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Citas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(145, 12);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(110, 36);
            this.btn_Eliminar.TabIndex = 12;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(29, 12);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(110, 36);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(29, 53);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(110, 36);
            this.btn_Editar.TabIndex = 10;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // panel_citas
            // 
            this.panel_citas.BackColor = System.Drawing.Color.LightGray;
            this.panel_citas.Controls.Add(this.cmbx_Pacientes);
            this.panel_citas.Controls.Add(this.cmbx_Doctores);
            this.panel_citas.Controls.Add(this.timepicker_Citas);
            this.panel_citas.Controls.Add(this.label4);
            this.panel_citas.Controls.Add(this.label3);
            this.panel_citas.Controls.Add(this.txt_Hora);
            this.panel_citas.Controls.Add(this.label2);
            this.panel_citas.Controls.Add(this.btn_Guardar);
            this.panel_citas.Controls.Add(this.label1);
            this.panel_citas.Location = new System.Drawing.Point(725, -2);
            this.panel_citas.Name = "panel_citas";
            this.panel_citas.Size = new System.Drawing.Size(289, 485);
            this.panel_citas.TabIndex = 9;
            // 
            // cmbx_Pacientes
            // 
            this.cmbx_Pacientes.FormattingEnabled = true;
            this.cmbx_Pacientes.Location = new System.Drawing.Point(15, 169);
            this.cmbx_Pacientes.Name = "cmbx_Pacientes";
            this.cmbx_Pacientes.Size = new System.Drawing.Size(252, 24);
            this.cmbx_Pacientes.TabIndex = 17;
            // 
            // cmbx_Doctores
            // 
            this.cmbx_Doctores.FormattingEnabled = true;
            this.cmbx_Doctores.Location = new System.Drawing.Point(15, 110);
            this.cmbx_Doctores.Name = "cmbx_Doctores";
            this.cmbx_Doctores.Size = new System.Drawing.Size(252, 24);
            this.cmbx_Doctores.TabIndex = 16;
            // 
            // timepicker_Citas
            // 
            this.timepicker_Citas.Location = new System.Drawing.Point(15, 55);
            this.timepicker_Citas.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.timepicker_Citas.MinDate = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.timepicker_Citas.Name = "timepicker_Citas";
            this.timepicker_Citas.Size = new System.Drawing.Size(252, 22);
            this.timepicker_Citas.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hora";
            // 
            // txt_Hora
            // 
            this.txt_Hora.Location = new System.Drawing.Point(15, 225);
            this.txt_Hora.Name = "txt_Hora";
            this.txt_Hora.Size = new System.Drawing.Size(74, 22);
            this.txt_Hora.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(157, 218);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(110, 37);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Paciente";
            // 
            // dgv_Citas
            // 
            this.dgv_Citas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Citas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Citas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Citas.Location = new System.Drawing.Point(29, 100);
            this.dgv_Citas.MultiSelect = false;
            this.dgv_Citas.Name = "dgv_Citas";
            this.dgv_Citas.ReadOnly = true;
            this.dgv_Citas.RowHeadersWidth = 51;
            this.dgv_Citas.RowTemplate.Height = 24;
            this.dgv_Citas.Size = new System.Drawing.Size(690, 371);
            this.dgv_Citas.TabIndex = 8;
            // 
            // FormCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 483);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.panel_citas);
            this.Controls.Add(this.dgv_Citas);
            this.Name = "FormCitas";
            this.Text = "FormCitas";
            this.Load += new System.EventHandler(this.FormCitas_Load);
            this.panel_citas.ResumeLayout(false);
            this.panel_citas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Citas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Panel panel_citas;
        private System.Windows.Forms.ComboBox cmbx_Pacientes;
        private System.Windows.Forms.ComboBox cmbx_Doctores;
        private System.Windows.Forms.DateTimePicker timepicker_Citas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Hora;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Citas;
        private System.Windows.Forms.Label label2;
    }
}