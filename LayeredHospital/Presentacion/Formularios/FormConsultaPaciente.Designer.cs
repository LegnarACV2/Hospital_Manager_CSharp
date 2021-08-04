namespace Presentacion.Formularios
{
    partial class FormConsultaPaciente
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
            this.dgv_ConsultaPaciente = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbx_condultapaciente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultaPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ConsultaPaciente
            // 
            this.dgv_ConsultaPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ConsultaPaciente.Location = new System.Drawing.Point(12, 86);
            this.dgv_ConsultaPaciente.Name = "dgv_ConsultaPaciente";
            this.dgv_ConsultaPaciente.RowHeadersWidth = 51;
            this.dgv_ConsultaPaciente.RowTemplate.Height = 24;
            this.dgv_ConsultaPaciente.Size = new System.Drawing.Size(776, 311);
            this.dgv_ConsultaPaciente.TabIndex = 0;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(12, 40);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(183, 22);
            this.txt_buscar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbx_condultapaciente
            // 
            this.cmbx_condultapaciente.FormattingEnabled = true;
            this.cmbx_condultapaciente.Location = new System.Drawing.Point(217, 40);
            this.cmbx_condultapaciente.Name = "cmbx_condultapaciente";
            this.cmbx_condultapaciente.Size = new System.Drawing.Size(169, 24);
            this.cmbx_condultapaciente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese Nombre o Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione Filtro ";
            // 
            // FormConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbx_condultapaciente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dgv_ConsultaPaciente);
            this.Name = "FormConsultaPaciente";
            this.Text = "FormConsultaPaciente";
            this.Load += new System.EventHandler(this.FormConsultaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultaPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ConsultaPaciente;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbx_condultapaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}