namespace CapaPresentación
{
    partial class frmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            pictureBox1 = new PictureBox();
            lblTituloVersion = new Label();
            lblVersion = new Label();
            lblTituloDesarrollador = new Label();
            lblDesarrollador = new Label();
            lblAcercaDe = new Label();
            mnsNavegación = new MenuStrip();
            tsrSalir = new ToolStripMenuItem();
            lblCopyright = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mnsNavegación.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTituloVersion
            // 
            lblTituloVersion.AutoSize = true;
            lblTituloVersion.Font = new Font("Microsoft YaHei", 11.25F);
            lblTituloVersion.Location = new Point(173, 145);
            lblTituloVersion.Name = "lblTituloVersion";
            lblTituloVersion.Size = new Size(118, 20);
            lblTituloVersion.TabIndex = 1;
            lblTituloVersion.Text = "Versión Actual:";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = Color.White;
            lblVersion.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            lblVersion.Location = new Point(288, 146);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(78, 19);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "-version-";
            // 
            // lblTituloDesarrollador
            // 
            lblTituloDesarrollador.AutoSize = true;
            lblTituloDesarrollador.Font = new Font("Microsoft YaHei", 11.25F);
            lblTituloDesarrollador.Location = new Point(171, 189);
            lblTituloDesarrollador.Name = "lblTituloDesarrollador";
            lblTituloDesarrollador.Size = new Size(136, 20);
            lblTituloDesarrollador.TabIndex = 3;
            lblTituloDesarrollador.Text = "Desarrollado por:";
            // 
            // lblDesarrollador
            // 
            lblDesarrollador.AutoSize = true;
            lblDesarrollador.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            lblDesarrollador.Location = new Point(303, 190);
            lblDesarrollador.Name = "lblDesarrollador";
            lblDesarrollador.Size = new Size(123, 19);
            lblDesarrollador.TabIndex = 4;
            lblDesarrollador.Text = "-desarrollador-";
            // 
            // lblAcercaDe
            // 
            lblAcercaDe.AutoSize = true;
            lblAcercaDe.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAcercaDe.Location = new Point(195, 69);
            lblAcercaDe.Name = "lblAcercaDe";
            lblAcercaDe.Size = new Size(231, 31);
            lblAcercaDe.TabIndex = 5;
            lblAcercaDe.Text = "Acerca de NutriSys";
            // 
            // mnsNavegación
            // 
            mnsNavegación.BackColor = Color.FromArgb(16, 157, 115);
            mnsNavegación.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnsNavegación.Items.AddRange(new ToolStripItem[] { tsrSalir });
            mnsNavegación.Location = new Point(0, 0);
            mnsNavegación.Name = "mnsNavegación";
            mnsNavegación.Padding = new Padding(10);
            mnsNavegación.Size = new Size(614, 56);
            mnsNavegación.TabIndex = 6;
            mnsNavegación.Text = "menuStrip1";
            // 
            // tsrSalir
            // 
            tsrSalir.Alignment = ToolStripItemAlignment.Right;
            tsrSalir.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsrSalir.Image = (Image)resources.GetObject("tsrSalir.Image");
            tsrSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsrSalir.Name = "tsrSalir";
            tsrSalir.Size = new Size(44, 36);
            tsrSalir.Tag = "";
            tsrSalir.ToolTipText = "Salir";
            tsrSalir.Click += tsrSalir_Click;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Microsoft YaHei Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCopyright.Location = new Point(161, 254);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(289, 17);
            lblCopyright.TabIndex = 7;
            lblCopyright.Text = "Copyright © 2025. Todos los derechos reservados";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 157, 115);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 277);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 3);
            panel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 157, 115);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 221);
            panel3.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 157, 115);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(611, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 221);
            panel2.TabIndex = 10;
            // 
            // frmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(614, 280);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(lblCopyright);
            Controls.Add(mnsNavegación);
            Controls.Add(lblAcercaDe);
            Controls.Add(lblDesarrollador);
            Controls.Add(lblTituloDesarrollador);
            Controls.Add(lblVersion);
            Controls.Add(lblTituloVersion);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAcercaDe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerca De";
            Load += AcercaDe_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mnsNavegación.ResumeLayout(false);
            mnsNavegación.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTituloVersion;
        private Label lblVersion;
        private Label lblTituloDesarrollador;
        private Label lblDesarrollador;
        private Label lblAcercaDe;
        private MenuStrip mnsNavegación;
        private ToolStripMenuItem tsrSalir;
        private Label lblCopyright;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
    }
}