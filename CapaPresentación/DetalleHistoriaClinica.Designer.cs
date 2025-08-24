namespace CapaPresentación
{
    partial class FrmDetalleHistoriaClinica
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
            lblTituloPaciente = new Label();
            lblTituloDiagnostico = new Label();
            lblTituloDescripcion = new Label();
            lblPaciente = new Label();
            lblDiagnostico = new Label();
            rtfObservaciones = new RichTextBox();
            SuspendLayout();
            // 
            // lblTituloPaciente
            // 
            lblTituloPaciente.AutoSize = true;
            lblTituloPaciente.Font = new Font("Microsoft YaHei", 9.75F);
            lblTituloPaciente.Location = new Point(158, 42);
            lblTituloPaciente.Name = "lblTituloPaciente";
            lblTituloPaciente.Size = new Size(61, 19);
            lblTituloPaciente.TabIndex = 0;
            lblTituloPaciente.Text = "Paciente";
            // 
            // lblTituloDiagnostico
            // 
            lblTituloDiagnostico.AutoSize = true;
            lblTituloDiagnostico.Font = new Font("Microsoft YaHei", 9.75F);
            lblTituloDiagnostico.Location = new Point(157, 102);
            lblTituloDiagnostico.Name = "lblTituloDiagnostico";
            lblTituloDiagnostico.Size = new Size(94, 19);
            lblTituloDiagnostico.TabIndex = 1;
            lblTituloDiagnostico.Text = "Diagnóstico/s";
            // 
            // lblTituloDescripcion
            // 
            lblTituloDescripcion.AutoSize = true;
            lblTituloDescripcion.Font = new Font("Microsoft YaHei", 9.75F);
            lblTituloDescripcion.Location = new Point(157, 168);
            lblTituloDescripcion.Name = "lblTituloDescripcion";
            lblTituloDescripcion.Size = new Size(99, 19);
            lblTituloDescripcion.TabIndex = 2;
            lblTituloDescripcion.Text = "Observaciones";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lblPaciente.Location = new Point(269, 42);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(50, 19);
            lblPaciente.TabIndex = 4;
            lblPaciente.Text = "label1";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lblDiagnostico.Location = new Point(269, 102);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(50, 19);
            lblDiagnostico.TabIndex = 5;
            lblDiagnostico.Text = "label1";
            // 
            // rtfObservaciones
            // 
            rtfObservaciones.BorderStyle = BorderStyle.FixedSingle;
            rtfObservaciones.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtfObservaciones.Location = new Point(158, 190);
            rtfObservaciones.Name = "rtfObservaciones";
            rtfObservaciones.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtfObservaciones.Size = new Size(910, 341);
            rtfObservaciones.TabIndex = 6;
            rtfObservaciones.Text = "";
            // 
            // FrmDetalleHistoriaClinica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1134, 543);
            Controls.Add(rtfObservaciones);
            Controls.Add(lblDiagnostico);
            Controls.Add(lblPaciente);
            Controls.Add(lblTituloDescripcion);
            Controls.Add(lblTituloDiagnostico);
            Controls.Add(lblTituloPaciente);
            Name = "FrmDetalleHistoriaClinica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle Historia Clínica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloPaciente;
        private Label lblTituloDiagnostico;
        private Label lblTituloDescripcion;
        private Label lblPaciente;
        private Label lblDiagnostico;
        private RichTextBox rtfObservaciones;
    }
}