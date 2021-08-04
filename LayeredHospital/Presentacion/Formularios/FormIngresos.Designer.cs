namespace Presentacion.Formularios
{
    partial class FormIngresos
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
            this.panel_ingresos = new System.Windows.Forms.Panel();
            this.cmbx_Pacientes = new System.Windows.Forms.ComboBox();
            this.cmbx_habitaciones = new System.Windows.Forms.ComboBox();
            this.timepicker_Ingresos = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Ingresos = new System.Windows.Forms.DataGridView();
            this.panel_ingresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ingresos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(128, 14);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(110, 36);
            this.btn_Eliminar.TabIndex = 17;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 14);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(110, 36);
            this.btn_Agregar.TabIndex = 16;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(244, 14);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(110, 36);
            this.btn_Editar.TabIndex = 15;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // panel_ingresos
            // 
            this.panel_ingresos.BackColor = System.Drawing.Color.LightGray;
            this.panel_ingresos.Controls.Add(this.cmbx_Pacientes);
            this.panel_ingresos.Controls.Add(this.cmbx_habitaciones);
            this.panel_ingresos.Controls.Add(this.timepicker_Ingresos);
            this.panel_ingresos.Controls.Add(this.label4);
            this.panel_ingresos.Controls.Add(this.label2);
            this.panel_ingresos.Controls.Add(this.btn_Guardar);
            this.panel_ingresos.Controls.Add(this.label1);
            this.panel_ingresos.Location = new System.Drawing.Point(708, 0);
            this.panel_ingresos.Name = "panel_ingresos";
            this.panel_ingresos.Size = new System.Drawing.Size(289, 485);
            this.panel_ingresos.TabIndex = 14;
            // 
            // cmbx_Pacientes
            // 
            this.cmbx_Pacientes.FormattingEnabled = true;
            this.cmbx_Pacientes.Location = new System.Drawing.Point(18, 130);
            this.cmbx_Pacientes.Name = "cmbx_Pacientes";
            this.cmbx_Pacientes.Size = new System.Drawing.Size(252, 24);
            this.cmbx_Pacientes.TabIndex = 17;
            // 
            // cmbx_habitaciones
            // 
            this.cmbx_habitaciones.FormattingEnabled = true;
            this.cmbx_habitaciones.Location = new System.Drawing.Point(18, 177);
            this.cmbx_habitaciones.Name = "cmbx_habitaciones";
            this.cmbx_habitaciones.Size = new System.Drawing.Size(252, 24);
            this.cmbx_habitaciones.TabIndex = 16;
            // 
            // timepicker_Ingresos
            // 
            this.timepicker_Ingresos.Location = new System.Drawing.Point(18, 231);
            this.timepicker_Ingresos.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.timepicker_Ingresos.MinDate = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.timepicker_Ingresos.Name = "timepicker_Ingresos";
            this.timepicker_Ingresos.Size = new System.Drawing.Size(252, 22);
            this.timepicker_Ingresos.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Habitacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(88, 283);
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
            this.label1.Location = new System.Drawing.Point(15, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Paciente";
            // 
            // dgv_Ingresos
            // 
            this.dgv_Ingresos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_Ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ingresos.Location = new System.Drawing.Point(12, 78);
            this.dgv_Ingresos.Name = "dgv_Ingresos";
            this.dgv_Ingresos.RowHeadersWidth = 51;
            this.dgv_Ingresos.RowTemplate.Height = 24;
            this.dgv_Ingresos.Size = new System.Drawing.Size(690, 403);
            this.dgv_Ingresos.TabIndex = 13;
            // 
            // FormIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 483);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.panel_ingresos);
            this.Controls.Add(this.dgv_Ingresos);
            this.Name = "FormIngresos";
            this.Text = "FormIngresos";
            this.Load += new System.EventHandler(this.FormIngresos_Load);
            this.panel_ingresos.ResumeLayout(false);
            this.panel_ingresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ingresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Panel panel_ingresos;
        private System.Windows.Forms.ComboBox cmbx_Pacientes;
        private System.Windows.Forms.ComboBox cmbx_habitaciones;
        private System.Windows.Forms.DateTimePicker timepicker_Ingresos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Ingresos;
    }
}