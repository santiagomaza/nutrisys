namespace CapaPresentación
{
    partial class frmAntropometria
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAntropometria));
            grpAntropometria = new GroupBox();
            btnLimpiarInputs = new Button();
            txtTalla = new TextBox();
            lblTalla = new Label();
            btnEditarDA = new FontAwesome.Sharp.IconButton();
            dtpFechaEvolucion = new DateTimePicker();
            txtEdadCorporal = new TextBox();
            txtPorcGC = new TextBox();
            txtNivelGV = new TextBox();
            txtIMC = new TextBox();
            txtMusculoEsqueletico = new TextBox();
            txtPeso = new TextBox();
            btnAgregarDatos = new Button();
            lblFechaEvolucion = new Label();
            lblEdadCorporal = new Label();
            lblNivelGrasaVisc = new Label();
            lblPorcGrasaCorp = new Label();
            lblIMC = new Label();
            lblMuscEsq = new Label();
            lblPeso = new Label();
            cboPacientes = new ComboBox();
            lblPaciente = new Label();
            dgvDatosAntropometricos = new DataGridView();
            lblAntropometria = new Label();
            txtBuscarPaciente = new TextBox();
            lblPacienteDA = new Label();
            lblTituloPaciente = new Label();
            btnBuscarPaciente = new Button();
            btnMostrarDatosAnt = new Button();
            errAntropometria = new ErrorProvider(components);
            LblFUM = new Label();
            LblFUMod = new Label();
            pictureBox1 = new PictureBox();
            mnsNavegación = new MenuStrip();
            tsrPacientes = new ToolStripMenuItem();
            tsrHistoriasClinicas = new ToolStripMenuItem();
            tsrAntropometria = new ToolStripMenuItem();
            tsrAdminAntropometría = new ToolStripMenuItem();
            tsrSalir = new ToolStripMenuItem();
            tsrPAMI = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            tsrMinimizar = new ToolStripMenuItem();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            btnQuitarFiltro = new Button();
            btnFiltrarFechas = new Button();
            dtpHasta = new DateTimePicker();
            lblHasta = new Label();
            dtpDesde = new DateTimePicker();
            lblDesde = new Label();
            grpAntropometria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosAntropometricos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errAntropometria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mnsNavegación.SuspendLayout();
            SuspendLayout();
            // 
            // grpAntropometria
            // 
            grpAntropometria.Controls.Add(btnLimpiarInputs);
            grpAntropometria.Controls.Add(txtTalla);
            grpAntropometria.Controls.Add(lblTalla);
            grpAntropometria.Controls.Add(btnEditarDA);
            grpAntropometria.Controls.Add(dtpFechaEvolucion);
            grpAntropometria.Controls.Add(txtEdadCorporal);
            grpAntropometria.Controls.Add(txtPorcGC);
            grpAntropometria.Controls.Add(txtNivelGV);
            grpAntropometria.Controls.Add(txtIMC);
            grpAntropometria.Controls.Add(txtMusculoEsqueletico);
            grpAntropometria.Controls.Add(txtPeso);
            grpAntropometria.Controls.Add(btnAgregarDatos);
            grpAntropometria.Controls.Add(lblFechaEvolucion);
            grpAntropometria.Controls.Add(lblEdadCorporal);
            grpAntropometria.Controls.Add(lblNivelGrasaVisc);
            grpAntropometria.Controls.Add(lblPorcGrasaCorp);
            grpAntropometria.Controls.Add(lblIMC);
            grpAntropometria.Controls.Add(lblMuscEsq);
            grpAntropometria.Controls.Add(lblPeso);
            grpAntropometria.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpAntropometria.Location = new Point(573, 243);
            grpAntropometria.Name = "grpAntropometria";
            grpAntropometria.Size = new Size(636, 373);
            grpAntropometria.TabIndex = 6;
            grpAntropometria.TabStop = false;
            // 
            // btnLimpiarInputs
            // 
            btnLimpiarInputs.BackColor = Color.DarkGray;
            btnLimpiarInputs.FlatStyle = FlatStyle.Flat;
            btnLimpiarInputs.Image = Properties.Resources.broom;
            btnLimpiarInputs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarInputs.Location = new Point(281, 323);
            btnLimpiarInputs.Name = "btnLimpiarInputs";
            btnLimpiarInputs.Size = new Size(128, 36);
            btnLimpiarInputs.TabIndex = 21;
            btnLimpiarInputs.Text = "Limpiar Inputs";
            btnLimpiarInputs.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarInputs.UseVisualStyleBackColor = false;
            btnLimpiarInputs.Click += btnLimpiarInputs_Click;
            // 
            // txtTalla
            // 
            txtTalla.BorderStyle = BorderStyle.FixedSingle;
            txtTalla.Location = new Point(154, 86);
            txtTalla.Name = "txtTalla";
            txtTalla.Size = new Size(100, 25);
            txtTalla.TabIndex = 20;
            txtTalla.TextChanged += txtTalla_TextChanged;
            // 
            // lblTalla
            // 
            lblTalla.AutoSize = true;
            lblTalla.Location = new Point(13, 92);
            lblTalla.Name = "lblTalla";
            lblTalla.Size = new Size(60, 19);
            lblTalla.TabIndex = 19;
            lblTalla.Text = "Talla (m)";
            // 
            // btnEditarDA
            // 
            btnEditarDA.BackColor = Color.Yellow;
            btnEditarDA.FlatStyle = FlatStyle.Flat;
            btnEditarDA.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnEditarDA.IconColor = Color.Black;
            btnEditarDA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarDA.IconSize = 24;
            btnEditarDA.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarDA.Location = new Point(370, 262);
            btnEditarDA.Name = "btnEditarDA";
            btnEditarDA.Size = new Size(221, 41);
            btnEditarDA.TabIndex = 18;
            btnEditarDA.Text = "Editar Dato Antropométrico";
            btnEditarDA.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarDA.UseVisualStyleBackColor = false;
            btnEditarDA.Click += BtnEditarDA_Click;
            // 
            // dtpFechaEvolucion
            // 
            dtpFechaEvolucion.Format = DateTimePickerFormat.Short;
            dtpFechaEvolucion.Location = new Point(468, 212);
            dtpFechaEvolucion.Name = "dtpFechaEvolucion";
            dtpFechaEvolucion.Size = new Size(100, 25);
            dtpFechaEvolucion.TabIndex = 14;
            // 
            // txtEdadCorporal
            // 
            txtEdadCorporal.BorderStyle = BorderStyle.FixedSingle;
            txtEdadCorporal.Location = new Point(468, 149);
            txtEdadCorporal.Name = "txtEdadCorporal";
            txtEdadCorporal.Size = new Size(100, 25);
            txtEdadCorporal.TabIndex = 13;
            // 
            // txtPorcGC
            // 
            txtPorcGC.BorderStyle = BorderStyle.FixedSingle;
            txtPorcGC.Location = new Point(468, 27);
            txtPorcGC.Name = "txtPorcGC";
            txtPorcGC.Size = new Size(100, 25);
            txtPorcGC.TabIndex = 12;
            // 
            // txtNivelGV
            // 
            txtNivelGV.BorderStyle = BorderStyle.FixedSingle;
            txtNivelGV.Location = new Point(468, 86);
            txtNivelGV.Name = "txtNivelGV";
            txtNivelGV.Size = new Size(100, 25);
            txtNivelGV.TabIndex = 11;
            // 
            // txtIMC
            // 
            txtIMC.BorderStyle = BorderStyle.FixedSingle;
            txtIMC.Location = new Point(154, 149);
            txtIMC.Name = "txtIMC";
            txtIMC.Size = new Size(100, 25);
            txtIMC.TabIndex = 10;
            // 
            // txtMusculoEsqueletico
            // 
            txtMusculoEsqueletico.BorderStyle = BorderStyle.FixedSingle;
            txtMusculoEsqueletico.Location = new Point(154, 212);
            txtMusculoEsqueletico.Name = "txtMusculoEsqueletico";
            txtMusculoEsqueletico.Size = new Size(100, 25);
            txtMusculoEsqueletico.TabIndex = 9;
            // 
            // txtPeso
            // 
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            txtPeso.Location = new Point(154, 27);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 25);
            txtPeso.TabIndex = 8;
            txtPeso.TextChanged += txtPeso_TextChanged;
            // 
            // btnAgregarDatos
            // 
            btnAgregarDatos.BackColor = Color.FromArgb(16, 157, 116);
            btnAgregarDatos.FlatStyle = FlatStyle.Flat;
            errAntropometria.SetIconAlignment(btnAgregarDatos, ErrorIconAlignment.MiddleLeft);
            btnAgregarDatos.Image = Properties.Resources.plus;
            btnAgregarDatos.Location = new Point(83, 262);
            btnAgregarDatos.Name = "btnAgregarDatos";
            btnAgregarDatos.Size = new Size(259, 41);
            btnAgregarDatos.TabIndex = 7;
            btnAgregarDatos.Text = "Agregar Datos Antropométricos";
            btnAgregarDatos.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarDatos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarDatos.UseVisualStyleBackColor = false;
            btnAgregarDatos.Click += btnAgregarDatos_Click;
            // 
            // lblFechaEvolucion
            // 
            lblFechaEvolucion.AutoSize = true;
            lblFechaEvolucion.Location = new Point(313, 214);
            lblFechaEvolucion.Name = "lblFechaEvolucion";
            lblFechaEvolucion.Size = new Size(103, 19);
            lblFechaEvolucion.TabIndex = 6;
            lblFechaEvolucion.Text = "Fecha Consulta";
            // 
            // lblEdadCorporal
            // 
            lblEdadCorporal.AutoSize = true;
            lblEdadCorporal.Location = new Point(313, 155);
            lblEdadCorporal.Name = "lblEdadCorporal";
            lblEdadCorporal.Size = new Size(96, 19);
            lblEdadCorporal.TabIndex = 5;
            lblEdadCorporal.Text = "Edad Corporal";
            // 
            // lblNivelGrasaVisc
            // 
            lblNivelGrasaVisc.AutoSize = true;
            lblNivelGrasaVisc.Location = new Point(313, 92);
            lblNivelGrasaVisc.Name = "lblNivelGrasaVisc";
            lblNivelGrasaVisc.Size = new Size(149, 19);
            lblNivelGrasaVisc.TabIndex = 4;
            lblNivelGrasaVisc.Text = "Nivel de Grasa Visceral";
            // 
            // lblPorcGrasaCorp
            // 
            lblPorcGrasaCorp.AutoSize = true;
            lblPorcGrasaCorp.Location = new Point(313, 30);
            lblPorcGrasaCorp.Name = "lblPorcGrasaCorp";
            lblPorcGrasaCorp.Size = new Size(117, 19);
            lblPorcGrasaCorp.TabIndex = 3;
            lblPorcGrasaCorp.Text = "% Grasa Corporal";
            // 
            // lblIMC
            // 
            lblIMC.AutoSize = true;
            lblIMC.Location = new Point(13, 151);
            lblIMC.Name = "lblIMC";
            lblIMC.Size = new Size(35, 19);
            lblIMC.TabIndex = 2;
            lblIMC.Text = "IMC";
            // 
            // lblMuscEsq
            // 
            lblMuscEsq.AutoSize = true;
            lblMuscEsq.Location = new Point(13, 214);
            lblMuscEsq.Name = "lblMuscEsq";
            lblMuscEsq.Size = new Size(135, 19);
            lblMuscEsq.TabIndex = 1;
            lblMuscEsq.Text = "Músculo Esquelético";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(13, 29);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(68, 19);
            lblPeso.TabIndex = 0;
            lblPeso.Text = "Peso (KG)";
            // 
            // cboPacientes
            // 
            cboPacientes.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPacientes.FormattingEnabled = true;
            cboPacientes.Location = new Point(123, 180);
            cboPacientes.Name = "cboPacientes";
            cboPacientes.Size = new Size(358, 28);
            cboPacientes.TabIndex = 17;
            cboPacientes.SelectedIndexChanged += CboPacientes_SelectedIndexChanged;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(44, 183);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(71, 20);
            lblPaciente.TabIndex = 15;
            lblPaciente.Text = "Paciente";
            // 
            // dgvDatosAntropometricos
            // 
            dgvDatosAntropometricos.BackgroundColor = Color.White;
            dgvDatosAntropometricos.BorderStyle = BorderStyle.Fixed3D;
            dgvDatosAntropometricos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvDatosAntropometricos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(16, 157, 115);
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatosAntropometricos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatosAntropometricos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosAntropometricos.EnableHeadersVisualStyles = false;
            dgvDatosAntropometricos.GridColor = Color.Black;
            dgvDatosAntropometricos.Location = new Point(44, 306);
            dgvDatosAntropometricos.Name = "dgvDatosAntropometricos";
            dgvDatosAntropometricos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDatosAntropometricos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatosAntropometricos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dgvDatosAntropometricos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDatosAntropometricos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosAntropometricos.Size = new Size(515, 205);
            dgvDatosAntropometricos.TabIndex = 5;
            dgvDatosAntropometricos.ColumnHeaderMouseClick += dgvDatosAntropometricos_ColumnHeaderMouseClick;
            // 
            // lblAntropometria
            // 
            lblAntropometria.AutoSize = true;
            lblAntropometria.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAntropometria.Location = new Point(559, 84);
            lblAntropometria.Name = "lblAntropometria";
            lblAntropometria.Size = new Size(182, 31);
            lblAntropometria.TabIndex = 8;
            lblAntropometria.Text = "Antropometría";
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBuscarPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarPaciente.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarPaciente.Location = new Point(44, 132);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.PlaceholderText = "Buscar Paciente..";
            txtBuscarPaciente.Size = new Size(231, 29);
            txtBuscarPaciente.TabIndex = 9;
            txtBuscarPaciente.TextChanged += txtFiltrarPaciente_TextChanged;
            // 
            // lblPacienteDA
            // 
            lblPacienteDA.AutoSize = true;
            lblPacienteDA.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPacienteDA.Location = new Point(326, 272);
            lblPacienteDA.Name = "lblPacienteDA";
            lblPacienteDA.Size = new Size(75, 21);
            lblPacienteDA.TabIndex = 10;
            lblPacienteDA.Text = "Paciente";
            // 
            // lblTituloPaciente
            // 
            lblTituloPaciente.AutoSize = true;
            lblTituloPaciente.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloPaciente.Location = new Point(44, 272);
            lblTituloPaciente.Name = "lblTituloPaciente";
            lblTituloPaciente.Size = new Size(285, 21);
            lblTituloPaciente.TabIndex = 11;
            lblTituloPaciente.Text = "Datos Antropométricos del paciente";
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.BackColor = Color.LightGreen;
            btnBuscarPaciente.FlatStyle = FlatStyle.Flat;
            btnBuscarPaciente.Image = Properties.Resources.loupe1;
            btnBuscarPaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarPaciente.Location = new Point(281, 132);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(134, 29);
            btnBuscarPaciente.TabIndex = 12;
            btnBuscarPaciente.Text = "Buscar Paciente";
            btnBuscarPaciente.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarPaciente.UseVisualStyleBackColor = false;
            btnBuscarPaciente.Click += btnBuscarPaciente_Click;
            // 
            // btnMostrarDatosAnt
            // 
            btnMostrarDatosAnt.BackColor = Color.FromArgb(224, 224, 224);
            btnMostrarDatosAnt.FlatStyle = FlatStyle.Flat;
            btnMostrarDatosAnt.Image = Properties.Resources.show;
            btnMostrarDatosAnt.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarDatosAnt.Location = new Point(487, 180);
            btnMostrarDatosAnt.Name = "btnMostrarDatosAnt";
            btnMostrarDatosAnt.Size = new Size(232, 28);
            btnMostrarDatosAnt.TabIndex = 13;
            btnMostrarDatosAnt.Text = "Mostrar Datos Antropométricos";
            btnMostrarDatosAnt.TextAlign = ContentAlignment.MiddleRight;
            btnMostrarDatosAnt.UseVisualStyleBackColor = false;
            btnMostrarDatosAnt.Click += btnMostrarDatosAnt_Click;
            // 
            // errAntropometria
            // 
            errAntropometria.ContainerControl = this;
            // 
            // LblFUM
            // 
            LblFUM.AutoSize = true;
            LblFUM.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFUM.Location = new Point(44, 524);
            LblFUM.Name = "LblFUM";
            LblFUM.Size = new Size(148, 19);
            LblFUM.TabIndex = 16;
            LblFUM.Text = "Última Modificación:";
            // 
            // LblFUMod
            // 
            LblFUMod.AutoSize = true;
            LblFUMod.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFUMod.Location = new Point(191, 524);
            LblFUMod.Name = "LblFUMod";
            LblFUMod.Size = new Size(138, 19);
            LblFUMod.TabIndex = 17;
            LblFUMod.Text = "ultimaModificacion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.body_mass;
            pictureBox1.Location = new Point(522, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
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
            mnsNavegación.Size = new Size(1257, 75);
            mnsNavegación.TabIndex = 19;
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
            tsrHistoriasClinicas.Image = Properties.Resources.medical_prescription;
            tsrHistoriasClinicas.ImageScaling = ToolStripItemImageScaling.None;
            tsrHistoriasClinicas.Name = "tsrHistoriasClinicas";
            tsrHistoriasClinicas.Size = new Size(124, 55);
            tsrHistoriasClinicas.Text = "Historias Clínicas";
            tsrHistoriasClinicas.TextImageRelation = TextImageRelation.ImageAboveText;
            tsrHistoriasClinicas.Click += tsrHistoriasClinicas_Click;
            // 
            // tsrAntropometria
            // 
            tsrAntropometria.DropDownItems.AddRange(new ToolStripItem[] { tsrAdminAntropometría });
            tsrAntropometria.Image = Properties.Resources.body_mass;
            tsrAntropometria.ImageScaling = ToolStripItemImageScaling.None;
            tsrAntropometria.Name = "tsrAntropometria";
            tsrAntropometria.Size = new Size(111, 55);
            tsrAntropometria.Text = "Antropometría";
            tsrAntropometria.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsrAdminAntropometría
            // 
            tsrAdminAntropometría.Name = "tsrAdminAntropometría";
            tsrAdminAntropometría.Size = new Size(243, 24);
            tsrAdminAntropometría.Text = "Administrar Antropometría";
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
            panel3.Size = new Size(3, 562);
            panel3.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 157, 115);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 634);
            panel2.Name = "panel2";
            panel2.Size = new Size(1254, 3);
            panel2.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 157, 115);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1254, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 559);
            panel1.TabIndex = 22;
            // 
            // btnQuitarFiltro
            // 
            btnQuitarFiltro.BackColor = Color.Transparent;
            btnQuitarFiltro.FlatAppearance.BorderSize = 0;
            btnQuitarFiltro.FlatStyle = FlatStyle.Flat;
            btnQuitarFiltro.Image = Properties.Resources.stopfilter;
            btnQuitarFiltro.Location = new Point(531, 225);
            btnQuitarFiltro.Name = "btnQuitarFiltro";
            btnQuitarFiltro.Size = new Size(30, 26);
            btnQuitarFiltro.TabIndex = 31;
            btnQuitarFiltro.UseVisualStyleBackColor = false;
            btnQuitarFiltro.Click += btnQuitarFiltro_Click;
            // 
            // btnFiltrarFechas
            // 
            btnFiltrarFechas.BackColor = Color.LightGray;
            btnFiltrarFechas.FlatStyle = FlatStyle.Flat;
            btnFiltrarFechas.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltrarFechas.Image = Properties.Resources.filter;
            btnFiltrarFechas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrarFechas.Location = new Point(448, 225);
            btnFiltrarFechas.Name = "btnFiltrarFechas";
            btnFiltrarFechas.Size = new Size(77, 28);
            btnFiltrarFechas.TabIndex = 30;
            btnFiltrarFechas.Text = "Filtrar";
            btnFiltrarFechas.TextAlign = ContentAlignment.MiddleRight;
            btnFiltrarFechas.UseVisualStyleBackColor = false;
            btnFiltrarFechas.Click += btnFiltrarFechas_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(312, 226);
            dtpHasta.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpHasta.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(122, 27);
            dtpHasta.TabIndex = 29;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Microsoft YaHei", 11.25F);
            lblHasta.Location = new Point(256, 229);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(50, 20);
            lblHasta.TabIndex = 28;
            lblHasta.Text = "Hasta";
            // 
            // dtpDesde
            // 
            dtpDesde.CalendarFont = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDesde.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(105, 226);
            dtpDesde.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDesde.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(128, 27);
            dtpDesde.TabIndex = 27;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Microsoft YaHei", 11.25F);
            lblDesde.Location = new Point(44, 229);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(55, 20);
            lblDesde.TabIndex = 26;
            lblDesde.Text = "Desde";
            // 
            // frmAntropometria
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1257, 637);
            Controls.Add(btnQuitarFiltro);
            Controls.Add(btnFiltrarFechas);
            Controls.Add(dtpHasta);
            Controls.Add(lblHasta);
            Controls.Add(dtpDesde);
            Controls.Add(lblDesde);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(mnsNavegación);
            Controls.Add(cboPacientes);
            Controls.Add(lblPaciente);
            Controls.Add(pictureBox1);
            Controls.Add(LblFUMod);
            Controls.Add(LblFUM);
            Controls.Add(btnMostrarDatosAnt);
            Controls.Add(btnBuscarPaciente);
            Controls.Add(lblTituloPaciente);
            Controls.Add(lblPacienteDA);
            Controls.Add(txtBuscarPaciente);
            Controls.Add(lblAntropometria);
            Controls.Add(grpAntropometria);
            Controls.Add(dgvDatosAntropometricos);
            Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAntropometria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Antropometria";
            Load += frmAntropometria_Load;
            grpAntropometria.ResumeLayout(false);
            grpAntropometria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosAntropometricos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errAntropometria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mnsNavegación.ResumeLayout(false);
            mnsNavegación.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpAntropometria;
        private Label lblEdadCorporal;
        private Label lblNivelGrasaVisc;
        private Label lblPorcGrasaCorp;
        private Label lblIMC;
        private Label lblMuscEsq;
        private Label lblPeso;
        private DataGridView dgvDatosAntropometricos;
        private Label lblAntropometria;
        private TextBox txtBuscarPaciente;
        private Label lblPacienteDA;
        private Button btnAgregarDatos;
        private Label lblFechaEvolucion;
        private TextBox txtEdadCorporal;
        private TextBox txtPorcGC;
        private TextBox txtNivelGV;
        private TextBox txtIMC;
        private TextBox txtMusculoEsqueletico;
        private TextBox txtPeso;
        private DateTimePicker dtpFechaEvolucion;
        private Label lblPaciente;
        private Label lblTituloPaciente;
        private Button btnBuscarPaciente;
        private Button btnMostrarDatosAnt;
        private ErrorProvider errAntropometria;
        private ComboBox cboPacientes;
        private Label LblFUMod;
        private Label LblFUM;
        private FontAwesome.Sharp.IconButton btnEditarDA;
        private PictureBox pictureBox1;
        private MenuStrip mnsNavegación;
        private ToolStripMenuItem tsrPacientes;
        private ToolStripMenuItem tsrHistoriasClinicas;
        private ToolStripMenuItem tsrAntropometria;
        private ToolStripMenuItem tsrAdminAntropometría;
        private ToolStripMenuItem tsrSalir;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtTalla;
        private Label lblTalla;
        private Button btnLimpiarInputs;
        private ToolStripMenuItem tsrMinimizar;
        private ToolStripMenuItem tsrPAMI;
        private Button btnQuitarFiltro;
        private Button btnFiltrarFechas;
        private DateTimePicker dtpHasta;
        private Label lblHasta;
        private DateTimePicker dtpDesde;
        private Label lblDesde;
    }
}