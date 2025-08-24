using CapaNegocios;
using CapaPresentación.Utils;
using System.Data;

namespace CapaPresentación
{
    public partial class frmPacientes : Form
    {
        private readonly CN_Pacientes paciente = new();
        private readonly CN_Paises cn_paises = new();
        private readonly CN_Provincias cn_provincias = new();
        private readonly CN_Domicilios domicilios = new();

        private string? idDomicilio = string.Empty;
        public frmPacientes()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
        }
        private void frmPacientes_Load(object sender, EventArgs e)
        {
            ListarPacientes();
            ListarPaises();

            CboProvincia.Enabled = false;
            btnEditarPaciente.Enabled = false;
            tsrPacientes.Enabled = false;

            txtEdad.Enabled = false;

            cboEstadoCivil.SelectedItem = "Sin Especificar";

            rbSinObraSocial.Checked = true;

            dgvPacientes.ClearSelection();
        }
        private void LimpiarInputs()
        {
            dgvPacientes.ClearSelection();

            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaNac.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtCodigoPais.Text = "";
            txtNAfiliado.Text = "";
            TxtCalle.Text = "";
            TxtAltura.Text = "";
            TxtLocalidad.Text = "";
            CboPais.SelectedIndex = 0;
            CboProvincia.SelectedIndex = 0;
            cboEstadoCivil.SelectedItem = "Sin Especificar";

            if (rbSexoFem.Checked)
                rbSexoFem.Checked = false;
            else if (rbSexoMasc.Checked)
                rbSexoMasc.Checked = false;

            if (rbObraSocialPAMI.Checked)
                rbObraSocialPAMI.Checked = false;

            txtOcupacion.Text = "";
            txtEdad.Text = "";
        }
        private void ListarPaises()
        {
            try
            {
                DataTable paises = cn_paises.ListarPaises();
                DataRow filaNueva = paises.NewRow();

                filaNueva["ID_Pais"] = Guid.Empty;
                filaNueva["Nombre"] = "Seleccionar un pais...";
                paises.Rows.InsertAt(filaNueva, 0);

                if (paises != null)
                {
                    CboPais.DataSource = paises;

                    CboPais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    CboPais.AutoCompleteSource = AutoCompleteSource.ListItems;

                    CboPais.ValueMember = "ID_Pais";
                    CboPais.DisplayMember = "Nombre";

                    CboPais.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListarProvincias()
        {
            string pais = CboPais.Text.Trim();

            if (string.IsNullOrEmpty(pais))
            {
                CboProvincia.DataSource = null;
                CboProvincia.Enabled = false;
                return;
            }

            try
            {
                DataTable provincias = cn_provincias.ListarProvincias(pais);
                DataRow filaNueva = provincias.NewRow();

                filaNueva["ID_Provincia"] = Guid.Empty;
                filaNueva["Nombre"] = "Seleccionar una provincia...";
                provincias.Rows.InsertAt(filaNueva, 0);

                if (provincias != null && provincias.Rows.Count > 0)
                {
                    CboProvincia.DataSource = provincias;
                    CboProvincia.ValueMember = "ID_Provincia";
                    CboProvincia.DisplayMember = "Nombre";
                    CboProvincia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    CboProvincia.AutoCompleteSource = AutoCompleteSource.ListItems;
                    CboProvincia.SelectedIndex = 0;
                    CboProvincia.Enabled = true;
                }
                else
                {
                    CboProvincia.DataSource = null;
                    CboProvincia.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListarPacientes()
        {
            List<string> columnas = ["Id_Domicilio", "Id_Pais", "Id_Provincia", "ID_Paciente", "Paciente"];

            try
            {
                DataTable dt = paciente.ListarPacientes();

                BindingSource bs = new();
                bs.DataSource = dt;
                dgvPacientes.DataSource = bs;

                foreach (DataGridViewColumn col in dgvPacientes.Columns)
                {
                    if (columnas.Contains(col.Name))
                    {
                        col.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nAl parecer la tabla Pacientes no existe en la base de datos", "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            bool validarDNI = Validaciones.ValidacionCampos(txtDNI, errValidarTxtBox, obligatorio: true, numerico: true);
            bool validarNombre = Validaciones.ValidacionCampos(txtNombre, errValidarTxtBox, obligatorio: true, soloTexto: true);
            bool validarApellido = Validaciones.ValidacionCampos(txtApellido, errValidarTxtBox, obligatorio: true, soloTexto: true);
            bool validarCodigoPais = Validaciones.ValidacionCampos(txtCodigoPais, errValidarTxtBox, obligatorio: true, numerico: true);
            bool validarTelefono = Validaciones.ValidacionCampos(txtTelefono, errValidarTxtBox, obligatorio: true, numerico: true);

            if (!validarDNI || !validarNombre || !validarApellido || !validarCodigoPais || !validarTelefono)
            {
                return;
            }

            if (dtpFechaNac.Value > DateTime.Now)
            {
                MessageBox.Show("No se puede establecer una fecha mayor a la actual", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Int64 dni = Int64.Parse(txtDNI.Text.Trim());
            string nombre = txtNombre.Text.Trim(), 
                apellido = txtApellido.Text.Trim(), 
                localidad = TxtLocalidad.Text.Trim();

            string? calle = TxtCalle.Text.Trim(), 
                email = txtEmail.Text.Trim(), 
                obraSocial = string.Empty;

            DateTime fechaNacimiento = dtpFechaNac.Value;
          
            long n_telefono = long.Parse(txtTelefono.Text.Trim());
            int? numeracion = null;
            string? n_afiliado = txtNAfiliado.Text.Trim();
            int codigoPais = int.Parse(txtCodigoPais.Text.Trim());

            string codigoPais_str = Convert.ToString(codigoPais), 
                n_telefono_str = Convert.ToString(n_telefono);

            string telefono_str = string.Join("", codigoPais_str, n_telefono_str);

            long telefono = long.Parse(telefono_str);
            string sexo = string.Empty;
            string estadoCivil = cboEstadoCivil.SelectedItem?.ToString();
            string ocupacion = txtOcupacion.Text.Trim();

            if (rbSexoMasc.Checked)
            {
                sexo = rbSexoMasc.Text.ToString().Trim();
            }
            else if (rbSexoFem.Checked)
            {
                sexo = rbSexoFem.Text.ToString().Trim();
            }

            if (int.TryParse(TxtAltura.Text.Trim(), out int num))
            {
                numeracion = num;
            }

            if (rbSinObraSocial.Checked)
                obraSocial = rbSinObraSocial.Text.ToString().Trim();
            else if(rbObraSocialPAMI.Checked)
                obraSocial = rbObraSocialPAMI.Text.ToString().Trim();

            try
            {
                Guid idPais = Guid.Empty;
                Guid idProvincia = Guid.Empty;

                if (CboPais.SelectedValue != null && Guid.TryParse(CboPais.SelectedValue.ToString(), out Guid pais))
                    idPais = pais;

                if (CboProvincia.SelectedValue != null && Guid.TryParse(CboProvincia.SelectedValue.ToString(), out Guid provincia))
                    idProvincia = provincia;

                bool hayDatosDomicilio = (!string.IsNullOrWhiteSpace(calle) || numeracion.HasValue || !string.IsNullOrWhiteSpace(localidad)) || idPais != Guid.Empty || idProvincia != Guid.Empty;

                Guid idDomicilio = Guid.Empty;

                if (hayDatosDomicilio)
                {
                    idDomicilio = Guid.NewGuid();

                    var resultado = domicilios.InsertarDomicilio(idDomicilio, calle, numeracion, idPais, idProvincia, localidad);

                    if (resultado != CapaNegocios.Enums.CodigosStatus.Ok)
                    {
                        MessageBox.Show("Error al insertar el domicilio", "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                bool registrado;

                registrado = paciente.InsertarPaciente(dni, nombre, apellido, fechaNacimiento, telefono, idDomicilio, idPais, n_afiliado, obraSocial, email, out string mensaje, sexo, estadoCivil, ocupacion);
                MessageBox.Show(mensaje, registrado ? "NutrisysÉxito" : "NutrisysError", MessageBoxButtons.OK);

                if (registrado)
                {
                    ListarPacientes();
                    LimpiarInputs();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvPacientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una casilla correcta", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                btnAgregarPaciente.Enabled = false;

                var fila = dgvPacientes.Rows[e.RowIndex];

                try
                {
                    string? celdaDNI = fila.Cells["DNI"].Value.ToString();
                    string? celdaNombre = fila.Cells["Nombre"].Value.ToString();
                    string? celdaApellido = fila.Cells["Apellido"].Value.ToString();
                    string? celdaTelefono = fila.Cells["Telefono"].Value?.ToString() ?? "";
                    string? celdaDomicilio = fila.Cells["Domicilio"].Value.ToString();
                    string? celdaNAfiliado = fila.Cells["N° Afiliado"].Value.ToString();
                    string? celdaEmail = fila.Cells["Email"].Value.ToString();
                    string? celdaSexo = fila.Cells["Sexo"].Value?.ToString();
                    string? celdaEstadoCivil = fila.Cells["Estado Civil"].Value?.ToString();
                    string? celdaOcupacion = fila.Cells["Ocupación"].Value?.ToString();
                    string? celdaObraSocial = fila.Cells["Obra Social"].Value.ToString();
                    string? celdaIdDomicilio = fila.Cells["Id_Domicilio"].Value?.ToString();
                    string? dniSinPuntos = celdaDNI?.Replace(".", "");
                    DateTime celdaFecha = DateTime.Parse(fila.Cells["Fecha de Nacimiento"].Value.ToString());

                    string? codigoPais = CodigosPais.DetectarCodigoPais(celdaTelefono);

                    if (Guid.TryParse(fila.Cells["Id_Pais"].Value?.ToString(), out Guid paisGuid))
                        CboPais.SelectedValue = paisGuid;
                    else
                        CboPais.SelectedIndex = -1;

                    if (Guid.TryParse(fila.Cells["Id_Provincia"].Value?.ToString(), out Guid provinciaGuid))
                    {
                        CboProvincia.SelectedValue = provinciaGuid;
                        CboProvincia.Enabled = true;
                    }
                    else
                    {
                        CboProvincia.SelectedIndex = -1;
                        CboProvincia.Enabled = false;
                    }

                    if (codigoPais != null)
                    {
                        string numero = celdaTelefono.Substring(codigoPais.Length);
                        txtCodigoPais.Text = codigoPais;
                        txtTelefono.Text = numero;
                    }
                    else
                    {
                        txtCodigoPais.Text = "";
                        txtTelefono.Text = celdaTelefono;
                    }

                    txtDNI.Text = dniSinPuntos;
                    txtNombre.Text = celdaNombre;
                    txtApellido.Text = celdaApellido;
                    dtpFechaNac.Value = celdaFecha;

                    ParsearDomicilio(celdaDomicilio);

                    if (celdaSexo == "Masculino")
                        rbSexoMasc.Checked = true;
                    else if (celdaSexo == "Femenino")
                        rbSexoFem.Checked = true;
                    else
                        return;

                    if (celdaObraSocial == "Ninguna")
                        rbSinObraSocial.Checked = true;
                    else
                        rbObraSocialPAMI.Checked = true;

                    txtNAfiliado.Text = celdaNAfiliado;
                    txtEmail.Text = celdaEmail;
                    cboEstadoCivil.SelectedItem = celdaEstadoCivil;
                    txtOcupacion.Text = celdaOcupacion;

                    if (!string.IsNullOrEmpty(celdaIdDomicilio))
                        idDomicilio = celdaIdDomicilio;
                    else
                        idDomicilio = string.Empty;

                    btnEditarPaciente.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            Guid idPais = Guid.Empty, idProvincia = Guid.Empty;
            Guid? id_domicilio = null;

            if (CboPais.SelectedValue != null && Guid.TryParse(CboPais.SelectedValue.ToString(), out Guid pais))
            {
                idPais = pais;
            }

            if (CboProvincia.SelectedValue != null && Guid.TryParse(CboProvincia.SelectedValue.ToString(), out Guid provincia))
            {
                idProvincia = provincia;
            }

            string dni_actual = dgvPacientes.CurrentRow.Cells["DNI"].Value?.ToString();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string localidad = TxtLocalidad.Text.Trim();
            string email = txtEmail.Text.Trim();
            string? obraSocial = string.Empty;
            string? calle = TxtCalle.Text.Trim();
            int dni_nuevo = int.Parse(txtDNI.Text.Trim());
            int codigoPais = int.Parse(txtCodigoPais.Text.Trim());
            DateTime fechaNacimiento = dtpFechaNac.Value;
            long n_telefono = long.Parse(txtTelefono.Text.Trim());
            int? numeracion = int.TryParse(TxtAltura.Text.Trim(), out int n) ? n : null;
            string? n_afiliado = txtNAfiliado.Text.Trim();
            string? sexo = string.Empty;
            string estadoCivil = cboEstadoCivil.SelectedItem?.ToString();
            string ocupacion = txtOcupacion.Text.Trim();

            string codigoPais_str = Convert.ToString(codigoPais);
            string n_telefono_str = Convert.ToString(n_telefono);

            string telefono_str = string.Join("", codigoPais_str, n_telefono_str);

            long telefono = long.Parse(telefono_str);

            if (rbSexoMasc.Checked)
            {
                sexo = rbSexoMasc.Text.ToString().Trim();
            }
            else if (rbSexoFem.Checked)
            {
                sexo = rbSexoFem.Text.ToString().Trim();
            }

            if (rbSinObraSocial.Checked)
                obraSocial = rbSinObraSocial.Text.ToString().Trim();
            else if (rbObraSocialPAMI.Checked)
                obraSocial = rbObraSocialPAMI.Text.ToString().Trim();

            try
            {
                if (dtpFechaNac.Value > DateTime.Now)
                {
                    MessageBox.Show("No se puede establecer una fecha mayor a la actual", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(calle) || numeracion.HasValue || !string.IsNullOrWhiteSpace(localidad))
                {
                    if (Guid.TryParse(idDomicilio, out Guid domicilioExistenteID))
                    {
                        domicilios.EditarDomicilio(domicilioExistenteID, calle, numeracion, idPais, idProvincia, localidad);
                    }
                    else
                    {
                        Guid? domicilioExistente = domicilios.BuscarDomicilio(calle, numeracion, idPais, idProvincia, localidad);

                        if (domicilioExistente.HasValue)
                        {
                            id_domicilio = domicilioExistente.Value;
                        }
                        else
                        {
                            Guid nuevoDomicilio = Guid.NewGuid();
                            var resultado = domicilios.InsertarDomicilio(nuevoDomicilio, calle, numeracion, idPais, idProvincia, localidad);

                            if (resultado == CapaNegocios.Enums.CodigosStatus.Ok)
                                id_domicilio = nuevoDomicilio;
                            else
                                MessageBox.Show("Error al insertar el domicilio", "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                paciente.EditarPaciente(dni_nuevo, dni_actual, nombre, apellido, fechaNacimiento, telefono, idPais, id_domicilio, n_afiliado, obraSocial, email, sexo, estadoCivil, ocupacion);
                MessageBox.Show("Paciente editado correctamente", "NutrisysExito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnAgregarPaciente.Enabled = true;
                btnEditarPaciente.Enabled = false;

                LimpiarInputs();
                ListarPacientes();
                dgvPacientes.ClearSelection();
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show(argEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error:\n\n" + ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ParsearDomicilio(string domicilio)
        {
            string[] partes = domicilio.Split(',');

            if (partes.Length >= 3)
            {
                string calleYNumero = partes[0].Trim();
                string[] calleNumeroSplit = calleYNumero.Split(' ');

                if (calleNumeroSplit.Length >= 2 && int.TryParse(calleNumeroSplit.Last(), out int numero))
                {
                    string calle = string.Join(" ", calleNumeroSplit.Take(calleNumeroSplit.Length - 1));

                    TxtCalle.Text = calle;
                    TxtAltura.Text = numero.ToString();
                }
                else
                {
                    TxtCalle.Text = calleYNumero;
                    TxtAltura.Text = "";
                }

                TxtLocalidad.Text = partes[1].Trim();
            }
            else
            {
                TxtCalle.Text = "";
                TxtAltura.Text = "";
                TxtLocalidad.Text = "";
                CboProvincia.Text = "";
            }
        }
        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscarPacientes.Text = "";
        }
        private void txtBuscarPacientes_TextChanged(object sender, EventArgs e)
        {
            string caracteres = txtBuscarPacientes.Text.Trim();

            if (txtBuscarPacientes.Text == "")
            {
                ListarPacientes();
            }

            List<string> columnas = ["Estado", "Id_Domicilio", "Id_Pais", "Id_Provincia", "ID_Paciente", "Paciente"];

            DataTable dt = paciente.BuscarPaciente(caracteres);

            dgvPacientes.DataSource = dt;

            foreach (DataGridViewColumn col in dgvPacientes.Columns)
            {
                if (columnas.Contains(col.Name))
                {
                    col.Visible = false;
                }
            }
        }
        private void CboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboPais.SelectedIndex > -1 && !string.IsNullOrWhiteSpace(CboPais.Text))
            {
                ListarProvincias();
            }
            else
            {
                CboProvincia.DataSource = null;
                CboProvincia.Items.Clear();
                CboProvincia.Enabled = false;
            }
        }
        private void CboPais_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CboPais.Text) || CboPais.SelectedIndex == -1)
                CboPais.SelectedIndex = 0;
        }
        private void CboProvincia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CboProvincia.Text) || CboProvincia.SelectedIndex == -1)
                CboProvincia.SelectedIndex = 0;
        }
        private void BtnLimpiarInputs_Click(object sender, EventArgs e)
        {
            LimpiarInputs();
            btnEditarPaciente.Enabled = false;
            btnEditarPaciente.Enabled = false;
            btnAgregarPaciente.Enabled = true;
        }
        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dtpFechaNac.Value;
            DateTime hoy = DateTime.Today;

            int edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > hoy.AddYears(-edad))
            {
                edad--;
            }

            txtEdad.Text = edad.ToString();
        }
        private void tsrHistoriasClinicas_Click(object sender, EventArgs e)
        {
            frmHistoriasClinicas histCl = new();

            this.Close();

            histCl.Show();
        }
        private void tsrAntropometria_Click(object sender, EventArgs e)
        {
            frmAntropometria antropometria = new();

            this.Close();

            antropometria.Show();
        }
        private void tsrSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe acercaDe = new();

            acercaDe.ShowDialog();
        }
        private void tsrMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}