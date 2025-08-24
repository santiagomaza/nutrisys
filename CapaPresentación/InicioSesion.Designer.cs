namespace CapaPresentación
{
    partial class frmInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            picLogo = new PictureBox();
            lblTitulo = new Label();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            picNombreUsuario = new PictureBox();
            picContraseña = new PictureBox();
            btnIniciarSesión = new Button();
            errValidarIS = new ErrorProvider(components);
            BtnSalirSistema = new Button();
            lblTituloVersion = new Label();
            lblVersion = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNombreUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picContraseña).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errValidarIS).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(23, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(133, 111);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft YaHei", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(210, 79);
            lblTitulo.MinimumSize = new Size(20, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(439, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Inicio de sesión en NutriSys\r\n";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.ForeColor = SystemColors.WindowFrame;
            txtNombreUsuario.Location = new Point(280, 166);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Ingrese el nombre de usuario";
            txtNombreUsuario.Size = new Size(294, 33);
            txtNombreUsuario.TabIndex = 2;
            txtNombreUsuario.Validating += txtNombreUsuario_Validating;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = SystemColors.WindowFrame;
            txtContraseña.Location = new Point(280, 220);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Ingrese la contraseña";
            txtContraseña.Size = new Size(294, 33);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.Validating += txtContraseña_Validating;
            // 
            // picNombreUsuario
            // 
            picNombreUsuario.Image = Properties.Resources.username;
            picNombreUsuario.Location = new Point(234, 163);
            picNombreUsuario.Name = "picNombreUsuario";
            picNombreUsuario.Size = new Size(40, 36);
            picNombreUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            picNombreUsuario.TabIndex = 4;
            picNombreUsuario.TabStop = false;
            // 
            // picContraseña
            // 
            picContraseña.Image = Properties.Resources.key;
            picContraseña.Location = new Point(234, 217);
            picContraseña.Name = "picContraseña";
            picContraseña.Size = new Size(40, 36);
            picContraseña.SizeMode = PictureBoxSizeMode.StretchImage;
            picContraseña.TabIndex = 5;
            picContraseña.TabStop = false;
            // 
            // btnIniciarSesión
            // 
            btnIniciarSesión.BackColor = Color.FromArgb(16, 157, 115);
            btnIniciarSesión.FlatStyle = FlatStyle.Popup;
            btnIniciarSesión.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesión.ForeColor = SystemColors.ControlLight;
            btnIniciarSesión.Location = new Point(257, 281);
            btnIniciarSesión.Name = "btnIniciarSesión";
            btnIniciarSesión.Size = new Size(134, 46);
            btnIniciarSesión.TabIndex = 6;
            btnIniciarSesión.Text = "Iniciar Sesión";
            btnIniciarSesión.UseVisualStyleBackColor = false;
            btnIniciarSesión.Click += btnIniciarSesión_Click;
            // 
            // errValidarIS
            // 
            errValidarIS.ContainerControl = this;
            // 
            // BtnSalirSistema
            // 
            BtnSalirSistema.BackColor = Color.Red;
            BtnSalirSistema.FlatStyle = FlatStyle.Popup;
            BtnSalirSistema.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalirSistema.ForeColor = Color.White;
            BtnSalirSistema.Location = new Point(407, 281);
            BtnSalirSistema.Name = "BtnSalirSistema";
            BtnSalirSistema.Size = new Size(155, 46);
            BtnSalirSistema.TabIndex = 7;
            BtnSalirSistema.Text = "Salir del Sistema";
            BtnSalirSistema.UseVisualStyleBackColor = false;
            BtnSalirSistema.Click += BtnSalirSistema_Click;
            // 
            // lblTituloVersion
            // 
            lblTituloVersion.AutoSize = true;
            lblTituloVersion.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloVersion.Location = new Point(23, 428);
            lblTituloVersion.Name = "lblTituloVersion";
            lblTituloVersion.Size = new Size(156, 19);
            lblTituloVersion.TabIndex = 8;
            lblTituloVersion.Text = "Versión de la aplicación:";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersion.Location = new Point(175, 428);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(53, 19);
            lblVersion.TabIndex = 9;
            lblVersion.Text = "version";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 157, 115);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 466);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 3);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 157, 115);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(818, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 466);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 157, 115);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 466);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(16, 157, 115);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(815, 3);
            panel4.TabIndex = 13;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(821, 469);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblVersion);
            Controls.Add(lblTituloVersion);
            Controls.Add(BtnSalirSistema);
            Controls.Add(btnIniciarSesión);
            Controls.Add(picContraseña);
            Controls.Add(picNombreUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblTitulo);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio Sesión";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNombreUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picContraseña).EndInit();
            ((System.ComponentModel.ISupportInitialize)errValidarIS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblTitulo;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private PictureBox picNombreUsuario;
        private PictureBox picContraseña;
        private Button btnIniciarSesión;
        private ErrorProvider errValidarIS;
        private Button BtnSalirSistema;
        private Label lblVersion;
        private Label lblTituloVersion;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
