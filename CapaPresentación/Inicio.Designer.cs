namespace CapaPresentación
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            lblTitulo = new Label();
            picLogoNutriSys = new PictureBox();
            tsrPacientes = new ToolStripMenuItem();
            tsrHistoriasClinicas = new ToolStripMenuItem();
            tsrAntropometria = new ToolStripMenuItem();
            tsrSalir = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            mnsNavegación = new MenuStrip();
            tsrPami = new ToolStripMenuItem();
            tsrMinimizar = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picLogoNutriSys).BeginInit();
            mnsNavegación.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft YaHei", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(324, 86);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(147, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "NutriSys";
            // 
            // picLogoNutriSys
            // 
            picLogoNutriSys.BackColor = Color.Transparent;
            picLogoNutriSys.BackgroundImageLayout = ImageLayout.Stretch;
            picLogoNutriSys.Image = (Image)resources.GetObject("picLogoNutriSys.Image");
            picLogoNutriSys.Location = new Point(273, 130);
            picLogoNutriSys.Name = "picLogoNutriSys";
            picLogoNutriSys.Size = new Size(264, 230);
            picLogoNutriSys.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogoNutriSys.TabIndex = 1;
            picLogoNutriSys.TabStop = false;
            // 
            // tsrPacientes
            // 
            tsrPacientes.Image = Properties.Resources.crowd;
            tsrPacientes.ImageAlign = ContentAlignment.TopCenter;
            tsrPacientes.ImageScaling = ToolStripItemImageScaling.None;
            tsrPacientes.Name = "tsrPacientes";
            tsrPacientes.Size = new Size(79, 55);
            tsrPacientes.Text = "Pacientes";
            tsrPacientes.TextImageRelation = TextImageRelation.ImageAboveText;
            tsrPacientes.Click += tsrPacientes_Click;
            // 
            // tsrHistoriasClinicas
            // 
            tsrHistoriasClinicas.Image = (Image)resources.GetObject("tsrHistoriasClinicas.Image");
            tsrHistoriasClinicas.ImageScaling = ToolStripItemImageScaling.None;
            tsrHistoriasClinicas.Name = "tsrHistoriasClinicas";
            tsrHistoriasClinicas.Size = new Size(124, 55);
            tsrHistoriasClinicas.Text = "Historias Clínicas";
            tsrHistoriasClinicas.TextImageRelation = TextImageRelation.ImageAboveText;
            tsrHistoriasClinicas.Click += tsrHistoriasClinicas_Click;
            // 
            // tsrAntropometria
            // 
            tsrAntropometria.Image = Properties.Resources.body_mass;
            tsrAntropometria.ImageScaling = ToolStripItemImageScaling.None;
            tsrAntropometria.Name = "tsrAntropometria";
            tsrAntropometria.Size = new Size(111, 55);
            tsrAntropometria.Text = "Antropometría";
            tsrAntropometria.TextImageRelation = TextImageRelation.ImageAboveText;
            tsrAntropometria.Click += tsrAntropometria_Click;
            // 
            // tsrSalir
            // 
            tsrSalir.Alignment = ToolStripItemAlignment.Right;
            tsrSalir.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsrSalir.Image = (Image)resources.GetObject("tsrSalir.Image");
            tsrSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsrSalir.Name = "tsrSalir";
            tsrSalir.Size = new Size(44, 55);
            tsrSalir.Tag = "";
            tsrSalir.ToolTipText = "Salir";
            tsrSalir.Click += tsrSalir_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Image = Properties.Resources.info1;
            acercaDeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(84, 55);
            acercaDeToolStripMenuItem.Text = "Acerca De";
            acercaDeToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // mnsNavegación
            // 
            mnsNavegación.BackColor = Color.FromArgb(16, 157, 115);
            mnsNavegación.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnsNavegación.Items.AddRange(new ToolStripItem[] { tsrPacientes, tsrHistoriasClinicas, tsrAntropometria, tsrPami, tsrSalir, acercaDeToolStripMenuItem, tsrMinimizar });
            mnsNavegación.Location = new Point(0, 0);
            mnsNavegación.Name = "mnsNavegación";
            mnsNavegación.Padding = new Padding(10);
            mnsNavegación.Size = new Size(800, 75);
            mnsNavegación.TabIndex = 2;
            mnsNavegación.Text = "menuStrip1";
            // 
            // tsrPami
            // 
            tsrPami.Image = Properties.Resources.retirement_plan;
            tsrPami.ImageScaling = ToolStripItemImageScaling.None;
            tsrPami.Name = "tsrPami";
            tsrPami.Size = new Size(55, 55);
            tsrPami.Text = "PAMI";
            tsrPami.TextImageRelation = TextImageRelation.ImageAboveText;
            tsrPami.Click += tsrPami_Click;
            // 
            // tsrMinimizar
            // 
            tsrMinimizar.Alignment = ToolStripItemAlignment.Right;
            tsrMinimizar.Image = Properties.Resources.minimize_sign;
            tsrMinimizar.Name = "tsrMinimizar";
            tsrMinimizar.Size = new Size(28, 55);
            tsrMinimizar.Click += tsrMinimizar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 157, 115);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(797, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 316);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 157, 115);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 388);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 3);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 157, 115);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 313);
            panel3.TabIndex = 4;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 391);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(picLogoNutriSys);
            Controls.Add(lblTitulo);
            Controls.Add(mnsNavegación);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnsNavegación;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Inicio";
            Load += frmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)picLogoNutriSys).EndInit();
            mnsNavegación.ResumeLayout(false);
            mnsNavegación.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox picLogoNutriSys;
        private ToolStripMenuItem tsrPacientes;
        private ToolStripMenuItem tsrHistoriasClinicas;
        private ToolStripMenuItem tsrAntropometria;
        private ToolStripMenuItem tsrSalir;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private MenuStrip mnsNavegación;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ToolStripMenuItem tsrPami;
        private ToolStripMenuItem tsrMinimizar;
    }
}