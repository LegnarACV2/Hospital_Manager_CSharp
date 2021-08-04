namespace Presentacion.Formularios
{
    partial class FormAltasMedicas
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
            this.panel_AltasMedicas = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.habitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.panel_altasNoEnble = new System.Windows.Forms.Panel();
            this.txt_Habitaciones = new System.Windows.Forms.TextBox();
            this.txt_Pacientes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ingreso_Id = new System.Windows.Forms.TextBox();
            this.timepicker_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_AltasMedicas = new System.Windows.Forms.DataGridView();
            this.btn_recuperar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataSetPrincipal = new Presentacion.Formularios.DataSetPrincipal();
            this.dataSetPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOSPITALDataSet = new Presentacion.HOSPITALDataSet();
            this.habitacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.habitacionesTableAdapter = new Presentacion.HOSPITALDataSetTableAdapters.HabitacionesTableAdapter();
            this.panel_AltasMedicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource)).BeginInit();
            this.panel_altasNoEnble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AltasMedicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_AltasMedicas
            // 
            this.panel_AltasMedicas.BackColor = System.Drawing.Color.LightGray;
            this.panel_AltasMedicas.Controls.Add(this.comboBox1);
            this.panel_AltasMedicas.Controls.Add(this.label8);
            this.panel_AltasMedicas.Controls.Add(this.dateTimePicker1);
            this.panel_AltasMedicas.Controls.Add(this.label5);
            this.panel_AltasMedicas.Controls.Add(this.button1);
            this.panel_AltasMedicas.Location = new System.Drawing.Point(832, 246);
            this.panel_AltasMedicas.Name = "panel_AltasMedicas";
            this.panel_AltasMedicas.Size = new System.Drawing.Size(289, 285);
            this.panel_AltasMedicas.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.habitacionesBindingSource1;
            this.comboBox1.DisplayMember = "Precio";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.ValueMember = "Precio";
            // 
            // habitacionesBindingSource
            // 
            this.habitacionesBindingSource.DataMember = "Habitaciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Precio Habitacion";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 32);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Salida";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(128, 24);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(110, 53);
            this.btn_Eliminar.TabIndex = 28;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 24);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(110, 53);
            this.btn_Agregar.TabIndex = 27;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(244, 24);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(110, 53);
            this.btn_Editar.TabIndex = 26;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // panel_altasNoEnble
            // 
            this.panel_altasNoEnble.BackColor = System.Drawing.Color.LightGray;
            this.panel_altasNoEnble.Controls.Add(this.txt_Habitaciones);
            this.panel_altasNoEnble.Controls.Add(this.txt_Pacientes);
            this.panel_altasNoEnble.Controls.Add(this.label7);
            this.panel_altasNoEnble.Controls.Add(this.label4);
            this.panel_altasNoEnble.Controls.Add(this.txt_Ingreso_Id);
            this.panel_altasNoEnble.Controls.Add(this.timepicker_fecha_inicio);
            this.panel_altasNoEnble.Controls.Add(this.label2);
            this.panel_altasNoEnble.Controls.Add(this.label1);
            this.panel_altasNoEnble.Location = new System.Drawing.Point(832, 2);
            this.panel_altasNoEnble.Name = "panel_altasNoEnble";
            this.panel_altasNoEnble.Size = new System.Drawing.Size(289, 270);
            this.panel_altasNoEnble.TabIndex = 24;
            // 
            // txt_Habitaciones
            // 
            this.txt_Habitaciones.Location = new System.Drawing.Point(13, 189);
            this.txt_Habitaciones.Name = "txt_Habitaciones";
            this.txt_Habitaciones.Size = new System.Drawing.Size(251, 22);
            this.txt_Habitaciones.TabIndex = 22;
            // 
            // txt_Pacientes
            // 
            this.txt_Pacientes.Location = new System.Drawing.Point(13, 135);
            this.txt_Pacientes.Name = "txt_Pacientes";
            this.txt_Pacientes.Size = new System.Drawing.Size(252, 22);
            this.txt_Pacientes.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Id Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Habitacion Ingreso";
            // 
            // txt_Ingreso_Id
            // 
            this.txt_Ingreso_Id.Location = new System.Drawing.Point(13, 37);
            this.txt_Ingreso_Id.Name = "txt_Ingreso_Id";
            this.txt_Ingreso_Id.Size = new System.Drawing.Size(100, 22);
            this.txt_Ingreso_Id.TabIndex = 18;
            // 
            // timepicker_fecha_inicio
            // 
            this.timepicker_fecha_inicio.Location = new System.Drawing.Point(13, 82);
            this.timepicker_fecha_inicio.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.timepicker_fecha_inicio.MinDate = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.timepicker_fecha_inicio.Name = "timepicker_fecha_inicio";
            this.timepicker_fecha_inicio.Size = new System.Drawing.Size(252, 22);
            this.timepicker_fecha_inicio.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha Ingreso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Paciente Ingresado";
            // 
            // dgv_AltasMedicas
            // 
            this.dgv_AltasMedicas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_AltasMedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AltasMedicas.Location = new System.Drawing.Point(12, 89);
            this.dgv_AltasMedicas.Name = "dgv_AltasMedicas";
            this.dgv_AltasMedicas.RowHeadersWidth = 51;
            this.dgv_AltasMedicas.RowTemplate.Height = 24;
            this.dgv_AltasMedicas.Size = new System.Drawing.Size(814, 440);
            this.dgv_AltasMedicas.TabIndex = 23;
            // 
            // btn_recuperar
            // 
            this.btn_recuperar.Location = new System.Drawing.Point(360, 54);
            this.btn_recuperar.Name = "btn_recuperar";
            this.btn_recuperar.Size = new System.Drawing.Size(149, 23);
            this.btn_recuperar.TabIndex = 29;
            this.btn_recuperar.Text = "Recuperar Ingreso";
            this.btn_recuperar.UseVisualStyleBackColor = true;
            this.btn_recuperar.Click += new System.EventHandler(this.btn_recuperar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Mostrar Dados Altas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataSetPrincipal
            // 
            this.dataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetPrincipalBindingSource
            // 
            this.dataSetPrincipalBindingSource.DataSource = this.dataSetPrincipal;
            this.dataSetPrincipalBindingSource.Position = 0;
            // 
            // hOSPITALDataSet
            // 
            this.hOSPITALDataSet.DataSetName = "HOSPITALDataSet";
            this.hOSPITALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habitacionesBindingSource1
            // 
            this.habitacionesBindingSource1.DataMember = "Habitaciones";
            this.habitacionesBindingSource1.DataSource = this.hOSPITALDataSet;
            // 
            // habitacionesTableAdapter
            // 
            this.habitacionesTableAdapter.ClearBeforeFill = true;
            // 
            // FormAltasMedicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 531);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_recuperar);
            this.Controls.Add(this.panel_AltasMedicas);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.panel_altasNoEnble);
            this.Controls.Add(this.dgv_AltasMedicas);
            this.Name = "FormAltasMedicas";
            this.Text = "FormAltasMedicas";
            this.Load += new System.EventHandler(this.FormAltasMedicas_Load);
            this.panel_AltasMedicas.ResumeLayout(false);
            this.panel_AltasMedicas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource)).EndInit();
            this.panel_altasNoEnble.ResumeLayout(false);
            this.panel_altasNoEnble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AltasMedicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_AltasMedicas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Panel panel_altasNoEnble;
        private System.Windows.Forms.DateTimePicker timepicker_fecha_inicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_AltasMedicas;
        private System.Windows.Forms.Button btn_recuperar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Ingreso_Id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Habitaciones;
        private System.Windows.Forms.TextBox txt_Pacientes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource habitacionesBindingSource;
        private System.Windows.Forms.BindingSource dataSetPrincipalBindingSource;
        private DataSetPrincipal dataSetPrincipal;
        private HOSPITALDataSet hOSPITALDataSet;
        private System.Windows.Forms.BindingSource habitacionesBindingSource1;
        private HOSPITALDataSetTableAdapters.HabitacionesTableAdapter habitacionesTableAdapter;
    }
}