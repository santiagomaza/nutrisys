namespace CapaPresentación
{
    partial class frmHistoriasClinicas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoriasClinicas));
            DgvHistClinicas = new DataGridView();
            grpHistClinicas = new GroupBox();
            btnQuitarArchivo = new Button();
            btnEditarDiagnosticosHC = new Button();
            lblFechaConsulta = new Label();
            dtpFechaConsulta = new DateTimePicker();
            btnLimpiarInputs = new Button();
            btnSubrayado = new Button();
            btnColores = new Button();
            btnCursiva = new Button();
            btnNegrita = new Button();
            rtfObservaciones = new RichTextBox();
            txtBuscarDiagnostico = new TextBox();
            cboFiltrarDiagnosticos = new ComboBox();
            ClkDiagnosticos = new CheckedListBox();
            txtTituloArchivo = new TextBox();
            BtnBuscarArchivo = new Button();
            BtnAgregarDiagnostico = new Button();
            BtnEditarHistClinica = new Button();
            BtnAgregarHistoriaClinica = new Button();
            TxtNuevoDiagnostico = new TextBox();
            lblHistoriaClinica = new Label();
            lblDiagnostico = new Label();
            lblNuevoDiagnostico = new Label();
            cboPacientes = new ComboBox();
            lblPaciente = new Label();
            lblTitulo = new Label();
            ofdPrueba = new OpenFileDialog();
            BtnAbrirArchivo = new Button();
            BtnVerDetalles = new Button();
            TxtBuscarPaciente = new TextBox();
            BtnBuscarPaciente = new Button();
            BtnMostrarHC = new Button();
            LblFHUM = new Label();
            LblFHUMod = new Label();
            pictureBox1 = new PictureBox();
            mnsNavegación = new MenuStrip();
            tsrPacientes = new ToolStripMenuItem();
            tsrHistoriasClinicas = new ToolStripMenuItem();
            tsrAdminHistClinicas = new ToolStripMenuItem();
            tsrAntropometria = new ToolStripMenuItem();
            tsrSalir = new ToolStripMenuItem();
            tsrPAMI = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            tsrMinimizar = new ToolStripMenuItem();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            lblDiagnosticos = new Label();
            lblDiagnosticosBD = new Label();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            btnFiltrarFechas = new Button();
            btnQuitarFiltro = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvHistClinicas).BeginInit();
            grpHistClinicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mnsNavegación.SuspendLayout();
            SuspendLayout();
            // 
            // DgvHistClinicas
            // 
            DgvHistClinicas.AllowUserToAddRows = false;
            DgvHistClinicas.AllowUserToDeleteRows = false;
            DgvHistClinicas.AllowUserToResizeColumns = false;
            DgvHistClinicas.AllowUserToResizeRows = false;
            DgvHistClinicas.BackgroundColor = Color.White;
            DgvHistClinicas.BorderStyle = BorderStyle.Fixed3D;
            DgvHistClinicas.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DgvHistClinicas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(16, 157, 115);
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgvHistClinicas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvHistClinicas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvHistClinicas.DefaultCellStyle = dataGridViewCellStyle2;
            DgvHistClinicas.EnableHeadersVisualStyles = false;
            DgvHistClinicas.GridColor = Color.Black;
            DgvHistClinicas.Location = new Point(33, 381);
            DgvHistClinicas.Name = "DgvHistClinicas";
            DgvHistClinicas.ReadOnly = true;
            DgvHistClinicas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DgvHistClinicas.RowHeadersVisible = false;
            DgvHistClinicas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = Color.SeaGreen;
            DgvHistClinicas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DgvHistClinicas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvHistClinicas.Size = new Size(616, 166);
            DgvHistClinicas.TabIndex = 0;
            DgvHistClinicas.CellMouseClick += DgvHistClinicas_CellMouseClick;
            // 
            // grpHistClinicas
            // 
            grpHistClinicas.Controls.Add(btnQuitarArchivo);
            grpHistClinicas.Controls.Add(btnEditarDiagnosticosHC);
            grpHistClinicas.Controls.Add(lblFechaConsulta);
            grpHistClinicas.Controls.Add(dtpFechaConsulta);
            grpHistClinicas.Controls.Add(btnLimpiarInputs);
            grpHistClinicas.Controls.Add(btnSubrayado);
            grpHistClinicas.Controls.Add(btnColores);
            grpHistClinicas.Controls.Add(btnCursiva);
            grpHistClinicas.Controls.Add(btnNegrita);
            grpHistClinicas.Controls.Add(rtfObservaciones);
            grpHistClinicas.Controls.Add(txtBuscarDiagnostico);
            grpHistClinicas.Controls.Add(cboFiltrarDiagnosticos);
            grpHistClinicas.Controls.Add(ClkDiagnosticos);
            grpHistClinicas.Controls.Add(txtTituloArchivo);
            grpHistClinicas.Controls.Add(BtnBuscarArchivo);
            grpHistClinicas.Controls.Add(BtnAgregarDiagnostico);
            grpHistClinicas.Controls.Add(BtnEditarHistClinica);
            grpHistClinicas.Controls.Add(BtnAgregarHistoriaClinica);
            grpHistClinicas.Controls.Add(TxtNuevoDiagnostico);
            grpHistClinicas.Controls.Add(lblHistoriaClinica);
            grpHistClinicas.Controls.Add(lblDiagnostico);
            grpHistClinicas.Controls.Add(lblNuevoDiagnostico);
            grpHistClinicas.FlatStyle = FlatStyle.Flat;
            grpHistClinicas.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpHistClinicas.Location = new Point(668, 81);
            grpHistClinicas.Name = "grpHistClinicas";
            grpHistClinicas.Size = new Size(579, 600);
            grpHistClinicas.TabIndex = 1;
            grpHistClinicas.TabStop = false;
            // 
            // btnQuitarArchivo
            // 
            btnQuitarArchivo.BackColor = Color.Transparent;
            btnQuitarArchivo.FlatAppearance.BorderSize = 0;
            btnQuitarArchivo.FlatStyle = FlatStyle.Flat;
            btnQuitarArchivo.Image = Properties.Resources.removeFIle;
            btnQuitarArchivo.Location = new Point(499, 493);
            btnQuitarArchivo.Name = "btnQuitarArchivo";
            btnQuitarArchivo.Size = new Size(48, 38);
            btnQuitarArchivo.TabIndex = 27;
            btnQuitarArchivo.UseVisualStyleBackColor = false;
            btnQuitarArchivo.Click += btnQuitarArchivo_Click;
            // 
            // btnEditarDiagnosticosHC
            // 
            btnEditarDiagnosticosHC.BackColor = Color.MediumSeaGreen;
            btnEditarDiagnosticosHC.FlatStyle = FlatStyle.Flat;
            btnEditarDiagnosticosHC.Image = Properties.Resources.diskette;
            btnEditarDiagnosticosHC.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarDiagnosticosHC.Location = new Point(366, 113);
            btnEditarDiagnosticosHC.Name = "btnEditarDiagnosticosHC";
            btnEditarDiagnosticosHC.Size = new Size(155, 35);
            btnEditarDiagnosticosHC.TabIndex = 26;
            btnEditarDiagnosticosHC.Text = "Guardar Cambios";
            btnEditarDiagnosticosHC.TextAlign = ContentAlignment.MiddleRight;
            btnEditarDiagnosticosHC.UseVisualStyleBackColor = false;
            btnEditarDiagnosticosHC.Click += btnEditarDiagnosticosHC_Click;
            // 
            // lblFechaConsulta
            // 
            lblFechaConsulta.AutoSize = true;
            lblFechaConsulta.Location = new Point(8, 265);
            lblFechaConsulta.Name = "lblFechaConsulta";
            lblFechaConsulta.Size = new Size(103, 19);
            lblFechaConsulta.TabIndex = 25;
            lblFechaConsulta.Text = "Fecha Consulta";
            // 
            // dtpFechaConsulta
            // 
            dtpFechaConsulta.Format = DateTimePickerFormat.Short;
            dtpFechaConsulta.Location = new Point(145, 262);
            dtpFechaConsulta.Name = "dtpFechaConsulta";
            dtpFechaConsulta.Size = new Size(118, 25);
            dtpFechaConsulta.TabIndex = 24;
            // 
            // btnLimpiarInputs
            // 
            btnLimpiarInputs.BackColor = Color.Silver;
            btnLimpiarInputs.FlatStyle = FlatStyle.Flat;
            btnLimpiarInputs.Image = Properties.Resources.broom;
            btnLimpiarInputs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarInputs.Location = new Point(429, 549);
            btnLimpiarInputs.Name = "btnLimpiarInputs";
            btnLimpiarInputs.Size = new Size(129, 34);
            btnLimpiarInputs.TabIndex = 23;
            btnLimpiarInputs.Text = "Limpiar Inputs";
            btnLimpiarInputs.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarInputs.UseVisualStyleBackColor = false;
            btnLimpiarInputs.Click += btnLimpiarInputs_Click;
            // 
            // btnSubrayado
            // 
            btnSubrayado.Image = Properties.Resources.underline;
            btnSubrayado.Location = new Point(499, 396);
            btnSubrayado.Name = "btnSubrayado";
            btnSubrayado.Size = new Size(37, 37);
            btnSubrayado.TabIndex = 22;
            btnSubrayado.UseVisualStyleBackColor = true;
            btnSubrayado.Click += btnSubrayado_Click;
            // 
            // btnColores
            // 
            btnColores.Image = Properties.Resources.color_wheel;
            btnColores.Location = new Point(499, 439);
            btnColores.Name = "btnColores";
            btnColores.Size = new Size(37, 37);
            btnColores.TabIndex = 21;
            btnColores.UseVisualStyleBackColor = true;
            btnColores.Click += btnColores_Click;
            // 
            // btnCursiva
            // 
            btnCursiva.Image = Properties.Resources.italic_font;
            btnCursiva.Location = new Point(499, 353);
            btnCursiva.Name = "btnCursiva";
            btnCursiva.Size = new Size(37, 37);
            btnCursiva.TabIndex = 20;
            btnCursiva.UseVisualStyleBackColor = true;
            btnCursiva.Click += btnCursiva_Click;
            // 
            // btnNegrita
            // 
            btnNegrita.Image = (Image)resources.GetObject("btnNegrita.Image");
            btnNegrita.Location = new Point(499, 310);
            btnNegrita.Name = "btnNegrita";
            btnNegrita.Size = new Size(37, 37);
            btnNegrita.TabIndex = 19;
            btnNegrita.UseVisualStyleBackColor = true;
            btnNegrita.Click += btnNegrita_Click;
            // 
            // rtfObservaciones
            // 
            rtfObservaciones.BorderStyle = BorderStyle.FixedSingle;
            rtfObservaciones.Location = new Point(144, 310);
            rtfObservaciones.Name = "rtfObservaciones";
            rtfObservaciones.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtfObservaciones.Size = new Size(349, 161);
            rtfObservaciones.TabIndex = 18;
            rtfObservaciones.Text = "";
            rtfObservaciones.SelectionChanged += rtfObservaciones_SelectionChanged;
            // 
            // txtBuscarDiagnostico
            // 
            txtBuscarDiagnostico.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarDiagnostico.Location = new Point(366, 72);
            txtBuscarDiagnostico.Name = "txtBuscarDiagnostico";
            txtBuscarDiagnostico.PlaceholderText = "Buscar Diagnóstico";
            txtBuscarDiagnostico.Size = new Size(202, 25);
            txtBuscarDiagnostico.TabIndex = 13;
            txtBuscarDiagnostico.TextChanged += txtBuscarDiagnostico_TextChanged;
            // 
            // cboFiltrarDiagnosticos
            // 
            cboFiltrarDiagnosticos.BackColor = Color.White;
            cboFiltrarDiagnosticos.FormattingEnabled = true;
            cboFiltrarDiagnosticos.Items.AddRange(new object[] { "Seleccione un filtro...", "Todos los diagnósticos", "Diagnósticos Marcados" });
            cboFiltrarDiagnosticos.Location = new Point(366, 26);
            cboFiltrarDiagnosticos.Name = "cboFiltrarDiagnosticos";
            cboFiltrarDiagnosticos.Size = new Size(202, 27);
            cboFiltrarDiagnosticos.TabIndex = 12;
            cboFiltrarDiagnosticos.SelectedIndexChanged += cboFiltrarDiagnosticos_SelectedIndexChanged;
            // 
            // ClkDiagnosticos
            // 
            ClkDiagnosticos.BorderStyle = BorderStyle.FixedSingle;
            ClkDiagnosticos.CheckOnClick = true;
            ClkDiagnosticos.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClkDiagnosticos.FormattingEnabled = true;
            ClkDiagnosticos.Location = new Point(145, 26);
            ClkDiagnosticos.Name = "ClkDiagnosticos";
            ClkDiagnosticos.ScrollAlwaysVisible = true;
            ClkDiagnosticos.Size = new Size(215, 122);
            ClkDiagnosticos.TabIndex = 11;
            ClkDiagnosticos.ItemCheck += ClkDiagnosticos_ItemCheck;
            // 
            // txtTituloArchivo
            // 
            txtTituloArchivo.BorderStyle = BorderStyle.FixedSingle;
            txtTituloArchivo.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTituloArchivo.Location = new Point(144, 501);
            txtTituloArchivo.Name = "txtTituloArchivo";
            txtTituloArchivo.Size = new Size(349, 25);
            txtTituloArchivo.TabIndex = 6;
            // 
            // BtnBuscarArchivo
            // 
            BtnBuscarArchivo.FlatStyle = FlatStyle.Flat;
            BtnBuscarArchivo.Location = new Point(10, 495);
            BtnBuscarArchivo.Name = "BtnBuscarArchivo";
            BtnBuscarArchivo.Size = new Size(115, 35);
            BtnBuscarArchivo.TabIndex = 5;
            BtnBuscarArchivo.Text = "Buscar Archivo";
            BtnBuscarArchivo.UseVisualStyleBackColor = true;
            BtnBuscarArchivo.Click += BtnBuscarArchivo_Click;
            // 
            // BtnAgregarDiagnostico
            // 
            BtnAgregarDiagnostico.FlatStyle = FlatStyle.Flat;
            BtnAgregarDiagnostico.Image = Properties.Resources.plus;
            BtnAgregarDiagnostico.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregarDiagnostico.Location = new Point(144, 206);
            BtnAgregarDiagnostico.Name = "BtnAgregarDiagnostico";
            BtnAgregarDiagnostico.Size = new Size(216, 36);
            BtnAgregarDiagnostico.TabIndex = 9;
            BtnAgregarDiagnostico.Text = "Agregar Nuevo Diagnóstico";
            BtnAgregarDiagnostico.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregarDiagnostico.UseVisualStyleBackColor = true;
            BtnAgregarDiagnostico.Click += BtnAgregarDiagnostico_Click;
            // 
            // BtnEditarHistClinica
            // 
            BtnEditarHistClinica.BackColor = Color.Yellow;
            BtnEditarHistClinica.FlatStyle = FlatStyle.Popup;
            BtnEditarHistClinica.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEditarHistClinica.Image = Properties.Resources.edit;
            BtnEditarHistClinica.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEditarHistClinica.Location = new Point(230, 549);
            BtnEditarHistClinica.Name = "BtnEditarHistClinica";
            BtnEditarHistClinica.Size = new Size(174, 34);
            BtnEditarHistClinica.TabIndex = 7;
            BtnEditarHistClinica.Text = "Editar Historia Clínica";
            BtnEditarHistClinica.TextAlign = ContentAlignment.MiddleRight;
            BtnEditarHistClinica.UseVisualStyleBackColor = false;
            BtnEditarHistClinica.Click += BtnEditarHistClinica_Click;
            // 
            // BtnAgregarHistoriaClinica
            // 
            BtnAgregarHistoriaClinica.BackColor = Color.FromArgb(16, 157, 115);
            BtnAgregarHistoriaClinica.FlatStyle = FlatStyle.Flat;
            BtnAgregarHistoriaClinica.Image = Properties.Resources.plus;
            BtnAgregarHistoriaClinica.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregarHistoriaClinica.Location = new Point(10, 549);
            BtnAgregarHistoriaClinica.Name = "BtnAgregarHistoriaClinica";
            BtnAgregarHistoriaClinica.Size = new Size(192, 34);
            BtnAgregarHistoriaClinica.TabIndex = 8;
            BtnAgregarHistoriaClinica.Text = "Agregar Historia Clínica";
            BtnAgregarHistoriaClinica.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregarHistoriaClinica.UseVisualStyleBackColor = false;
            BtnAgregarHistoriaClinica.Click += BtnAgregarHistoriaClinica_Click;
            // 
            // TxtNuevoDiagnostico
            // 
            TxtNuevoDiagnostico.BorderStyle = BorderStyle.FixedSingle;
            TxtNuevoDiagnostico.Location = new Point(144, 175);
            TxtNuevoDiagnostico.Name = "TxtNuevoDiagnostico";
            TxtNuevoDiagnostico.Size = new Size(215, 25);
            TxtNuevoDiagnostico.TabIndex = 6;
            TxtNuevoDiagnostico.TextChanged += TxtNuevoDiagnostico_TextChanged;
            // 
            // lblHistoriaClinica
            // 
            lblHistoriaClinica.AutoSize = true;
            lblHistoriaClinica.Location = new Point(10, 310);
            lblHistoriaClinica.Name = "lblHistoriaClinica";
            lblHistoriaClinica.Size = new Size(99, 19);
            lblHistoriaClinica.TabIndex = 3;
            lblHistoriaClinica.Text = "Observaciones";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Location = new Point(11, 26);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(94, 19);
            lblDiagnostico.TabIndex = 1;
            lblDiagnostico.Text = "Diagnóstico/s";
            // 
            // lblNuevoDiagnostico
            // 
            lblNuevoDiagnostico.AutoSize = true;
            lblNuevoDiagnostico.Location = new Point(11, 177);
            lblNuevoDiagnostico.Name = "lblNuevoDiagnostico";
            lblNuevoDiagnostico.Size = new Size(127, 19);
            lblNuevoDiagnostico.TabIndex = 2;
            lblNuevoDiagnostico.Text = "Nuevo Diagnóstico";
            // 
            // cboPacientes
            // 
            cboPacientes.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPacientes.FormattingEnabled = true;
            cboPacientes.Location = new Point(110, 206);
            cboPacientes.Name = "cboPacientes";
            cboPacientes.Size = new Size(336, 28);
            cboPacientes.TabIndex = 4;
            cboPacientes.SelectedIndexChanged += CboPacientes_SelectedIndexChanged;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(33, 209);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(71, 20);
            lblPaciente.TabIndex = 0;
            lblPaciente.Text = "Paciente";
            // 
            // iconButton1
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(436, 92);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(205, 31);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Historias Clínicas";
            // 
            // BtnAbrirArchivo
            // 
            BtnAbrirArchivo.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            BtnAbrirArchivo.FlatStyle = FlatStyle.Flat;
            BtnAbrirArchivo.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAbrirArchivo.Image = (Image)resources.GetObject("BtnAbrirArchivo.Image");
            BtnAbrirArchivo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAbrirArchivo.Location = new Point(34, 556);
            BtnAbrirArchivo.Name = "BtnAbrirArchivo";
            BtnAbrirArchivo.Size = new Size(124, 34);
            BtnAbrirArchivo.TabIndex = 5;
            BtnAbrirArchivo.Text = "Abrir Archivo";
            BtnAbrirArchivo.TextAlign = ContentAlignment.MiddleRight;
            BtnAbrirArchivo.UseVisualStyleBackColor = true;
            BtnAbrirArchivo.Click += BtnAbrirArchivo_Click;
            // 
            // BtnVerDetalles
            // 
            BtnVerDetalles.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            BtnVerDetalles.FlatStyle = FlatStyle.Flat;
            BtnVerDetalles.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVerDetalles.Image = (Image)resources.GetObject("BtnVerDetalles.Image");
            BtnVerDetalles.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVerDetalles.Location = new Point(163, 556);
            BtnVerDetalles.Name = "BtnVerDetalles";
            BtnVerDetalles.Size = new Size(118, 34);
            BtnVerDetalles.TabIndex = 6;
            BtnVerDetalles.Text = "Ver Detalles";
            BtnVerDetalles.TextAlign = ContentAlignment.MiddleRight;
            BtnVerDetalles.UseVisualStyleBackColor = true;
            BtnVerDetalles.Click += BtnVerDetalles_Click;
            // 
            // TxtBuscarPaciente
            // 
            TxtBuscarPaciente.BorderStyle = BorderStyle.FixedSingle;
            TxtBuscarPaciente.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscarPaciente.Location = new Point(33, 159);
            TxtBuscarPaciente.Name = "TxtBuscarPaciente";
            TxtBuscarPaciente.PlaceholderText = "Buscar Paciente...";
            TxtBuscarPaciente.Size = new Size(294, 29);
            TxtBuscarPaciente.TabIndex = 8;
            TxtBuscarPaciente.TextChanged += TxtBuscarPaciente_TextChanged;
            // 
            // BtnBuscarPaciente
            // 
            BtnBuscarPaciente.BackColor = Color.LightGreen;
            BtnBuscarPaciente.FlatAppearance.BorderColor = Color.ForestGreen;
            BtnBuscarPaciente.FlatStyle = FlatStyle.Flat;
            BtnBuscarPaciente.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarPaciente.Image = Properties.Resources.loupe1;
            BtnBuscarPaciente.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscarPaciente.Location = new Point(333, 158);
            BtnBuscarPaciente.Name = "BtnBuscarPaciente";
            BtnBuscarPaciente.Size = new Size(140, 31);
            BtnBuscarPaciente.TabIndex = 9;
            BtnBuscarPaciente.Text = "Buscar Paciente";
            BtnBuscarPaciente.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscarPaciente.UseVisualStyleBackColor = false;
            BtnBuscarPaciente.Click += BtnBuscarPaciente_Click;
            // 
            // BtnMostrarHC
            // 
            BtnMostrarHC.BackColor = Color.FromArgb(224, 224, 224);
            BtnMostrarHC.FlatAppearance.BorderColor = Color.Gray;
            BtnMostrarHC.FlatStyle = FlatStyle.Flat;
            BtnMostrarHC.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnMostrarHC.Image = Properties.Resources.show;
            BtnMostrarHC.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMostrarHC.Location = new Point(452, 206);
            BtnMostrarHC.Name = "BtnMostrarHC";
            BtnMostrarHC.Size = new Size(189, 28);
            BtnMostrarHC.TabIndex = 10;
            BtnMostrarHC.Text = "Mostrar Historia Clínica";
            BtnMostrarHC.TextAlign = ContentAlignment.MiddleRight;
            BtnMostrarHC.UseVisualStyleBackColor = false;
            BtnMostrarHC.Click += BtnMostrarHC_Click;
            // 
            // LblFHUM
            // 
            LblFHUM.AutoSize = true;
            LblFHUM.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFHUM.Location = new Point(31, 602);
            LblFHUM.Name = "LblFHUM";
            LblFHUM.Size = new Size(148, 19);
            LblFHUM.TabIndex = 11;
            LblFHUM.Text = "Última Modificación:";
            // 
            // LblFHUMod
            // 
            LblFHUMod.AutoSize = true;
            LblFHUMod.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFHUMod.Location = new Point(173, 602);
            LblFHUMod.Name = "LblFHUMod";
            LblFHUMod.Size = new Size(138, 19);
            LblFHUMod.TabIndex = 12;
            LblFHUMod.Text = "ultimaModificacion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medical_prescription;
            pictureBox1.Location = new Point(400, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // mnsNavegación
            // 
            mnsNavegación.BackColor = Color.FromArgb(16, 157, 115);
            mnsNavegación.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnsNavegación.Items.AddRange(new ToolStripItem[] { tsrPacientes, tsrHistoriasClinicas, tsrAntropometria, tsrSalir, tsrPAMI, acercaDeToolStripMenuItem, tsrMinimizar });
            mnsNavegación.Location = new Point(0, 0);
            mnsNavegación.Name = "mnsNavegación";
            mnsNavegación.Padding = new Padding(10);
            mnsNavegación.Size = new Size(1263, 75);
            mnsNavegación.TabIndex = 14;
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
            tsrHistoriasClinicas.DropDownItems.AddRange(new ToolStripItem[] { tsrAdminHistClinicas });
            tsrHistoriasClinicas.Image = Properties.Resources.medical_prescription;
            tsrHistoriasClinicas.ImageScaling = ToolStripItemImageScaling.None;
            tsrHistoriasClinicas.Name = "tsrHistoriasClinicas";
            tsrHistoriasClinicas.Size = new Size(124, 55);
            tsrHistoriasClinicas.Text = "Historias Clínicas";
            tsrHistoriasClinicas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsrAdminHistClinicas
            // 
            tsrAdminHistClinicas.Name = "tsrAdminHistClinicas";
            tsrAdminHistClinicas.Size = new Size(256, 24);
            tsrAdminHistClinicas.Text = "Administrar Historias Clínicas";
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
            tsrSalir.Click += tsrSalir_Click;
            // 
            // tsrPAMI
            // 
            tsrPAMI.Image = Properties.Resources.retirement_plan;
            tsrPAMI.ImageScaling = ToolStripItemImageScaling.None;
            tsrPAMI.Name = "tsrPAMI";
            tsrPAMI.Size = new Size(55, 55);
            tsrPAMI.Text = "PAMI";
            tsrPAMI.TextImageRelation = TextImageRelation.ImageAboveText;
            tsrPAMI.Click += tsrPAMI_Click;
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
            panel3.Size = new Size(3, 650);
            panel3.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 157, 115);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1260, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 650);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 157, 115);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 722);
            panel2.Name = "panel2";
            panel2.Size = new Size(1257, 3);
            panel2.TabIndex = 17;
            // 
            // lblDiagnosticos
            // 
            lblDiagnosticos.AutoSize = true;
            lblDiagnosticos.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnosticos.Location = new Point(33, 295);
            lblDiagnosticos.Name = "lblDiagnosticos";
            lblDiagnosticos.Size = new Size(113, 20);
            lblDiagnosticos.TabIndex = 18;
            lblDiagnosticos.Text = "Diagnóstico/s:";
            // 
            // lblDiagnosticosBD
            // 
            lblDiagnosticosBD.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnosticosBD.Location = new Point(146, 296);
            lblDiagnosticosBD.Name = "lblDiagnosticosBD";
            lblDiagnosticosBD.Size = new Size(495, 82);
            lblDiagnosticosBD.TabIndex = 19;
            lblDiagnosticosBD.Text = "DiagnósticosPaciente";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesde.Location = new Point(33, 255);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(55, 20);
            lblDesde.TabIndex = 20;
            lblDesde.Text = "Desde";
            // 
            // dtpDesde
            // 
            dtpDesde.CalendarFont = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDesde.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(94, 252);
            dtpDesde.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDesde.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(121, 27);
            dtpDesde.TabIndex = 21;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHasta.Location = new Point(244, 256);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(50, 20);
            lblHasta.TabIndex = 22;
            lblHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.CalendarFont = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHasta.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(300, 252);
            dtpHasta.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpHasta.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(124, 27);
            dtpHasta.TabIndex = 23;
            // 
            // btnFiltrarFechas
            // 
            btnFiltrarFechas.BackColor = Color.LightGray;
            btnFiltrarFechas.FlatStyle = FlatStyle.Flat;
            btnFiltrarFechas.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltrarFechas.Image = Properties.Resources.filter1;
            btnFiltrarFechas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrarFechas.Location = new Point(436, 252);
            btnFiltrarFechas.Name = "btnFiltrarFechas";
            btnFiltrarFechas.Size = new Size(75, 27);
            btnFiltrarFechas.TabIndex = 24;
            btnFiltrarFechas.Text = "Filtrar";
            btnFiltrarFechas.TextAlign = ContentAlignment.MiddleRight;
            btnFiltrarFechas.UseVisualStyleBackColor = false;
            btnFiltrarFechas.Click += btnFiltrarFechas_Click;
            // 
            // btnQuitarFiltro
            // 
            btnQuitarFiltro.FlatAppearance.BorderSize = 0;
            btnQuitarFiltro.FlatStyle = FlatStyle.Flat;
            btnQuitarFiltro.Image = Properties.Resources.stopfilter;
            btnQuitarFiltro.Location = new Point(517, 252);
            btnQuitarFiltro.Name = "btnQuitarFiltro";
            btnQuitarFiltro.Size = new Size(36, 27);
            btnQuitarFiltro.TabIndex = 25;
            btnQuitarFiltro.UseVisualStyleBackColor = true;
            btnQuitarFiltro.Click += btnQuitarFiltro_Click;
            // 
            // frmHistoriasClinicas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1263, 725);
            Controls.Add(btnQuitarFiltro);
            Controls.Add(btnFiltrarFechas);
            Controls.Add(dtpHasta);
            Controls.Add(lblHasta);
            Controls.Add(dtpDesde);
            Controls.Add(lblDesde);
            Controls.Add(lblDiagnosticosBD);
            Controls.Add(lblDiagnosticos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(mnsNavegación);
            Controls.Add(pictureBox1);
            Controls.Add(LblFHUMod);
            Controls.Add(LblFHUM);
            Controls.Add(BtnMostrarHC);
            Controls.Add(BtnBuscarPaciente);
            Controls.Add(TxtBuscarPaciente);
            Controls.Add(BtnVerDetalles);
            Controls.Add(BtnAbrirArchivo);
            Controls.Add(lblTitulo);
            Controls.Add(cboPacientes);
            Controls.Add(grpHistClinicas);
            Controls.Add(DgvHistClinicas);
            Controls.Add(lblPaciente);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHistoriasClinicas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historias Clinicas";
            Load += frmHistoriasClinicas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvHistClinicas).EndInit();
            grpHistClinicas.ResumeLayout(false);
            grpHistClinicas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mnsNavegación.ResumeLayout(false);
            mnsNavegación.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvHistClinicas;
        private GroupBox grpHistClinicas;
        private Label lblHistoriaClinica;
        private Label lblNuevoDiagnostico;
        private Label lblDiagnostico;
        private Label lblPaciente;
        private TextBox TxtNuevoDiagnostico;
        private ComboBox cboPacientes;
        private Button BtnAgregarDiagnostico;
        private Button BtnAgregarHistoriaClinica;
        //private FontAwesome.Sharp.IconButton iconButton1;
        private Label lblTitulo;
        private OpenFileDialog ofdPrueba;
        private Button BtnBuscarArchivo;
        private TextBox txtTituloArchivo;
        private Button BtnAbrirArchivo;
        private Button BtnVerDetalles;
        private Button BtnEditarHistClinica;
        private TextBox TxtBuscarPaciente;
        private Button BtnBuscarPaciente;
        private Button BtnMostrarHC;
        private CheckedListBox ClkDiagnosticos;
        private Label LblFHUM;
        private Label LblFHUMod;
        private PictureBox pictureBox1;
        private MenuStrip mnsNavegación;
        private ToolStripMenuItem tsrPacientes;
        private ToolStripMenuItem tsrHistoriasClinicas;
        private ToolStripMenuItem tsrAdminHistClinicas;
        private ToolStripMenuItem tsrAntropometria;
        private ToolStripMenuItem tsrSalir;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cboFiltrarDiagnosticos;
        private TextBox txtBuscarDiagnostico;
        private RichTextBox rtfObservaciones;
        private Button btnNegrita;
        private Button btnCursiva;
        private Button btnColores;
        private Button btnSubrayado;
        private Button btnLimpiarInputs;
        private ToolStripMenuItem tsrMinimizar;
        private ToolStripMenuItem tsrPAMI;
        private Label lblFechaConsulta;
        private DateTimePicker dtpFechaConsulta;
        private Label lblDiagnosticos;
        private Label lblDiagnosticosBD;
        private Button btnEditarDiagnosticosHC;
        private Button btnQuitarArchivo;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private Button btnFiltrarFechas;
        private Button btnQuitarFiltro;
    }
}