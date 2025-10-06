using System.Data;
using System.Diagnostics;
using CapaPresentación.Utils;

using CapaNegocios;

namespace CapaPresentación
{
    public partial class frmHistoriasClinicas : Form
    {
        private DetallesHistoriaClinica detalleSeleccionado;
        private CN_Diagnosticos diagnosticos = new();
        private CN_Pacientes pacientes = new();
        private CN_HistClinicasDiagnosticosPaciente intermedia = new();
        private readonly CN_HistoriasClinicas historiaClinica = new();

        private string?
            ruta_archivo = string.Empty,
            celdaRuta = string.Empty,
            ruta_archivo_original = string.Empty;

        private Guid idHistCl = Guid.Empty;
        private Guid idHistoriaClinicaGeneral = Guid.Empty;

        List<string> nombresDiagnosticosLBL = new();

        private Dictionary<string, string>
            nombreDiagnosticoDesdeBD = new(),
            DiccNombreDelDiagnostico = new();

        private Dictionary<string, bool> estadoTemporalDiagnosticos = new();
        public frmHistoriasClinicas()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
        }
        private void frmHistoriasClinicas_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;

            DateTime primerDiaDelMes = new(hoy.Year, hoy.Month, 1);
            DateTime ultimoDiaDelMes = primerDiaDelMes.AddMonths(1).AddDays(-1);

            dtpDesde.Value = primerDiaDelMes;
            dtpHasta.Value = ultimoDiaDelMes;

            grpHistClinicas.Enabled = false;
            cboPacientes.Enabled = false;
            tsrHistoriasClinicas.Enabled = false;
            BtnMostrarHC.Enabled = false;
            BtnBuscarPaciente.Enabled = false;
            btnFiltrarFechas.Enabled = false;

            BtnAbrirArchivo.Visible = false;
            btnQuitarArchivo.Enabled = false;
            BtnVerDetalles.Visible = false;
            LblFHUM.Visible = false;
            LblFHUMod.Visible = false;
            lblDiagnosticosBD.Visible = false;
            btnQuitarFiltro.Visible = false;

            txtTituloArchivo.ReadOnly = true;
        }
        private void BtnBuscarArchivo_Click(object sender, EventArgs e)
        {
            if (ofdPrueba.ShowDialog() == DialogResult.OK)
            {
                ruta_archivo = ofdPrueba?.FileName;
                string? nombreArchivo = Path.GetFileName(ruta_archivo);
                txtTituloArchivo.Text = nombreArchivo;
            }
        }
        private void BtnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string paciente = TxtBuscarPaciente.Text;
            try
            {
                DataTable resultado = pacientes.FiltrarPaciente(paciente);

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("El paciente ingresado no esta registrado en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (resultado.Rows.Count > 0)
                {
                    DataRow nuevaFila = resultado.NewRow();

                    nuevaFila["ID_Paciente"] = Guid.Empty;
                    nuevaFila["Paciente"] = "Seleccionar un paciente...";
                    resultado.Rows.InsertAt(nuevaFila, 0);

                    cboPacientes.Enabled = true;
                    cboPacientes.DataSource = resultado;

                    cboPacientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cboPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;

                    cboPacientes.ValueMember = "ID_Paciente";
                    cboPacientes.DisplayMember = "Paciente";

                    grpHistClinicas.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnMostrarHC_Click(object sender, EventArgs e)
        {
            if (cboPacientes.SelectedIndex == 0)
            {
                MessageBox.Show("Debes seleccionar un paciente primero.", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboPacientes.SelectedValue == null)
            {
                MessageBox.Show("El valor seleccionado es nulo.");
                return;
            }

            Guid pacienteId = Guid.Parse(cboPacientes.SelectedValue.ToString());

            ListarHistoriasClinicas(pacienteId);

            DgvHistClinicas.ClearSelection();
        }
        private void ListarHistoriasClinicas(Guid paciente)
        {
            try
            {
                DataTable listaHistoriasClinicas = historiaClinica.MostrarHistoriasClinicas(paciente);

                if (listaHistoriasClinicas.Rows.Count == 0)
                {
                    DialogResult resultado = MessageBox.Show("El paciente ingresado no tiene historia clinica cargada. ¿Deseas agregar una nueva?", "NutrisysInfo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    if (resultado == DialogResult.OK)
                    {
                        grpHistClinicas.Enabled = true;
                        btnFiltrarFechas.Enabled = true;
                        btnFiltrarFechas.Enabled = false;
                        BtnEditarHistClinica.Enabled = false;
                        BtnAgregarDiagnostico.Enabled = false;

                        ListarDiagnosticos();
                        ObtenerIDHistClinicaGeneralYDiagnosticosPaciente(paciente);
                    }
                    else
                        return;
                }

                if (listaHistoriasClinicas.Rows.Count > 0)
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = listaHistoriasClinicas;
                    DgvHistClinicas.DataSource = bindingSource;

                    DgvHistClinicas.Refresh();

                    DgvHistClinicas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    BtnAgregarDiagnostico.Enabled = false;

                    if (DgvHistClinicas.Columns.Contains("Ruta"))
                    {
                        DgvHistClinicas.Columns["Ruta"].Visible = false;
                    }

                    DgvHistClinicas.Columns["ID_HistCl"].Visible = false;
                    DgvHistClinicas.Columns["Id_Paciente"].Visible = false;
                    DgvHistClinicas.Columns["Paciente"].Visible = false;
                    DgvHistClinicas.Columns["FechaUltimaModificacion"].Visible = false;
                    DgvHistClinicas.Columns["ObservacionFormateada"].Visible = false;

                    LblFHUM.Visible = true;
                    LblFHUMod.Visible = true;
                    BtnAbrirArchivo.Visible = true;
                    BtnVerDetalles.Visible = true;

                    btnFiltrarFechas.Enabled = true;
                    BtnVerDetalles.Enabled = false;
                    BtnAbrirArchivo.Enabled = false;

                    LblFHUMod.Text = listaHistoriasClinicas.Rows[0]["FechaUltimaModificacion"].ToString();

                    grpHistClinicas.Enabled = true;

                    BtnEditarHistClinica.Enabled = false;

                    ObtenerIDHistClinicaGeneralYDiagnosticosPaciente(paciente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ObtenerIDHistClinicaGeneralYDiagnosticosPaciente(Guid idPaciente)
        {
            try
            {
                DataTable listaDiagnosticosPaciente = intermedia.ObtenerDiagnosticosPorPacienteHC(idPaciente);

                if (listaDiagnosticosPaciente.Rows.Count > 0)
                {
                    lblDiagnosticosBD.Visible = true;

                    string diagnosticos = listaDiagnosticosPaciente.Rows[0]["Diagnosticos"].ToString();

                    if (Guid.TryParse(listaDiagnosticosPaciente.Rows[0]["Id_HistClGeneral"].ToString(), out Guid idhcGral))
                    {
                        idHistoriaClinicaGeneral = idhcGral;
                    }

                    lblDiagnosticosBD.Text = diagnosticos;

                    nombresDiagnosticosLBL.Clear();

                    if (!string.IsNullOrWhiteSpace(lblDiagnosticosBD.Text))
                    {
                        foreach (string diag in lblDiagnosticosBD.Text.Split(","))
                        {
                            nombresDiagnosticosLBL.Add(diag.Trim());
                        }
                    }

                    cboFiltrarDiagnosticos.SelectedItem = "Todos los diagnósticos";

                    string? filtro = cboFiltrarDiagnosticos.Text.ToString().Trim();
                    if (filtro != "Seleccione un filtro..." || !string.IsNullOrEmpty(filtro))
                        CargarDiagnosticosDelPaciente(idPaciente, filtro);
                    else
                        return;
                }
                else
                {
                    lblDiagnosticosBD.Text = "Sin diagnósticos registrados.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListarDiagnosticos()
        {
            try
            {
                ClkDiagnosticos.Items.Clear();
                nombreDiagnosticoDesdeBD.Clear();

                DataTable listaDiagnosticos = diagnosticos.ListarDiagnosticos();

                if (listaDiagnosticos != null)
                {
                    foreach (DataRow fila in listaDiagnosticos.Rows)
                    {
                        string? id = fila["ID_Diagnostico"]?.ToString(),
                                diagnostico = fila["Diagnostico"]?.ToString();

                        nombreDiagnosticoDesdeBD[diagnostico] = id;
                        ClkDiagnosticos.Items.Add(new KeyValuePair<string, string>(id, diagnostico));
                    }

                    ClkDiagnosticos.DisplayMember = "Value";

                    cboFiltrarDiagnosticos.SelectedItem = "Todos los diagnósticos";

                    for (int i = 0; i < ClkDiagnosticos.Items.Count; i++)
                    {
                        var item = (KeyValuePair<string, string>)ClkDiagnosticos.Items[i];

                        if (item.Value.Equals("Sin diagnóstico".ToUpper(), StringComparison.OrdinalIgnoreCase))
                        {
                            ClkDiagnosticos.SetItemChecked(i, true);
                            ClkDiagnosticos.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnAgregarHistoriaClinica_Click(object sender, EventArgs e)
        {
            try
            {
                string observacionPlano = rtfObservaciones.Text;
                string? observacionFormateada = rtfObservaciones.Rtf;

                if (dtpFechaConsulta.Value > DateTime.Now)
                {
                    MessageBox.Show("No se puede establecer una fecha mayor a la actual", "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ((Guid)cboPacientes.SelectedValue == Guid.Empty)
                {
                    MessageBox.Show("Debes seleccionar un paciente primero", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DateTime fechaConsulta = dtpFechaConsulta.Value;
                Guid id_Paciente = Guid.Parse(cboPacientes.SelectedValue.ToString());

                historiaClinica.NuevaHistoriaClinica(id_Paciente, observacionPlano, observacionFormateada, fechaConsulta, ruta_archivo);

                MessageBox.Show("Historia clinica agregada correctamente", "NutrisysExito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarInputs();

                ListarHistoriasClinicas(id_Paciente);

                DgvHistClinicas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnAgregarDiagnostico_Click(object sender, EventArgs e)
        {
            string nombreDiagnostico = TxtNuevoDiagnostico.Text.Trim();

            Guid idDiagnostico = Guid.NewGuid();
            try
            {
                if (!string.IsNullOrEmpty(nombreDiagnostico))
                {
                    diagnosticos.InsertarDiagnostico(nombreDiagnostico);

                    MessageBox.Show($"Diagnostico {nombreDiagnostico.ToUpper()} agregado correctamente a la base de datos", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bool diagnosticoExistente = ClkDiagnosticos.Items.Cast<KeyValuePair<string, string>>().Any(kv => kv.Value == nombreDiagnostico.ToUpper());

                    if (!diagnosticoExistente)
                    {
                        int valor = ClkDiagnosticos.Items.Add(new KeyValuePair<string, string>(idDiagnostico.ToString(), nombreDiagnostico.ToUpper()));

                        ClkDiagnosticos.SetItemChecked(valor, true);
                    }
                    TxtNuevoDiagnostico.Clear();
                }
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnEditarHistClinica_Click(object sender, EventArgs e)
        {
            string observacionPlano = rtfObservaciones.Text,
                    observacionRTF = rtfObservaciones.Rtf,
                    paciente = TxtBuscarPaciente.Text;

            string rutaFinal = string.IsNullOrWhiteSpace(ruta_archivo) ? ruta_archivo_original : ruta_archivo;
            DateTime fechaConsulta = DateTime.Now;

            if (dtpFechaConsulta.Value > DateTime.Now)
            {
                MessageBox.Show("No se puede establecer una fecha mayor a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboPacientes.SelectedValue == null)
            {
                MessageBox.Show("Debes seleccionar un paciente primero", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Guid id_Paciente = Guid.Parse(cboPacientes.SelectedValue.ToString()),
                id_HistoriaClinica = idHistCl;

                if (DateTime.TryParse(dtpFechaConsulta.Value.ToString(), out DateTime fc))
                {
                    fechaConsulta = fc;
                }

                historiaClinica.EditarHistoriaClinica(id_HistoriaClinica, id_Paciente, observacionPlano, observacionRTF, fechaConsulta, rutaFinal);

                MessageBox.Show("Historia clinica editada correctamente", "NutrisysExito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarInputs();

                ListarHistoriasClinicas(id_Paciente);

                DgvHistClinicas.ClearSelection();

                cboFiltrarDiagnosticos.SelectedItem = "Todos los diagnósticos";

                BtnAgregarHistoriaClinica.Enabled = true;
                btnLimpiarInputs.Enabled = true;
                BtnEditarHistClinica.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnVerDetalles_Click(object sender, EventArgs e)
        {
            if (detalleSeleccionado != null)
            {
                FrmDetalleHistoriaClinica frmDetallesHC = new(detalleSeleccionado);
                frmDetallesHC.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay detalles para mostrar.", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnAbrirArchivo_Click(object sender, EventArgs e)
        {
            string rutaCompleta = Path.Combine(Application.StartupPath, celdaRuta);

            try
            {
                historiaClinica.Archivo(rutaCompleta);
            }
            catch(FileNotFoundException fnfe)
            {
                MessageBox.Show(fnfe.Message);
            }

        }
        private void btnEditarDiagnosticosHC_Click(object sender, EventArgs e)
        {
            Guid idPaciente = Guid.Parse(cboPacientes.SelectedValue.ToString());

            idHistoriaClinicaGeneral = intermedia.ObtenerIdHistoriaClinicaGeneralPorPaciente(idPaciente);

            foreach (var kvp in estadoTemporalDiagnosticos)
            {
                string idDiagnostico = kvp.Key;
                bool estaMarcado = kvp.Value;

                if (!DiccNombreDelDiagnostico.TryGetValue(idDiagnostico, out string nombreDiagnostico))
                    continue;

                try
                {
                    if (estaMarcado)
                    {
                        intermedia.InsertarDiagnosticoAPacienteHistClinica(idHistoriaClinicaGeneral, idPaciente, nombreDiagnostico);
                    }
                    else
                    {
                        intermedia.EliminarDiagnosticoPacienteDeHC(idHistoriaClinicaGeneral, nombreDiagnostico);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ObtenerIDHistClinicaGeneralYDiagnosticosPaciente(idPaciente);
        }
        private void btnQuitarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                Guid idPaciente = Guid.Parse(cboPacientes.SelectedValue?.ToString());

                if (string.IsNullOrWhiteSpace(celdaRuta) || string.IsNullOrWhiteSpace(ruta_archivo_original) || string.IsNullOrWhiteSpace(ruta_archivo))
                {
                    MessageBox.Show("No hay archivo adjunto para borrar", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                historiaClinica.EliminarArchivoDeHistoriaClinica(idHistCl);

                txtTituloArchivo.Text = "";

                ListarHistoriasClinicas(idPaciente);

                btnQuitarArchivo.Enabled = false;

                DgvHistClinicas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiarInputs_Click(object sender, EventArgs e)
        {
            LimpiarInputs();
            BtnEditarHistClinica.Enabled = false;
            BtnAgregarHistoriaClinica.Enabled = true;
            DgvHistClinicas.ClearSelection();
        }
        private void btnFiltrarFechas_Click(object sender, EventArgs e)
        {
            Guid idPaciente = Guid.Parse(cboPacientes.SelectedValue.ToString());
            DateTime fechaInicio = dtpDesde.Value;
            DateTime fechaFin = dtpHasta.Value;

            try
            {
                DataTable historiaClinicaFiltrada = historiaClinica.FiltrarHistoriaClinicaPorFecha(idPaciente, fechaInicio, fechaFin);

                if(historiaClinicaFiltrada.Rows.Count >= 0)
                {
                    BindingSource bs = new();
                    bs.DataSource = historiaClinicaFiltrada;

                    DgvHistClinicas.DataSource = bs;

                    DgvHistClinicas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    btnQuitarFiltro.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            Guid idPaciente = Guid.Parse(cboPacientes.SelectedValue.ToString());

            ListarHistoriasClinicas(idPaciente);

            btnQuitarFiltro.Visible = false;
        }
        private void DgvHistClinicas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnVerDetalles.Enabled = true;

            BtnAgregarHistoriaClinica.Enabled = false;
            BtnEditarHistClinica.Enabled = true;
            txtBuscarDiagnostico.Enabled = true;

            if (e.RowIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione una fila correcta", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (DgvHistClinicas.Rows[e.RowIndex].DataBoundItem is DataRowView rowView)
            {
                celdaRuta = rowView["Ruta"]?.ToString();
                ruta_archivo = celdaRuta;
                ruta_archivo_original = celdaRuta;

                if (!string.IsNullOrWhiteSpace(celdaRuta))
                {
                    BtnAbrirArchivo.Enabled = true;
                    btnQuitarArchivo.Enabled = true;
                }
            }

            Guid? idPaciente = Guid.Parse(DgvHistClinicas.Rows[e.RowIndex].Cells["Id_Paciente"].Value?.ToString());

            var fila = DgvHistClinicas.Rows[e.RowIndex];
            if (Guid.TryParse(fila.Cells["ID_HistCl"].Value?.ToString(), out Guid guidHistoria))
            {
                idHistCl = guidHistoria;
            }

            DateTime fechaConsulta = DateTime.Now;

            if (DateTime.TryParse(fila.Cells["Fecha de Consulta"].Value?.ToString(), out DateTime fechaConsultaBD))
            {
                fechaConsulta = fechaConsultaBD;
            }

            string? celdaNombrePaciente = fila.Cells["Paciente"].Value?.ToString();
            string? nombreArchivo = Path.GetFileName(celdaRuta);

            string observacionRtf = historiaClinica.RetornarObservacionFormateada(idHistCl);

            txtTituloArchivo.Text = nombreArchivo;
            rtfObservaciones.Rtf = observacionRtf;
            cboPacientes.SelectedValue = idPaciente;
            dtpFechaConsulta.Value = fechaConsulta;

            detalleSeleccionado = ObtenerDetalleHistoriaClinicaSeleccionada(idHistCl, idPaciente.Value);

            btnLimpiarInputs.Enabled = true;
        }
        private void CargarDiagnosticosDelPaciente(Guid? idPaciente, string filtro)
        {
            for (int i = 0; i < ClkDiagnosticos.Items.Count; i++)
            {
                ClkDiagnosticos.SetItemChecked(i, false);
            }

            estadoTemporalDiagnosticos.Clear();
            DiccNombreDelDiagnostico.Clear();

            DataTable todosLosDiagnosticos = diagnosticos.ListarDiagnosticos(),
                diagnosticosMarcados = intermedia.FiltrarDiagnosticosMarcados(idPaciente);

            if (filtro == "Todos los diagnósticos")
            {
                CargarDiagnosticosEnLista(todosLosDiagnosticos, diagnosticosMarcados);
            }
            else if (filtro == "Diagnósticos Marcados")
            {
                CargarDiagnosticosEnLista(diagnosticosMarcados, null, true);
            }
        }
        private void CargarDiagnosticosEnLista(DataTable? diagnosticos, DataTable? diagnosticosMarcados = null, bool marca = false)
        {
            ClkDiagnosticos.Items.Clear();

            foreach (DataRow fila in diagnosticos.Rows)
            {
                string id = fila["ID_Diagnostico"].ToString(),
                    nombre = fila["Diagnostico"].ToString();

                if (marca)
                {
                    estadoTemporalDiagnosticos[id] = true;
                }
                else if (diagnosticosMarcados != null && !estadoTemporalDiagnosticos.ContainsKey(id))
                {
                    estadoTemporalDiagnosticos[id] = diagnosticosMarcados.AsEnumerable()
                        .Any(row => row["ID_Diagnostico"].ToString() == id);
                }

                if (!DiccNombreDelDiagnostico.ContainsKey(id))
                    DiccNombreDelDiagnostico[id] = nombre;

                bool marcado = estadoTemporalDiagnosticos.ContainsKey(id) && estadoTemporalDiagnosticos[id];

                ClkDiagnosticos.Items.Add(new KeyValuePair<string, string>(id, nombre), marcado);
            }

            ClkDiagnosticos.DisplayMember = "Value";
        }
        private DetallesHistoriaClinica ObtenerDetalleHistoriaClinicaSeleccionada(Guid idHistClinica, Guid idPaciente)
        {
            string observacion = historiaClinica.RetornarObservacionFormateada(idHistClinica);

            DataTable datosDiagnostico = intermedia.ObtenerDiagnosticosPorPacienteHC(idPaciente);

            string diagnosticos = datosDiagnostico.Rows.Count > 0
                ? datosDiagnostico.Rows[0]["Diagnosticos"]?.ToString()
                : "Sin diagnósticos registrados";

            return new DetallesHistoriaClinica
            {
                Paciente = cboPacientes.Text,
                Diagnostico = diagnosticos,
                DescripcionHC = observacion
            };
        }
        private void CboPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPacientes.SelectedIndex != -1 && cboPacientes.SelectedValue != null && TxtBuscarPaciente.Text != "")
            {
                DgvHistClinicas.DataSource = null;
                grpHistClinicas.Enabled = false;

                BtnMostrarHC.Enabled = true;

                LimpiarInputs();

                txtBuscarDiagnostico.Text = string.Empty;
                BtnAbrirArchivo.Visible = false;
                BtnVerDetalles.Visible = false;
                LblFHUM.Visible = false;
                LblFHUMod.Visible = false;
            }
            else
            {
                BtnMostrarHC.Enabled = false;
            }
        }
        private void TxtBuscarPaciente_TextChanged(object sender, EventArgs e)
        {
            BtnBuscarPaciente.Enabled = TxtBuscarPaciente.Text.Trim().Length >= 3;
            if (TxtBuscarPaciente.Text == "")
            {
                DgvHistClinicas.DataSource = null;

                grpHistClinicas.Enabled = false;
                BtnMostrarHC.Enabled = false;

                BtnAbrirArchivo.Visible = false;
                BtnVerDetalles.Visible = false;
                LblFHUM.Visible = false;
                LblFHUMod.Visible = false;

                lblDiagnosticosBD.Text = "";

                cboPacientes.SelectedIndex = -1;

                cboPacientes.Enabled = false;

                for (int i = 0; i < ClkDiagnosticos.Items.Count; i++)
                {
                    ClkDiagnosticos.SetItemChecked(i, false);
                }

                LimpiarInputs();
            }
        }
        private void TxtNuevoDiagnostico_TextChanged(object sender, EventArgs e)
        {
            BtnAgregarDiagnostico.Enabled = TxtNuevoDiagnostico.Text.Trim().Length >= 3;
        }
        private void cboFiltrarDiagnosticos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPacientes.SelectedValue == null)
            {
                return;
            }

            if (cboFiltrarDiagnosticos.SelectedIndex == 0)
            {
                return;
            }

            string filtro = cboFiltrarDiagnosticos.Text.ToString();

            Guid paciente = Guid.Parse(cboPacientes.SelectedValue.ToString());

            CargarDiagnosticosDelPaciente(paciente, filtro);
        }
        private void txtBuscarDiagnostico_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string diagnosticoTxt = txtBuscarDiagnostico.Text.ToString().Trim();
                Guid idPaciente = Guid.Parse(cboPacientes.SelectedValue.ToString());

                DataTable listaFiltroDiagnostico = diagnosticos.FiltrarDiagnostico(diagnosticoTxt);

                if (listaFiltroDiagnostico != null)
                {
                    CargarDiagnosticosEnLista(listaFiltroDiagnostico);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClkDiagnosticos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                if (e.Index >= 0 && e.Index < ClkDiagnosticos.Items.Count)
                {
                    var item = (KeyValuePair<string, string>)ClkDiagnosticos.Items[e.Index];
                    string idDiagnostico = item.Key;

                    bool nuevoValor = (e.NewValue == CheckState.Checked);
                    estadoTemporalDiagnosticos[idDiagnostico] = nuevoValor;
                }
            });
        }
        private void LimpiarInputs()
        {
            rtfObservaciones.Text = "";
            txtTituloArchivo.Text = "";
            TxtNuevoDiagnostico.Text = "";
            dtpFechaConsulta.Text = "";
        }
        private void btnNegrita_Click(object sender, EventArgs e)
        {
            AplicarEstilos.AplicarEstilosTextbox(rtfObservaciones, FontStyle.Bold);
        }
        private void btnCursiva_Click(object sender, EventArgs e)
        {
            AplicarEstilos.AplicarEstilosTextbox(rtfObservaciones, FontStyle.Italic);
        }
        private void btnSubrayado_Click(object sender, EventArgs e)
        {
            AplicarEstilos.AplicarEstilosTextbox(rtfObservaciones, FontStyle.Underline);
        }
        private void btnColores_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    rtfObservaciones.SelectionColor = colorDialog.Color;
                }
            }
        }
        private void rtfObservaciones_SelectionChanged(object sender, EventArgs e)
        {
            Font selFont = rtfObservaciones.SelectionFont;

            if (selFont != null)
            {
                btnNegrita.BackColor = selFont.Bold ? Color.LightGray : Color.White;
                btnCursiva.BackColor = selFont.Italic ? Color.LightGray : Color.White;
                btnSubrayado.BackColor = selFont.Underline ? Color.LightGray : Color.White;
            }
            else
            {
                btnNegrita.BackColor = Color.White;
                btnCursiva.BackColor = Color.White;
                btnSubrayado.BackColor = Color.White;
            }
        }
        private void tsrPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes pacientes = new();

            pacientes.Show();
        }
        private void tsrAntropometria_Click(object sender, EventArgs e)
        {
            frmAntropometria antropometria = new();

            antropometria.Show();
        }
        private void tsrPAMI_Click(object sender, EventArgs e)
        {
            frmPAMI pami = new();
            pami.Show();
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe acercaDe = new frmAcercaDe();

            acercaDe.ShowDialog();
        }
        private void tsrMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void tsrSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}