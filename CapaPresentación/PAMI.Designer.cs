namespace CapaPresentación
{
    partial class frmPAMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPAMI));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            mnsNavegación = new MenuStrip();
            tsrPacientes = new ToolStripMenuItem();
            tsrHistoriasClinicas = new ToolStripMenuItem();
            tsrAntropometria = new ToolStripMenuItem();
            tsrPami = new ToolStripMenuItem();
            tsrSalir = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            tsrMinimizar = new ToolStripMenuItem();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            lblTituloPAMI = new Label();
            dgvPacientesPAMI = new DataGridView();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            btnFiltrarFechas = new Button();
            btnQuitarFiltro = new Button();
            mnsNavegación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientesPAMI).BeginInit();
            SuspendLayout();
            // 
            // mnsNavegación
            // 
            mnsNavegación.BackColor = Color.FromArgb(16, 157, 115);
            mnsNavegación.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnsNavegación.Items.AddRange(new ToolStripItem[] { tsrPacientes, tsrHistoriasClinicas, tsrAntropometria, tsrPami, tsrSalir, acercaDeToolStripMenuItem, tsrMinimizar });
            mnsNavegación.Location = new Point(0, 0);
            mnsNavegación.Name = "mnsNavegación";
            mnsNavegación.Padding = new Padding(10);
            mnsNavegación.Size = new Size(694, 75);
            mnsNavegación.TabIndex = 3;
            mnsNavegación.Text = "menuStrip1";
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
            // tsrPami
            // 
            tsrPami.Image = Properties.Resources.retirement_plan;
            tsrPami.ImageScaling = ToolStripItemImageScaling.None;
            tsrPami.Name = "tsrPami";
            tsrPami.Size = new Size(55, 55);
            tsrPami.Text = "PAMI";
            tsrPami.TextImageRelation = TextImageRelation.ImageAboveText;
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
            // tsrMinimizar
            // 
            tsrMinimizar.Alignment = ToolStripItemAlignment.Right;
            tsrMinimizar.Image = Properties.Resources.minimize_sign;
            tsrMinimizar.Name = "tsrMinimizar";
            tsrMinimizar.Size = new Size(28, 55);
            tsrMinimizar.Click += tsrMinimizar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 157, 115);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 448);
            panel3.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 157, 115);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 520);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 3);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 157, 115);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(691, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 445);
            panel2.TabIndex = 12;
            // 
            // lblTituloPAMI
            // 
            lblTituloPAMI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTituloPAMI.AutoSize = true;
            lblTituloPAMI.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloPAMI.Location = new Point(280, 88);
            lblTituloPAMI.Name = "lblTituloPAMI";
            lblTituloPAMI.Size = new Size(170, 28);
            lblTituloPAMI.TabIndex = 13;
            lblTituloPAMI.Text = "Pacientes PAMI";
            // 
            // dgvPacientesPAMI
            // 
            dgvPacientesPAMI.AllowUserToAddRows = false;
            dgvPacientesPAMI.AllowUserToDeleteRows = false;
            dgvPacientesPAMI.BackgroundColor = Color.White;
            dgvPacientesPAMI.BorderStyle = BorderStyle.Fixed3D;
            dgvPacientesPAMI.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(16, 157, 115);
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPacientesPAMI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacientesPAMI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientesPAMI.EnableHeadersVisualStyles = false;
            dgvPacientesPAMI.GridColor = Color.Black;
            dgvPacientesPAMI.Location = new Point(28, 184);
            dgvPacientesPAMI.Name = "dgvPacientesPAMI";
            dgvPacientesPAMI.ReadOnly = true;
            dgvPacientesPAMI.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dgvPacientesPAMI.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvPacientesPAMI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientesPAMI.Size = new Size(517, 311);
            dgvPacientesPAMI.TabIndex = 14;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Microsoft YaHei", 11.25F);
            lblDesde.Location = new Point(28, 140);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(55, 20);
            lblDesde.TabIndex = 20;
            lblDesde.Text = "Desde";
            // 
            // dtpDesde
            // 
            dtpDesde.CalendarFont = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDesde.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(89, 137);
            dtpDesde.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDesde.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(128, 27);
            dtpDesde.TabIndex = 21;
            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Microsoft YaHei", 11.25F);
            lblHasta.Location = new Point(240, 140);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(50, 20);
            lblHasta.TabIndex = 22;
            lblHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(296, 137);
            dtpHasta.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpHasta.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(122, 27);
            dtpHasta.TabIndex = 23;
            // 
            // btnFiltrarFechas
            // 
            btnFiltrarFechas.BackColor = Color.LightGray;
            btnFiltrarFechas.FlatStyle = FlatStyle.Flat;
            btnFiltrarFechas.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltrarFechas.Image = Properties.Resources.filter;
            btnFiltrarFechas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrarFechas.Location = new Point(432, 136);
            btnFiltrarFechas.Name = "btnFiltrarFechas";
            btnFiltrarFechas.Size = new Size(77, 28);
            btnFiltrarFechas.TabIndex = 24;
            btnFiltrarFechas.Text = "Filtrar";
            btnFiltrarFechas.TextAlign = ContentAlignment.MiddleRight;
            btnFiltrarFechas.UseVisualStyleBackColor = false;
            btnFiltrarFechas.Click += btnFiltrarFechas_Click;
            // 
            // btnQuitarFiltro
            // 
            btnQuitarFiltro.BackColor = Color.Transparent;
            btnQuitarFiltro.FlatAppearance.BorderSize = 0;
            btnQuitarFiltro.FlatStyle = FlatStyle.Flat;
            btnQuitarFiltro.Image = Properties.Resources.stopfilter;
            btnQuitarFiltro.Location = new Point(515, 136);
            btnQuitarFiltro.Name = "btnQuitarFiltro";
            btnQuitarFiltro.Size = new Size(30, 26);
            btnQuitarFiltro.TabIndex = 25;
            btnQuitarFiltro.UseVisualStyleBackColor = false;
            btnQuitarFiltro.Click += btnQuitarFiltro_Click;
            // 
            // frmPAMI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(694, 523);
            Controls.Add(btnQuitarFiltro);
            Controls.Add(btnFiltrarFechas);
            Controls.Add(dtpHasta);
            Controls.Add(lblHasta);
            Controls.Add(dtpDesde);
            Controls.Add(lblDesde);
            Controls.Add(dgvPacientesPAMI);
            Controls.Add(lblTituloPAMI);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(mnsNavegación);
            Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPAMI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAMI";
            Load += frmPAMI_Load;
            mnsNavegación.ResumeLayout(false);
            mnsNavegación.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientesPAMI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsNavegación;
        private ToolStripMenuItem tsrPacientes;
        private ToolStripMenuItem tsrHistoriasClinicas;
        private ToolStripMenuItem tsrAntropometria;
        private ToolStripMenuItem tsrPami;
        private ToolStripMenuItem tsrSalir;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem tsrMinimizar;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Label lblTituloPAMI;
        private DataGridView dgvPacientesPAMI;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private Button btnFiltrarFechas;
        private Button btnQuitarFiltro;
    }
}