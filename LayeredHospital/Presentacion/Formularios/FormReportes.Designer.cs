namespace Presentacion.Formularios
{
    partial class FormReportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Pacientes_report = new System.Windows.Forms.Button();
            this.btn_doctores_report = new System.Windows.Forms.Button();
            this.btn_habitaciones_report = new System.Windows.Forms.Button();
            this.btn_citas_report = new System.Windows.Forms.Button();
            this.btn_ingresos_report = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTES";
            // 
            // btn_Pacientes_report
            // 
            this.btn_Pacientes_report.Location = new System.Drawing.Point(135, 110);
            this.btn_Pacientes_report.Name = "btn_Pacientes_report";
            this.btn_Pacientes_report.Size = new System.Drawing.Size(130, 50);
            this.btn_Pacientes_report.TabIndex = 4;
            this.btn_Pacientes_report.Text = "Todos los pacientes";
            this.btn_Pacientes_report.UseVisualStyleBackColor = true;
            this.btn_Pacientes_report.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_doctores_report
            // 
            this.btn_doctores_report.Location = new System.Drawing.Point(135, 193);
            this.btn_doctores_report.Name = "btn_doctores_report";
            this.btn_doctores_report.Size = new System.Drawing.Size(130, 50);
            this.btn_doctores_report.TabIndex = 8;
            this.btn_doctores_report.Text = "Todos los Doctores";
            this.btn_doctores_report.UseVisualStyleBackColor = true;
            this.btn_doctores_report.Click += new System.EventHandler(this.btn_doctores_report_Click);
            // 
            // btn_habitaciones_report
            // 
            this.btn_habitaciones_report.Location = new System.Drawing.Point(135, 293);
            this.btn_habitaciones_report.Name = "btn_habitaciones_report";
            this.btn_habitaciones_report.Size = new System.Drawing.Size(130, 50);
            this.btn_habitaciones_report.TabIndex = 11;
            this.btn_habitaciones_report.Text = "Todos las habitaciones";
            this.btn_habitaciones_report.UseVisualStyleBackColor = true;
            this.btn_habitaciones_report.Click += new System.EventHandler(this.btn_habitaciones_report_Click);
            // 
            // btn_citas_report
            // 
            this.btn_citas_report.Location = new System.Drawing.Point(135, 390);
            this.btn_citas_report.Name = "btn_citas_report";
            this.btn_citas_report.Size = new System.Drawing.Size(130, 50);
            this.btn_citas_report.TabIndex = 3;
            this.btn_citas_report.Text = "Todas las Citas";
            this.btn_citas_report.UseVisualStyleBackColor = true;
            this.btn_citas_report.Click += new System.EventHandler(this.btn_citas_report_Click);
            // 
            // btn_ingresos_report
            // 
            this.btn_ingresos_report.Location = new System.Drawing.Point(135, 488);
            this.btn_ingresos_report.Name = "btn_ingresos_report";
            this.btn_ingresos_report.Size = new System.Drawing.Size(130, 50);
            this.btn_ingresos_report.TabIndex = 15;
            this.btn_ingresos_report.Text = "Todos los ingresos";
            this.btn_ingresos_report.UseVisualStyleBackColor = true;
            this.btn_ingresos_report.Click += new System.EventHandler(this.btn_ingresos_report_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Generar Reportes para pacientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Generar Reportes para Doctores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Generar Reportes para Habitaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Generar Reportes para las Citas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Generar Reportes para los ingresos";
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(439, 568);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ingresos_report);
            this.Controls.Add(this.btn_habitaciones_report);
            this.Controls.Add(this.btn_doctores_report);
            this.Controls.Add(this.btn_Pacientes_report);
            this.Controls.Add(this.btn_citas_report);
            this.Controls.Add(this.label1);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Pacientes_report;
        private System.Windows.Forms.Button btn_doctores_report;
        private System.Windows.Forms.Button btn_habitaciones_report;
        private System.Windows.Forms.Button btn_citas_report;
        private System.Windows.Forms.Button btn_ingresos_report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}