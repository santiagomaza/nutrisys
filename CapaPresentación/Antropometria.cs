using System.Data;
using CapaEntidades;
using CapaNegocios;
using CapaNegocios.Enums;
using CapaPresentación.Utils;

namespace CapaPresentación
{
    public partial class frmAntropometria : Form
    {
        private CN_Antropometrias antropometria = new();
        private CN_Pacientes pacientes = new();

        private string? idPaciente = string.Empty, idAntropometria = string.Empty;

        private DataTable tablaOriginal;

        public frmAntropometria()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
        }
        private void frmAntropometria_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;

            DateTime primerDiaDelMes = new(hoy.Year, hoy.Month, 1);
            DateTime ultimoDiaDelMes = primerDiaDelMes.AddMonths(1).AddDays(-1);

            dtpDesde.Value = primerDiaDelMes;
            dtpHasta.Value = ultimoDiaDelMes;

            grpAntropometria.Enabled = false;
            cboPacientes.Enabled = false;
            tsrAntropometria.Enabled = false;
            btnMostrarDatosAnt.Enabled = false;
            btnBuscarPaciente.Enabled = false;
            btnFiltrarFechas.Enabled = false;

            lblPacienteDA.Visible = false;
            lblTituloPaciente.Visible = false;
            LblFUM.Visible = false;
            LblFUMod.Visible = false;
            btnQuitarFiltro.Visible = false;

            this.MaximizeBox = false;

            dgvDatosAntropometricos.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
            dgvDatosAntropometricos.MultiSelect = false;
        }
        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string paciente = txtBuscarPaciente.Text.Trim();

            try
            {
                DataTable tablaPacientes = pacientes.FiltrarPaciente(paciente);

                if (tablaPacientes.Rows.Count == 0)
                {
                    MessageBox.Show("El paciente ingresado no esta registrado en la base de datos");
                    return;
                }

                if (tablaPacientes.Rows.Count > 0)
                {
                    DataRow nuevaFila = tablaPacientes.NewRow();
                    nuevaFila["ID_Paciente"] = Guid.Empty;
                    nuevaFila["Paciente"] = "Seleccionar un paciente...";
                    tablaPacientes.Rows.InsertAt(nuevaFila, 0);

                    cboPacientes.DataSource = tablaPacientes;

                    cboPacientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cboPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;

                    cboPacientes.ValueMember = "ID_Paciente";
                    cboPacientes.DisplayMember = "Paciente";

                    grpAntropometria.Enabled = false;
                    btnMostrarDatosAnt.Enabled = false;
                    cboPacientes.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMostrarDatosAnt_Click(object sender, EventArgs e)
        {
            if (cboPacientes.SelectedIndex == 0)
            {
                MessageBox.Show("Debes seleccionar un paciente primero", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Guid pacienteID = Guid.Parse(cboPacientes.SelectedValue.ToString());

            ListarDatosAntropometricos(pacienteID);

            dgvDatosAntropometricos.ClearSelection();
        }
        private void ListarDatosAntropometricos(Guid pacienteID)
        {
            try
            {
                DataTable datosOriginales = antropometria.MostrarDatosAntropometricosPaciente(pacienteID);

                if (datosOriginales.Rows.Count == 0)
                {
                    DialogResult resultado = MessageBox.Show("El paciente ingresado no tiene datos antropométricos cargados. ¿Deseas agregar un nuevo dato?", "NutrisysInfo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    if (resultado == DialogResult.OK)
                    {
                        HabilitarInputs();

                        btnEditarDatos.Enabled = false;
                        btnFiltrarFechas.Enabled = false;
                        txtIMC.Enabled = false;
                    }
                    else
                        return;
                }

                if (datosOriginales.Rows.Count > 0)
                {
                    tablaOriginal = antropometria.MostrarDatosAntropometricosPaciente(pacienteID);

                    VerificarDatos(datosOriginales);

                    MostrarUltimaFechaModificacion(pacienteID);

                    grpAntropometria.Enabled = true;
                    btnEditarDatos.Enabled = false;
                    btnFiltrarFechas.Enabled = true;
                    txtIMC.Enabled = false;

                    LblFUM.Visible = true;
                    LblFUMod.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFiltrarFechas_Click(object sender, EventArgs e)
        {
            try
            {
                Guid idPaciente = Guid.Parse(cboPacientes.SelectedValue?.ToString());

                if (dtpDesde.Value > DateTime.Now)
                {
                    MessageBox.Show("No se puede establecer una fecha mayor a la actual", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DateTime fechaInicio = dtpDesde.Value;
                DateTime fechaFin = dtpHasta.Value;

                DataTable listaDatosAntropometricosFiltrados = antropometria.FiltrarDatosAntropometricos(idPaciente, fechaInicio, fechaFin);

                if (listaDatosAntropometricosFiltrados.Rows.Count >= 0)
                {
                    tablaOriginal = antropometria.FiltrarDatosAntropometricos(idPaciente, fechaInicio, fechaFin);

                    VerificarDatos(tablaOriginal);

                    btnQuitarFiltro.Visible = true;
                }
                else
                {
                    btnQuitarFiltro.Visible = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            Guid idPaciente = Guid.Parse(cboPacientes.SelectedValue?.ToString());

            ListarDatosAntropometricos(idPaciente);

            btnQuitarFiltro.Visible = false;
        }
        private void HabilitarInputs()
        {
            txtPeso.Enabled = true;
            txtTalla.Enabled = true;
            txtPorcGC.Enabled = true;
            txtNivelGV.Enabled = true;
            txtMusculoEsqueletico.Enabled = true;
            txtEdadCorporal.Enabled = true;
            dtpFechaEvolucion.Enabled = true;
            btnLimpiarInputs.Enabled = true;
            grpAntropometria.Enabled = true;
            btnFiltrarFechas.Enabled = true;
        }
        private void VerificarDatos(DataTable datosOriginales)
        {
            if (datosOriginales != null && datosOriginales.Rows.Count > 0)
            {
                LblFUM.Visible = true;
                LblFUMod.Visible = true;

                var pacienteID = datosOriginales.Rows[0]["ID_Paciente"].ToString();

                var datosFiltrados = datosOriginales.AsEnumerable()
                    .Where(row => row["ID_Paciente"].ToString() == pacienteID)
                    .CopyToDataTable();

                if (datosOriginales.Columns.Contains("Paciente") && datosOriginales.Rows[0]["Paciente"] != DBNull.Value)
                {
                    lblPacienteDA.Visible = true;
                    lblTituloPaciente.Visible = true;

                    lblPacienteDA.Text = datosOriginales.Rows[0]["Paciente"]?.ToString()?.ToUpperInvariant();
                }

                if (datosOriginales.Columns.Contains("ID_Paciente") && datosOriginales.Rows[0]["ID_Paciente"] != DBNull.Value)
                {
                    idPaciente = datosOriginales.Rows[0]["ID_Paciente"].ToString();
                }

                if (datosOriginales.Columns.Contains("ID_Antropometria") && datosOriginales.Rows[0]["ID_Antropometria"] != DBNull.Value)
                {
                    idAntropometria = datosOriginales.Rows[0]["ID_Antropometria"].ToString();
                }

                DataTable dgvTranspuesto = TransponerParaInforme(datosOriginales);

                ConfigurarDataGridViewTranspuesto(dgvDatosAntropometricos, dgvTranspuesto);

                LimpiarFilasInnecesarias(dgvDatosAntropometricos);
            }
        }
        private void MostrarUltimaFechaModificacion(Guid pacienteID)
        {
            DateTime? fecha = antropometria.ObtenerUltimaFechaModificacion(pacienteID);
            if (fecha.HasValue)
            {
                LblFUM.Visible = true;
                LblFUMod.Visible = true;
                LblFUMod.Text = fecha.Value.ToString("dd/MM/yyyy HH:mm:ss");
            }
            else
            {
                LblFUM.Visible = false;
                LblFUMod.Visible = false;
            }
        }
        private void ConfigurarDataGridViewTranspuesto(DataGridView dgv, DataTable tabla)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            dgv.DataSource = tabla;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgv.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;

            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
        }
        private void LimpiarFilasInnecesarias(DataGridView transpuesto)
        {
            foreach (DataGridViewRow row in transpuesto.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells["Indicador"] != null && row.Cells["Indicador"].Value != null)
                {
                    string valorIndicador = row.Cells["Indicador"].Value.ToString();

                    List<string> columnasDGV = new List<string>
                    {
                        "ID_Paciente", "Paciente", "ID_Antropometria", "FechaUltimaModificacion"
                    };

                    foreach (var indicador in columnasDGV)
                    {
                        if (indicador.Equals(valorIndicador))
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
        }
        private void btnAgregarDatos_Click(object sender, EventArgs e)
        {
            bool validarPeso = Validaciones.ValidacionCampos(txtPeso, errAntropometria, numerico: true, n_decimal: true);
            bool validarTalla = Validaciones.ValidacionCampos(txtTalla, errAntropometria, numerico: true, n_decimal: true);
            bool validarIMC = Validaciones.ValidacionCampos(txtIMC, errAntropometria, numerico: true, n_decimal: true);
            bool validarMusculoEsqueletico = Validaciones.ValidacionCampos(txtMusculoEsqueletico, errAntropometria, numerico: true, n_decimal: true);
            bool validarPorcentajeGrasaCorp = Validaciones.ValidacionCampos(txtPorcGC, errAntropometria, numerico: true, n_decimal: true);
            bool validarNivelGrasaVisceral = Validaciones.ValidacionCampos(txtNivelGV, errAntropometria, numerico: true, n_decimal: true);
            bool validarEdadCorporal = Validaciones.ValidacionCampos(txtEdadCorporal, errAntropometria, numerico: true, entero: true);

            if (!validarPeso || !validarTalla || !validarIMC || !validarMusculoEsqueletico || !validarPorcentajeGrasaCorp || !validarNivelGrasaVisceral || !validarEdadCorporal)
            {
                return;
            }

            if ((Guid)cboPacientes.SelectedValue == Guid.Empty)
            {
                MessageBox.Show("Debes seleccionar un paciente primero", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dtpFechaEvolucion.Value > DateTime.Now)
            {
                MessageBox.Show("No se puede establecer una fecha mayor a la actual", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Guid id_Paciente = Guid.Parse(cboPacientes.SelectedValue.ToString());

            if (idAntropometria == null)
            {
                return;
            }

            try
            {
                DatoAntropometrico DAObj = new DatoAntropometrico(
                    idPaciente: id_Paciente,
                    peso: string.IsNullOrWhiteSpace(txtPeso.Text) ? null : Convert.ToDecimal(txtPeso.Text.Trim()),
                    talla: string.IsNullOrWhiteSpace(txtTalla.Text) ? null : Convert.ToDecimal(txtTalla.Text.Trim()),
                    imc: null,
                    musculoEsqueletico: string.IsNullOrWhiteSpace(txtMusculoEsqueletico.Text) ? null : Convert.ToDecimal(txtMusculoEsqueletico.Text.Trim()),
                    porcentajeGC: string.IsNullOrWhiteSpace(txtPorcGC.Text) ? null : Convert.ToDecimal(txtPorcGC.Text.Trim()),
                    nivelGV: string.IsNullOrWhiteSpace(txtNivelGV.Text) ? null : Convert.ToDecimal(txtNivelGV.Text.Trim()),
                    edadCorporal: string.IsNullOrWhiteSpace(txtEdadCorporal.Text) ? null : Convert.ToInt32(txtEdadCorporal.Text.Trim()),
                    fechaEvolucion: dtpFechaEvolucion.Value
                );

                var resultado = antropometria.AgregarDatoAntropometrico(DAObj);

                if (resultado == CapaNegocios.Enums.CodigosStatus.Ok)
                {
                    MessageBox.Show("Dato antropometrico agregado correctamente", "NutrisysExito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarInputs();
                    ReListarDatosAntropometricos(id_Paciente);

                    if (sender == btnBuscarPaciente)
                    {
                        lblTituloPaciente.Visible = true;
                        lblPacienteDA.Visible = true;
                    }
                }
                else if (resultado == CapaNegocios.Enums.CodigosStatus.Duplicado)
                {
                    MessageBox.Show("El dato antropometrico que estas ingresando ya existe en la base de datos", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hubo un error al cargar los datos antropometricos. Comprobar que los datos estan bien ingresados", "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show(argEx.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable TransponerParaInforme(DataTable datosOriginales)
        {
            Dictionary<string, string> formatearNombres = new Dictionary<string, string>
            {
                { "Peso", "Peso (kg)" },
                { "Talla", "Talla (m)" },
                { "IMC", "IMC" },
                { "MusculoEsqueletico", "Músculo Esquelético" },
                { "PorcentajeGC", "% Grasa Corporal" },
                { "NivelGV", "Nivel de Grasa Visceral" },
                { "EdadCorporal", "Edad Corporal" }
            };

            DataTable transpuesto = new DataTable();
            HashSet<string> fechasYaAgregadas = new HashSet<string>();

            transpuesto.Columns.Add("Indicador");

            foreach (DataRow fila in datosOriginales.Rows)
            {
                string fecha = Convert.ToDateTime(fila["Evolucion"]).ToString("dd/MM/yyyy");

                if (!fechasYaAgregadas.Contains(fecha) && !string.IsNullOrEmpty(fecha))
                {
                    transpuesto.Columns.Add(fecha);
                    fechasYaAgregadas.Add(fecha);
                }
            }

            foreach (DataColumn columna in datosOriginales.Columns)
            {
                if (columna.ColumnName == "Evolucion") continue;

                DataRow nuevaFila = transpuesto.NewRow();

                nuevaFila["Indicador"] = formatearNombres.ContainsKey(columna.ColumnName)
                    ? formatearNombres[columna.ColumnName]
                    : columna.ColumnName;

                foreach (DataRow fila in datosOriginales.Rows)
                {
                    string fecha = Convert.ToDateTime(fila["Evolucion"]).ToString("dd/MM/yyyy");

                    if (transpuesto.Columns.Contains(fecha))
                    {
                        nuevaFila[fecha] = fila[columna];
                    }
                }

                transpuesto.Rows.Add(nuevaFila);
            }

            return transpuesto;
        }
        private void txtFiltrarPaciente_TextChanged(object sender, EventArgs e)
        {
            btnBuscarPaciente.Enabled = txtBuscarPaciente.Text.Trim().Length >= 3;

            if (txtBuscarPaciente.Text == "")
            {
                dgvDatosAntropometricos.DataSource = null;

                btnMostrarDatosAnt.Enabled = false;
                lblTituloPaciente.Visible = false;

                lblPacienteDA.Text = "";
                LblFUMod.Text = "";
                LblFUM.Text = "";

                cboPacientes.SelectedIndex = -1;
                cboPacientes.Enabled = false;

                grpAntropometria.Enabled = false;

                LimpiarInputs();
            }
        }
        private bool LimpiarInputs()
        {
            txtPeso.Text = "";
            txtTalla.Text = "";
            txtIMC.Text = "";
            txtMusculoEsqueletico.Text = "";
            txtPorcGC.Text = "";
            txtNivelGV.Text = "";
            txtEdadCorporal.Text = "";
            dtpFechaEvolucion.Text = "";

            return true;
        }
        private void dgvDatosAntropometricos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Seleccione una columna correcta");
                return;
            }

            string fechaSeleccionada = dgvDatosAntropometricos.Columns[e.ColumnIndex].HeaderText;

            btnAgregarDatos.Enabled = false;
            btnEditarDatos.Enabled = true;

            foreach (DataGridViewRow fila in dgvDatosAntropometricos.Rows)
            {
                string? indicador = fila.Cells[0].Value?.ToString();

                string? valor = fila.Cells[e.ColumnIndex].Value?.ToString();

                switch (indicador)
                {
                    case "Peso (kg)":
                        txtPeso.Text = valor;
                        break;
                    case "Talla (m)":
                        txtTalla.Text = valor;
                        break;
                    case "IMC":
                        txtIMC.Text = valor;
                        break;
                    case "Músculo Esquelético":
                        txtMusculoEsqueletico.Text = valor;
                        break;
                    case "% Grasa Corporal":
                        txtPorcGC.Text = valor;
                        break;
                    case "Nivel de Grasa Visceral":
                        txtNivelGV.Text = valor;
                        break;
                    case "Edad Corporal":
                        txtEdadCorporal.Text = valor;
                        break;
                    case "ID_Antropometria":
                        idAntropometria = valor;
                        break;
                    default:
                        break;
                }

                dtpFechaEvolucion.Text = fechaSeleccionada;
            }
        }
        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            if (cboPacientes.SelectedValue == null)
            {
                MessageBox.Show("Debes seleccionar un paciente primero");
                return;
            }

            Guid id_Antropometria = Guid.Parse(idAntropometria);
            Guid id_Paciente = Guid.Parse(cboPacientes.SelectedValue.ToString());

            try
            {
                if (id_Antropometria == Guid.Empty)
                {
                    MessageBox.Show("Seleccione la columna a editar primero", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    DatoAntropometrico DAObj = new DatoAntropometrico(
                        idDatoAntropometrico: id_Antropometria,
                        idPaciente: id_Paciente,
                        peso: string.IsNullOrWhiteSpace(txtPeso.Text) ? null : Convert.ToDecimal(txtPeso.Text.Trim()),
                        talla: string.IsNullOrWhiteSpace(txtTalla.Text) ? null : Convert.ToDecimal(txtTalla.Text.Trim()),
                        imc: null,
                        musculoEsqueletico: string.IsNullOrWhiteSpace(txtMusculoEsqueletico.Text) ? null : Convert.ToDecimal(txtMusculoEsqueletico.Text.Trim()),
                        porcentajeGC: string.IsNullOrWhiteSpace(txtPorcGC.Text) ? null : Convert.ToDecimal(txtPorcGC.Text.Trim()),
                        nivelGV: string.IsNullOrWhiteSpace(txtNivelGV.Text) ? null : Convert.ToDecimal(txtNivelGV.Text.Trim()),
                        edadCorporal: string.IsNullOrWhiteSpace(txtEdadCorporal.Text) ? null : Convert.ToInt32(txtEdadCorporal.Text.Trim()),
                        fechaEvolucion: dtpFechaEvolucion.Value
                    );

                    var resultado = antropometria.EditarDatoAntropometrico(DAObj);

                    if (resultado == CapaNegocios.Enums.CodigosStatus.Ok)
                    {
                        MessageBox.Show("Dato antropométrico editado correctamente", "NutrisysExito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarInputs();

                        ReListarDatosAntropometricos(id_Paciente);

                        btnAgregarDatos.Enabled = true;
                        btnEditarDatos.Enabled = false;
                    }
                    else if (resultado == CapaNegocios.Enums.CodigosStatus.Error)
                    {
                        MessageBox.Show("Hubo un error al editar los datos antropométricos", "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void ReListarDatosAntropometricos(Guid pacienteID)
        {
            DataTable dt = antropometria.MostrarDatosAntropometricosPaciente(pacienteID);
            DateTime? fecha = antropometria.ObtenerUltimaFechaModificacion(pacienteID);

            VerificarDatos(dt);

            LblFUMod.Text = fecha.HasValue ? fecha.Value.ToString() : "Sin datos";
        }
        private void CboPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPacientes.SelectedIndex != -1 && cboPacientes.SelectedValue != null && txtBuscarPaciente.Text != "")
            {
                dgvDatosAntropometricos.DataSource = null;
                grpAntropometria.Enabled = false;

                btnMostrarDatosAnt.Enabled = true;

                LimpiarInputs();
                LblFUM.Visible = false;
                LblFUMod.Visible = false;
            }
            else
            {
                btnMostrarDatosAnt.Enabled = false;
            }
        }
        private void tsrPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes pacientes = new();

            pacientes.Show();
        }
        private void tsrHistoriasClinicas_Click(object sender, EventArgs e)
        {
            frmHistoriasClinicas historiasCl = new();

            historiasCl.Show();
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
        private void tsrPAMI_Click(object sender, EventArgs e)
        {
            frmPAMI pami = new();
            pami.Show();
        }
        private void tsrSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpiarInputs_Click(object sender, EventArgs e)
        {
            LimpiarInputs();

            btnAgregarDatos.Enabled = true;
            btnEditarDatos.Enabled = false;

            dgvDatosAntropometricos.ClearSelection();
        }
        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            bool validarPeso = Validaciones.ValidacionCampos(txtPeso, errAntropometria, numerico: true);

            if (!validarPeso)
                return;
            else
            {
                errAntropometria.SetError(txtPeso, "");
                CalcularIMC();
            }

        }
        private void txtTalla_TextChanged(object sender, EventArgs e)
        {
            bool validarTalla = Validaciones.ValidacionCampos(txtTalla, errAntropometria, numerico: true);

            if (!validarTalla)
                return;
            else
            {
                errAntropometria.SetError(txtTalla, "");

                CalcularIMC();
            }
        }
        private void CalcularIMC()
        {
            if (txtPeso.Text != "" && txtTalla.Text != "")
            {
                try
                {
                    decimal peso = Convert.ToDecimal(txtPeso.Text.Trim());
                    decimal talla = Convert.ToDecimal(txtTalla.Text.Trim());

                    if (talla > 0)
                    {
                        decimal imc = peso / (talla * talla);
                        txtIMC.Text = imc.ToString("0.00");
                    }
                    else
                    {
                        txtIMC.Text = "0";
                    }
                }
                catch (Exception)
                {
                    txtIMC.Text = "";
                    MessageBox.Show("Error al calcular el IMC: ", "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtIMC.Text = "";
            }
        }
    }
}