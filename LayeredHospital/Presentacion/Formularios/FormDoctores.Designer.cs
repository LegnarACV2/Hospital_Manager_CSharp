namespace Presentacion.Formularios
{
    partial class FormDoctores
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
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.dgv_Doctores = new System.Windows.Forms.DataGridView();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Especialidad = new System.Windows.Forms.TextBox();
            this.txt_Exequatur = new System.Windows.Forms.TextBox();
            this.panel_doctores = new System.Windows.Forms.Panel();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btb_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doctores)).BeginInit();
            this.panel_doctores.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(12, 12);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(586, 22);
            this.txt_Buscar.TabIndex = 0;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // dgv_Doctores
            // 
            this.dgv_Doctores.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_Doctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Doctores.Location = new System.Drawing.Point(12, 54);
            this.dgv_Doctores.Name = "dgv_Doctores";
            this.dgv_Doctores.RowHeadersWidth = 51;
            this.dgv_Doctores.RowTemplate.Height = 24;
            this.dgv_Doctores.Size = new System.Drawing.Size(690, 371);
            this.dgv_Doctores.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Exequatur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Especialidad";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(35, 62);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(221, 22);
            this.txt_Nombre.TabIndex = 10;
            // 
            // txt_Especialidad
            // 
            this.txt_Especialidad.Location = new System.Drawing.Point(35, 192);
            this.txt_Especialidad.Name = "txt_Especialidad";
            this.txt_Especialidad.Size = new System.Drawing.Size(221, 22);
            this.txt_Especialidad.TabIndex = 11;
            // 
            // txt_Exequatur
            // 
            this.txt_Exequatur.Location = new System.Drawing.Point(35, 127);
            this.txt_Exequatur.Name = "txt_Exequatur";
            this.txt_Exequatur.Size = new System.Drawing.Size(221, 22);
            this.txt_Exequatur.TabIndex = 12;
            // 
            // panel_doctores
            // 
            this.panel_doctores.BackColor = System.Drawing.Color.LightGray;
            this.panel_doctores.Controls.Add(this.txt_Exequatur);
            this.panel_doctores.Controls.Add(this.txt_Especialidad);
            this.panel_doctores.Controls.Add(this.txt_Nombre);
            this.panel_doctores.Controls.Add(this.label3);
            this.panel_doctores.Controls.Add(this.label2);
            this.panel_doctores.Controls.Add(this.label1);
            this.panel_doctores.Controls.Add(this.btn_Guardar);
            this.panel_doctores.Location = new System.Drawing.Point(725, -2);
            this.panel_doctores.Name = "panel_doctores";
            this.panel_doctores.Size = new System.Drawing.Size(283, 485);
            this.panel_doctores.TabIndex = 2;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(151, 431);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(110, 36);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 431);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(110, 36);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(284, 431);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(110, 36);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btb_Buscar
            // 
            this.btb_Buscar.Location = new System.Drawing.Point(609, 5);
            this.btb_Buscar.Name = "btb_Buscar";
            this.btb_Buscar.Size = new System.Drawing.Size(110, 36);
            this.btb_Buscar.TabIndex = 6;
            this.btb_Buscar.Text = "Buscar";
            this.btb_Buscar.UseVisualStyleBackColor = true;
            this.btb_Buscar.Click += new System.EventHandler(this.btb_Buscar_Click);
            // 
            // FormDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1002, 479);
            this.Controls.Add(this.btb_Buscar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.panel_doctores);
            this.Controls.Add(this.dgv_Doctores);
            this.Controls.Add(this.txt_Buscar);
            this.Name = "FormDoctores";
            this.Text = "FormDoctores";
            this.Load += new System.EventHandler(this.FormDoctores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doctores)).EndInit();
            this.panel_doctores.ResumeLayout(false);
            this.panel_doctores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.DataGridView dgv_Doctores;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Especialidad;
        private System.Windows.Forms.TextBox txt_Exequatur;
        private System.Windows.Forms.Panel panel_doctores;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btb_Buscar;
    }
}