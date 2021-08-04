namespace Presentacion.Formularios
{
    partial class FormHabitaciones
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
            this.components = new System.ComponentModel.Container();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.panel_habitaciones = new System.Windows.Forms.Panel();
            this.cmbx_TipoHabitacion = new System.Windows.Forms.ComboBox();
            this.txt_PrecioHabitacion = new System.Windows.Forms.TextBox();
            this.txt_NumeroHabitacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.dgv_habitaciones = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_habitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(283, 457);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(110, 36);
            this.btn_Eliminar.TabIndex = 19;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 457);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(110, 36);
            this.btn_Agregar.TabIndex = 18;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(147, 457);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(110, 36);
            this.btn_Editar.TabIndex = 17;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // panel_habitaciones
            // 
            this.panel_habitaciones.BackColor = System.Drawing.Color.LightGray;
            this.panel_habitaciones.Controls.Add(this.cmbx_TipoHabitacion);
            this.panel_habitaciones.Controls.Add(this.txt_PrecioHabitacion);
            this.panel_habitaciones.Controls.Add(this.txt_NumeroHabitacion);
            this.panel_habitaciones.Controls.Add(this.label3);
            this.panel_habitaciones.Controls.Add(this.label2);
            this.panel_habitaciones.Controls.Add(this.label1);
            this.panel_habitaciones.Controls.Add(this.btn_Guardar);
            this.panel_habitaciones.Location = new System.Drawing.Point(725, 0);
            this.panel_habitaciones.Name = "panel_habitaciones";
            this.panel_habitaciones.Size = new System.Drawing.Size(283, 507);
            this.panel_habitaciones.TabIndex = 16;
            // 
            // cmbx_TipoHabitacion
            // 
            this.cmbx_TipoHabitacion.FormattingEnabled = true;
            this.cmbx_TipoHabitacion.Location = new System.Drawing.Point(35, 127);
            this.cmbx_TipoHabitacion.Name = "cmbx_TipoHabitacion";
            this.cmbx_TipoHabitacion.Size = new System.Drawing.Size(221, 24);
            this.cmbx_TipoHabitacion.TabIndex = 13;
            // 
            // txt_PrecioHabitacion
            // 
            this.txt_PrecioHabitacion.Location = new System.Drawing.Point(35, 192);
            this.txt_PrecioHabitacion.Name = "txt_PrecioHabitacion";
            this.txt_PrecioHabitacion.Size = new System.Drawing.Size(221, 22);
            this.txt_PrecioHabitacion.TabIndex = 12;
            // 
            // txt_NumeroHabitacion
            // 
            this.txt_NumeroHabitacion.Location = new System.Drawing.Point(35, 62);
            this.txt_NumeroHabitacion.Name = "txt_NumeroHabitacion";
            this.txt_NumeroHabitacion.Size = new System.Drawing.Size(221, 22);
            this.txt_NumeroHabitacion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio de habitacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de Habitacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero de Habitacion";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(62, 252);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(159, 42);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // dgv_habitaciones
            // 
            this.dgv_habitaciones.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_habitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_habitaciones.Location = new System.Drawing.Point(12, 66);
            this.dgv_habitaciones.Name = "dgv_habitaciones";
            this.dgv_habitaciones.RowHeadersWidth = 51;
            this.dgv_habitaciones.RowTemplate.Height = 24;
            this.dgv_habitaciones.Size = new System.Drawing.Size(690, 385);
            this.dgv_habitaciones.TabIndex = 15;
            // 
            // practica_PatronesDataSet
            // 
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            // 
            // clientesTableAdapter
            // 
            // 
            // FormHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 506);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.panel_habitaciones);
            this.Controls.Add(this.dgv_habitaciones);
            this.Name = "FormHabitaciones";
            this.Text = "FormHabitaciones";
            this.Load += new System.EventHandler(this.FormHabitaciones_Load);
            this.panel_habitaciones.ResumeLayout(false);
            this.panel_habitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Panel panel_habitaciones;
        private System.Windows.Forms.ComboBox cmbx_TipoHabitacion;
        private System.Windows.Forms.TextBox txt_PrecioHabitacion;
        private System.Windows.Forms.TextBox txt_NumeroHabitacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView dgv_habitaciones;
        private System.Windows.Forms.BindingSource clientesBindingSource;
    }
}