namespace CapaPresentación
{
    partial class frmPacientes
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            lblTitulo = new Label();
            txtBuscarPacientes = new TextBox();
            dgvPacientes = new DataGridView();
            btnEditarPaciente = new Button();
            grpAgregarPaciente = new GroupBox();
            panel5 = new Panel();
            rbObraSocialPAMI = new RadioButton();
            rbSinObraSocial = new RadioButton();
            panel4 = new Panel();
            rbSexoMasc = new RadioButton();
            rbSexoFem = new RadioButton();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtOcupacion = new TextBox();
            lblOcupacion = new Label();
            cboEstadoCivil = new ComboBox();
            lblEstadoCivil = new Label();
            lblSexo = new Label();
            BtnLimpiarInputs = new Button();
            TxtLocalidad = new TextBox();
            LblLocalidad = new Label();
            CboProvincia = new ComboBox();
            CboPais = new ComboBox();
            LblProvincia = new Label();
            LblPais = new Label();
            TxtAltura = new TextBox();
            LblAltura = new Label();
            LblCalle = new Label();
            TxtCalle = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblObraSocial = new Label();
            txtNAfiliado = new TextBox();
            lblNAfiliado = new Label();
            label3 = new Label();
            txtCodigoPais = new TextBox();
            lblCodigoPais = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblCampoObligatorio = new Label();
            lblCamposObligatorios = new Label();
            dtpFechaNac = new DateTimePicker();
            lblTelefono = new Label();
            lblFechaNac = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            btnAgregarPaciente = new Button();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            errValidarTxtBox = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            mnsNavegación = new MenuStrip();
            tsrPacientes = new ToolStripMenuItem();
            tsrAdminPacientes = new ToolStripMenuItem();
            tsrHistoriasClinicas = new ToolStripMenuItem();
            tsrAntropometria = new ToolStripMenuItem();
            tsrPAMI = new ToolStripMenuItem();
            tsrSalir = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            tsrMinimizar = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            splitter1 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            grpAgregarPaciente.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errValidarTxtBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mnsNavegación.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(508, 82);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(123, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Pacientes";
            // 
            // txtBuscarPacientes
            // 
            txtBuscarPacientes.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarPacientes.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarPacientes.Location = new Point(23, 125);
            txtBuscarPacientes.Name = "txtBuscarPacientes";
            txtBuscarPacientes.PlaceholderText = "Buscar paciente...";
            txtBuscarPacientes.Size = new Size(313, 29);
            txtBuscarPacientes.TabIndex = 1;
            txtBuscarPacientes.TextChanged += txtBuscarPacientes_TextChanged;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AllowUserToResizeColumns = false;
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.BorderStyle = BorderStyle.Fixed3D;
            dgvPacientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(16, 157, 115);
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPacientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.GridColor = Color.Black;
            dgvPacientes.Location = new Point(23, 165);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.RowHeadersWidth = 40;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new Size(544, 544);
            dgvPacientes.TabIndex = 3;
            dgvPacientes.CellMouseClick += dgvPacientes_CellMouseClick;
            // 
            // btnEditarPaciente
            // 
            btnEditarPaciente.BackColor = Color.Yellow;
            btnEditarPaciente.FlatStyle = FlatStyle.Flat;
            btnEditarPaciente.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarPaciente.ForeColor = SystemColors.ControlText;
            btnEditarPaciente.Image = Properties.Resources.edit;
            btnEditarPaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarPaciente.Location = new Point(244, 539);
            btnEditarPaciente.Name = "btnEditarPaciente";
            btnEditarPaciente.Size = new Size(138, 36);
            btnEditarPaciente.TabIndex = 4;
            btnEditarPaciente.Text = "Editar Paciente";
            btnEditarPaciente.TextAlign = ContentAlignment.MiddleRight;
            btnEditarPaciente.UseVisualStyleBackColor = false;
            btnEditarPaciente.Click += btnEditarPaciente_Click;
            // 
            // grpAgregarPaciente
            // 
            grpAgregarPaciente.Controls.Add(panel5);
            grpAgregarPaciente.Controls.Add(panel4);
            grpAgregarPaciente.Controls.Add(txtEdad);
            grpAgregarPaciente.Controls.Add(lblEdad);
            grpAgregarPaciente.Controls.Add(txtOcupacion);
            grpAgregarPaciente.Controls.Add(lblOcupacion);
            grpAgregarPaciente.Controls.Add(cboEstadoCivil);
            grpAgregarPaciente.Controls.Add(lblEstadoCivil);
            grpAgregarPaciente.Controls.Add(lblSexo);
            grpAgregarPaciente.Controls.Add(BtnLimpiarInputs);
            grpAgregarPaciente.Controls.Add(TxtLocalidad);
            grpAgregarPaciente.Controls.Add(btnEditarPaciente);
            grpAgregarPaciente.Controls.Add(LblLocalidad);
            grpAgregarPaciente.Controls.Add(CboProvincia);
            grpAgregarPaciente.Controls.Add(CboPais);
            grpAgregarPaciente.Controls.Add(LblProvincia);
            grpAgregarPaciente.Controls.Add(LblPais);
            grpAgregarPaciente.Controls.Add(TxtAltura);
            grpAgregarPaciente.Controls.Add(LblAltura);
            grpAgregarPaciente.Controls.Add(LblCalle);
            grpAgregarPaciente.Controls.Add(TxtCalle);
            grpAgregarPaciente.Controls.Add(txtEmail);
            grpAgregarPaciente.Controls.Add(lblEmail);
            grpAgregarPaciente.Controls.Add(lblObraSocial);
            grpAgregarPaciente.Controls.Add(txtNAfiliado);
            grpAgregarPaciente.Controls.Add(lblNAfiliado);
            grpAgregarPaciente.Controls.Add(label3);
            grpAgregarPaciente.Controls.Add(txtCodigoPais);
            grpAgregarPaciente.Controls.Add(lblCodigoPais);
            grpAgregarPaciente.Controls.Add(label4);
            grpAgregarPaciente.Controls.Add(label2);
            grpAgregarPaciente.Controls.Add(label1);
            grpAgregarPaciente.Controls.Add(lblCampoObligatorio);
            grpAgregarPaciente.Controls.Add(lblCamposObligatorios);
            grpAgregarPaciente.Controls.Add(dtpFechaNac);
            grpAgregarPaciente.Controls.Add(lblTelefono);
            grpAgregarPaciente.Controls.Add(lblFechaNac);
            grpAgregarPaciente.Controls.Add(lblNombre);
            grpAgregarPaciente.Controls.Add(lblApellido);
            grpAgregarPaciente.Controls.Add(lblDNI);
            grpAgregarPaciente.Controls.Add(btnAgregarPaciente);
            grpAgregarPaciente.Controls.Add(txtTelefono);
            grpAgregarPaciente.Controls.Add(txtApellido);
            grpAgregarPaciente.Controls.Add(txtNombre);
            grpAgregarPaciente.Controls.Add(txtDNI);
            grpAgregarPaciente.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpAgregarPaciente.ForeColor = SystemColors.ControlText;
            grpAgregarPaciente.Location = new Point(573, 125);
            grpAgregarPaciente.Name = "grpAgregarPaciente";
            grpAgregarPaciente.Size = new Size(653, 584);
            grpAgregarPaciente.TabIndex = 6;
            grpAgregarPaciente.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(rbObraSocialPAMI);
            panel5.Controls.Add(rbSinObraSocial);
            panel5.Location = new Point(449, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(153, 28);
            panel5.TabIndex = 58;
            // 
            // rbObraSocialPAMI
            // 
            rbObraSocialPAMI.AutoSize = true;
            rbObraSocialPAMI.Location = new Point(3, 2);
            rbObraSocialPAMI.Name = "rbObraSocialPAMI";
            rbObraSocialPAMI.Size = new Size(61, 23);
            rbObraSocialPAMI.TabIndex = 55;
            rbObraSocialPAMI.TabStop = true;
            rbObraSocialPAMI.Text = "PAMI";
            rbObraSocialPAMI.UseVisualStyleBackColor = true;
            // 
            // rbSinObraSocial
            // 
            rbSinObraSocial.AutoSize = true;
            rbSinObraSocial.Location = new Point(70, 2);
            rbSinObraSocial.Name = "rbSinObraSocial";
            rbSinObraSocial.Size = new Size(80, 23);
            rbSinObraSocial.TabIndex = 56;
            rbSinObraSocial.TabStop = true;
            rbSinObraSocial.Text = "Ninguna";
            rbSinObraSocial.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(rbSexoMasc);
            panel4.Controls.Add(rbSexoFem);
            panel4.Location = new Point(170, 243);
            panel4.Name = "panel4";
            panel4.Size = new Size(191, 28);
            panel4.TabIndex = 57;
            // 
            // rbSexoMasc
            // 
            rbSexoMasc.AutoSize = true;
            rbSexoMasc.FlatAppearance.BorderSize = 0;
            rbSexoMasc.Location = new Point(3, 2);
            rbSexoMasc.Name = "rbSexoMasc";
            rbSexoMasc.Size = new Size(90, 23);
            rbSexoMasc.TabIndex = 53;
            rbSexoMasc.TabStop = true;
            rbSexoMasc.Text = "Masculino";
            rbSexoMasc.UseVisualStyleBackColor = true;
            // 
            // rbSexoFem
            // 
            rbSexoFem.AutoSize = true;
            rbSexoFem.Location = new Point(99, 2);
            rbSexoFem.Name = "rbSexoFem";
            rbSexoFem.Size = new Size(87, 23);
            rbSexoFem.TabIndex = 54;
            rbSexoFem.TabStop = true;
            rbSexoFem.Text = "Femenino";
            rbSexoFem.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.BorderStyle = BorderStyle.FixedSingle;
            txtEdad.Location = new Point(170, 282);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(76, 25);
            txtEdad.TabIndex = 52;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(26, 284);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(39, 19);
            lblEdad.TabIndex = 51;
            lblEdad.Text = "Edad";
            // 
            // txtOcupacion
            // 
            txtOcupacion.BorderStyle = BorderStyle.FixedSingle;
            txtOcupacion.Location = new Point(454, 246);
            txtOcupacion.Name = "txtOcupacion";
            txtOcupacion.Size = new Size(148, 25);
            txtOcupacion.TabIndex = 50;
            // 
            // lblOcupacion
            // 
            lblOcupacion.AutoSize = true;
            lblOcupacion.Location = new Point(367, 248);
            lblOcupacion.Name = "lblOcupacion";
            lblOcupacion.Size = new Size(76, 19);
            lblOcupacion.TabIndex = 49;
            lblOcupacion.Text = "Ocupación";
            // 
            // cboEstadoCivil
            // 
            cboEstadoCivil.FormattingEnabled = true;
            cboEstadoCivil.Items.AddRange(new object[] { "Seleccione un estado civil...", "Soltero/a", "En Pareja", "Casado/a", "Divorciado/a", "Viudo/a", "Sin Especificar" });
            cboEstadoCivil.Location = new Point(454, 204);
            cboEstadoCivil.Name = "cboEstadoCivil";
            cboEstadoCivil.Size = new Size(146, 27);
            cboEstadoCivil.TabIndex = 48;
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Location = new Point(369, 209);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(79, 19);
            lblEstadoCivil.TabIndex = 47;
            lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(25, 246);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(39, 19);
            lblSexo.TabIndex = 45;
            lblSexo.Text = "Sexo";
            // 
            // BtnLimpiarInputs
            // 
            BtnLimpiarInputs.BackColor = Color.Silver;
            BtnLimpiarInputs.FlatStyle = FlatStyle.Flat;
            BtnLimpiarInputs.Image = Properties.Resources.broom;
            BtnLimpiarInputs.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLimpiarInputs.Location = new Point(400, 539);
            BtnLimpiarInputs.Name = "BtnLimpiarInputs";
            BtnLimpiarInputs.Size = new Size(132, 36);
            BtnLimpiarInputs.TabIndex = 44;
            BtnLimpiarInputs.Text = "Limpiar Inputs";
            BtnLimpiarInputs.TextAlign = ContentAlignment.MiddleRight;
            BtnLimpiarInputs.UseVisualStyleBackColor = false;
            BtnLimpiarInputs.Click += BtnLimpiarInputs_Click;
            // 
            // TxtLocalidad
            // 
            TxtLocalidad.BorderStyle = BorderStyle.FixedSingle;
            TxtLocalidad.Location = new Point(421, 484);
            TxtLocalidad.Name = "TxtLocalidad";
            TxtLocalidad.Size = new Size(186, 25);
            TxtLocalidad.TabIndex = 43;
            // 
            // LblLocalidad
            // 
            LblLocalidad.AutoSize = true;
            LblLocalidad.Location = new Point(348, 488);
            LblLocalidad.Name = "LblLocalidad";
            LblLocalidad.Size = new Size(67, 19);
            LblLocalidad.TabIndex = 42;
            LblLocalidad.Text = "Localidad";
            // 
            // CboProvincia
            // 
            CboProvincia.FormattingEnabled = true;
            CboProvincia.Location = new Point(95, 484);
            CboProvincia.Name = "CboProvincia";
            CboProvincia.Size = new Size(213, 27);
            CboProvincia.TabIndex = 41;
            CboProvincia.Leave += CboProvincia_Leave;
            // 
            // CboPais
            // 
            CboPais.FormattingEnabled = true;
            CboPais.Location = new Point(472, 429);
            CboPais.Name = "CboPais";
            CboPais.Size = new Size(165, 27);
            CboPais.TabIndex = 40;
            CboPais.SelectedIndexChanged += CboPais_SelectedIndexChanged;
            CboPais.Leave += CboPais_Leave;
            // 
            // LblProvincia
            // 
            LblProvincia.AutoSize = true;
            LblProvincia.Location = new Point(24, 487);
            LblProvincia.Name = "LblProvincia";
            LblProvincia.Size = new Size(65, 19);
            LblProvincia.TabIndex = 38;
            LblProvincia.Text = "Provincia";
            // 
            // LblPais
            // 
            LblPais.AutoSize = true;
            LblPais.Location = new Point(433, 436);
            LblPais.Name = "LblPais";
            LblPais.Size = new Size(33, 19);
            LblPais.TabIndex = 36;
            LblPais.Text = "País";
            // 
            // TxtAltura
            // 
            TxtAltura.BorderStyle = BorderStyle.FixedSingle;
            TxtAltura.Location = new Point(314, 430);
            TxtAltura.Name = "TxtAltura";
            TxtAltura.Size = new Size(83, 25);
            TxtAltura.TabIndex = 35;
            // 
            // LblAltura
            // 
            LblAltura.AutoSize = true;
            LblAltura.Location = new Point(262, 433);
            LblAltura.Name = "LblAltura";
            LblAltura.Size = new Size(46, 19);
            LblAltura.TabIndex = 34;
            LblAltura.Text = "Altura";
            // 
            // LblCalle
            // 
            LblCalle.AutoSize = true;
            LblCalle.Location = new Point(29, 432);
            LblCalle.Name = "LblCalle";
            LblCalle.Size = new Size(38, 19);
            LblCalle.TabIndex = 33;
            LblCalle.Text = "Calle";
            // 
            // TxtCalle
            // 
            TxtCalle.BorderStyle = BorderStyle.FixedSingle;
            TxtCalle.Location = new Point(73, 429);
            TxtCalle.Name = "TxtCalle";
            TxtCalle.Size = new Size(158, 25);
            TxtCalle.TabIndex = 32;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(453, 159);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(146, 25);
            txtEmail.TabIndex = 28;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(370, 161);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 19);
            lblEmail.TabIndex = 27;
            lblEmail.Text = "Email";
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Location = new Point(363, 54);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(80, 19);
            lblObraSocial.TabIndex = 25;
            lblObraSocial.Text = "Obra Social";
            // 
            // txtNAfiliado
            // 
            txtNAfiliado.BorderStyle = BorderStyle.FixedSingle;
            txtNAfiliado.Location = new Point(453, 105);
            txtNAfiliado.Name = "txtNAfiliado";
            txtNAfiliado.Size = new Size(146, 25);
            txtNAfiliado.TabIndex = 24;
            txtNAfiliado.KeyPress += txtNAfiliado_KeyPress;
            // 
            // lblNAfiliado
            // 
            lblNAfiliado.AutoSize = true;
            lblNAfiliado.Location = new Point(368, 107);
            lblNAfiliado.Name = "lblNAfiliado";
            lblNAfiliado.Size = new Size(75, 19);
            lblNAfiliado.TabIndex = 23;
            lblNAfiliado.Text = "N° Afiliado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(16, 331);
            label3.Name = "label3";
            label3.Size = new Size(15, 19);
            label3.TabIndex = 22;
            label3.Text = "*";
            // 
            // txtCodigoPais
            // 
            txtCodigoPais.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoPais.Location = new Point(170, 328);
            txtCodigoPais.Name = "txtCodigoPais";
            txtCodigoPais.Size = new Size(153, 25);
            txtCodigoPais.TabIndex = 21;
            // 
            // lblCodigoPais
            // 
            lblCodigoPais.AutoSize = true;
            lblCodigoPais.Location = new Point(28, 331);
            lblCodigoPais.Name = "lblCodigoPais";
            lblCodigoPais.Size = new Size(100, 19);
            lblCodigoPais.TabIndex = 20;
            lblCodigoPais.Text = "Código de País";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(16, 384);
            label4.Name = "label4";
            label4.Size = new Size(15, 19);
            label4.TabIndex = 17;
            label4.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(16, 162);
            label2.Name = "label2";
            label2.Size = new Size(15, 19);
            label2.TabIndex = 15;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(16, 107);
            label1.Name = "label1";
            label1.Size = new Size(15, 19);
            label1.TabIndex = 14;
            label1.Text = "*";
            // 
            // lblCampoObligatorio
            // 
            lblCampoObligatorio.AutoSize = true;
            lblCampoObligatorio.ForeColor = Color.Red;
            lblCampoObligatorio.Location = new Point(16, 55);
            lblCampoObligatorio.Name = "lblCampoObligatorio";
            lblCampoObligatorio.Size = new Size(15, 19);
            lblCampoObligatorio.TabIndex = 7;
            lblCampoObligatorio.Text = "*";
            // 
            // lblCamposObligatorios
            // 
            lblCamposObligatorios.AutoSize = true;
            lblCamposObligatorios.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCamposObligatorios.ForeColor = Color.Red;
            lblCamposObligatorios.Location = new Point(25, 21);
            lblCamposObligatorios.Name = "lblCamposObligatorios";
            lblCamposObligatorios.Size = new Size(123, 16);
            lblCamposObligatorios.TabIndex = 13;
            lblCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Custom;
            dtpFechaNac.Location = new Point(170, 204);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(153, 25);
            dtpFechaNac.TabIndex = 12;
            dtpFechaNac.ValueChanged += dtpFechaNac_ValueChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(28, 384);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(62, 19);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Teléfono";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(23, 207);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(139, 19);
            lblFechaNac.TabIndex = 10;
            lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 108);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 19);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(28, 162);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 19);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(28, 55);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(34, 19);
            lblDNI.TabIndex = 7;
            lblDNI.Text = "DNI";
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.BackColor = Color.FromArgb(16, 157, 115);
            btnAgregarPaciente.FlatStyle = FlatStyle.Flat;
            btnAgregarPaciente.Image = Properties.Resources.plus;
            btnAgregarPaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarPaciente.Location = new Point(73, 539);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Size = new Size(149, 36);
            btnAgregarPaciente.TabIndex = 6;
            btnAgregarPaciente.Text = "Agregar Paciente";
            btnAgregarPaciente.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarPaciente.UseVisualStyleBackColor = false;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(170, 382);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(153, 25);
            txtTelefono.TabIndex = 3;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(170, 159);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(153, 25);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(170, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(153, 25);
            txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Location = new Point(170, 52);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(153, 25);
            txtDNI.TabIndex = 0;
            txtDNI.TextChanged += txtDNI_TextChanged;
            // 
            // errValidarTxtBox
            // 
            errValidarTxtBox.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.crowd;
            pictureBox1.Location = new Point(478, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // mnsNavegación
            // 
            mnsNavegación.BackColor = Color.FromArgb(16, 157, 115);
            mnsNavegación.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnsNavegación.Items.AddRange(new ToolStripItem[] { tsrPacientes, tsrHistoriasClinicas, tsrAntropometria, tsrPAMI, tsrSalir, acercaDeToolStripMenuItem, tsrMinimizar });
            mnsNavegación.Location = new Point(0, 0);
            mnsNavegación.Name = "mnsNavegación";
            mnsNavegación.Padding = new Padding(10);
            mnsNavegación.Size = new Size(1250, 75);
            mnsNavegación.TabIndex = 11;
            mnsNavegación.Text = "menuStrip1";
            // 
            // tsrPacientes
            // 
            tsrPacientes.DropDownItems.AddRange(new ToolStripItem[] { tsrAdminPacientes });
            tsrPacientes.Image = Properties.Resources.crowd;
            tsrPacientes.ImageAlign = ContentAlignment.TopCenter;
            tsrPacientes.ImageScaling = ToolStripItemImageScaling.None;
            tsrPacientes.Name = "tsrPacientes";
            tsrPacientes.Size = new Size(79, 55);
            tsrPacientes.Text = "Pacientes";
            tsrPacientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsrAdminPacientes
            // 
            tsrAdminPacientes.Name = "tsrAdminPacientes";
            tsrAdminPacientes.Size = new Size(211, 24);
            tsrAdminPacientes.Text = "Administrar Pacientes";
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
            tsrAntropometria.Image = Properties.Resources.body_mass;
            tsrAntropometria.ImageScaling = ToolStripItemImageScaling.None;
            tsrAntropometria.Name = "tsrAntropometria";
            tsrAntropometria.Size = new Size(111, 55);
            tsrAntropometria.Text = "Antropometría";
            tsrAntropometria.TextImageRelation = TextImageRelation.ImageAboveText;
            tsrAntropometria.Click += tsrAntropometria_Click;
            // 
            // tsrPAMI
            // 
            tsrPAMI.Image = Properties.Resources.retirement_plan;
            tsrPAMI.ImageScaling = ToolStripItemImageScaling.None;
            tsrPAMI.Name = "tsrPAMI";
            tsrPAMI.Size = new Size(55, 55);
            tsrPAMI.Text = "PAMI";
            tsrPAMI.TextImageRelation = TextImageRelation.ImageAboveText;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 157, 115);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1247, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 653);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 157, 115);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 725);
            panel2.Name = "panel2";
            panel2.Size = new Size(1247, 3);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 157, 115);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 650);
            panel3.TabIndex = 14;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(3, 75);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 650);
            splitter1.TabIndex = 16;
            splitter1.TabStop = false;
            // 
            // frmPacientes
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1250, 728);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(mnsNavegación);
            Controls.Add(pictureBox1);
            Controls.Add(grpAgregarPaciente);
            Controls.Add(dgvPacientes);
            Controls.Add(txtBuscarPacientes);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pacientes";
            Load += frmPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            grpAgregarPaciente.ResumeLayout(false);
            grpAgregarPaciente.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errValidarTxtBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mnsNavegación.ResumeLayout(false);
            mnsNavegación.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtBuscarPacientes;
        private DataGridView dgvPacientes;
        private Button btnEditarPaciente;
        private GroupBox grpAgregarPaciente;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtTelefono;
        private Button btnAgregarPaciente;
        private Label lblFechaNac;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblTelefono;
        private DateTimePicker dtpFechaNac;
        private Label lblCamposObligatorios;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblCampoObligatorio;
        private Label lblNAfiliado;
        private Label label3;
        private TextBox txtCodigoPais;
        private Label lblCodigoPais;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblObraSocial;
        private TextBox txtNAfiliado;
        //private FontAwesome.Sharp.IconButton btnBorrarBusqueda;
        private ErrorProvider errValidarTxtBox;
        private Label LblCalle;
        private TextBox TxtCalle;
        private Label LblPais;
        private TextBox TxtAltura;
        private Label LblAltura;
        private Label LblProvincia;
        private ComboBox CboProvincia;
        private ComboBox CboPais;
        private TextBox TxtLocalidad;
        private Label LblLocalidad;
        private Button BtnLimpiarInputs;
        private PictureBox pictureBox1;
        private MenuStrip mnsNavegación;
        private ToolStripMenuItem tsrPacientes;
        private ToolStripMenuItem tsrAdminPacientes;
        private ToolStripMenuItem tsrHistoriasClinicas;
        private ToolStripMenuItem tsrAntropometria;
        private ToolStripMenuItem tsrSalir;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblOcupacion;
        private ComboBox cboEstadoCivil;
        private Label lblEstadoCivil;
        private Label lblSexo;
        private TextBox txtOcupacion;
        private TextBox txtEdad;
        private Label lblEdad;
        private ToolStripMenuItem tsrMinimizar;
        private ToolStripMenuItem tsrPAMI;
        private RadioButton rbSexoFem;
        private RadioButton rbSexoMasc;
        private RadioButton rbSinObraSocial;
        private RadioButton rbObraSocialPAMI;
        private Splitter splitter1;
        private Panel panel5;
        private Panel panel4;
    }
}