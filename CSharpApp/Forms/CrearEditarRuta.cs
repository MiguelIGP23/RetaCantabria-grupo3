using Model;
using Repository;

namespace Forms
{
    public partial class CrearEditarRuta : Form
    {

        public Ruta Ruta { get; private set; }
        private Ruta _ruta;
        private ApiReta _api;

        private string? _gpxPath;
        private bool _rutaCreadaConGpx = false;
        private int? _idRutaBorrador;

        public CrearEditarRuta(ApiReta api, Ruta ruta)
        {
            InitializeComponent();
            _api = api;
            _ruta = ruta;
            cbClasificacion.DataSource = Enum.GetValues(typeof(EnumClasificaciones));
        }


        private void CrearEditarRuta_Load(object sender, EventArgs e)
        {
            bool esAdmin = Session.Rol == EnumRoles.ADMINISTRADOR;
            nudLatIni.Enabled = esAdmin;
            nudLonIni.Enabled = esAdmin;
            nudLatFin.Enabled = esAdmin;
            nudLonFin.Enabled = esAdmin;

            nudDuracion.Enabled = esAdmin;
            nudDistancia.Enabled = esAdmin;

            nudDesnivelPos.Enabled = esAdmin;
            nudDesnivelNeg.Enabled = esAdmin;

            nudAltitudMin.Enabled = esAdmin;
            nudAltitudMax.Enabled = esAdmin;

            if (_ruta != null)
            {
                CargarDatos(_ruta);
            }
            else
            {
                nudLatIni.Value = 0;
                nudLatFin.Value = 0;
                nudLonIni.Value = 0;
                nudLonFin.Value = 0;
                nudDuracion.Value = 0;
                nudDistancia.Value = 0;
                nudDesnivelNeg.Value = 0;
                nudDesnivelPos.Value = 0;
                nudAltitudMin.Value = 0;
                nudAltitudMax.Value = 0;
                cbClasificacion.SelectedItem = EnumClasificaciones.CIRCULAR;
                nudTipoTerreno.Value = 0;
                nudIndicaciones.Value = 0;
            }
        }

        private async void CrearEditarRuta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK && _idRutaBorrador.HasValue)
            {
                try
                {
                    await _api.CancelarBorrador("api/reta3/rutas", _idRutaBorrador.Value);
                }
                catch { }
            }
        }

        // Carga datos de la ruta dada como parametro en los campos

        public void CargarDatos(Ruta ruta)
        {
            if (_ruta != null)
            {
                txtNombre.Text = ruta.Nombre;
                txtInicio.Text = ruta.Nombre_inicioruta;
                txtFinal.Text = ruta.Nombre_finalruta;
                nudLatIni.Value = (decimal)ruta.LatitudInicial;
                nudLatFin.Value = (decimal)ruta.LatitudFinal;
                nudLonIni.Value = (decimal)ruta.LongitudInicial;
                nudLonFin.Value = (decimal)ruta.LongitudFinal;
                nudDistancia.Value = (decimal)ruta.Distancia;
                nudDuracion.Value = (decimal)ruta.Duracion.TotalMinutes;
                nudDesnivelPos.Value = ruta.DesnivelPositivo != null ? (decimal)ruta.DesnivelPositivo : 0;
                nudDesnivelNeg.Value = ruta.DesnivelNegativo != null ? (decimal)ruta.DesnivelNegativo : 0;
                nudAltitudMax.Value = ruta.AltitudMax != null ? (decimal)ruta.AltitudMax : 0;
                nudAltitudMin.Value = ruta.AltitudMin != null ? (decimal)ruta.AltitudMin : 0;
                cbClasificacion.SelectedItem = ruta.Clasificacion ?? EnumClasificaciones.CIRCULAR;
                nudTipoTerreno.Value = ruta.TipoTerreno != null ? (decimal)ruta.TipoTerreno : 1;
                nudIndicaciones.Value = ruta.Indicaciones != null ? ruta.Indicaciones.Value : 1;
                txtTemporada.Text = ruta.Temporadas;
                chkAccesibilidad.Checked = ruta.Accesibilidad == 1;
                chkFamiliar.Checked = ruta.RutaFamiliar == 1;
                lblRutaGPX.Text = ruta.ArchivoGPX;
                txtRecomendaciones.Text = ruta.RecomendacionesEquipo;
                txtZonaGeo.Text = ruta.ZonaGeografica;
            }
        }



        // Metodos de botones

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_idRutaBorrador.HasValue)
            {
                try
                {
                    await _api.CancelarBorrador("api/reta3/rutas", _idRutaBorrador.Value);
                }
                catch (HttpRequestException ex)
                {
                    ApiReta.MostrarErrorHttp(ex);
                }
            }

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private async void btnAceptar_Click_1(object sender, EventArgs e)
        {
            

            Ruta rutaNueva = (_ruta != null) ? _ruta : new Ruta();
            rutaNueva.Nombre = txtNombre.Text;
            rutaNueva.Nombre_inicioruta = txtInicio.Text;
            rutaNueva.Nombre_finalruta = txtFinal.Text;
            rutaNueva.LatitudInicial = (double)nudLatIni.Value;
            rutaNueva.LatitudFinal = (double)nudLatFin.Value;
            rutaNueva.LongitudInicial = (double)nudLonIni.Value;
            rutaNueva.LongitudFinal = (double)nudLonFin.Value;
            rutaNueva.Distancia = (double)nudDistancia.Value;
            rutaNueva.Duracion = TimeSpan.FromMinutes((double)nudDuracion.Value);
            rutaNueva.DesnivelPositivo = (int)nudDesnivelPos.Value;
            rutaNueva.DesnivelNegativo = (int)nudDesnivelNeg.Value;
            rutaNueva.AltitudMax = (int)nudAltitudMax.Value;
            rutaNueva.AltitudMin = (int)nudAltitudMin.Value;
            rutaNueva.Clasificacion = (EnumClasificaciones)cbClasificacion.SelectedItem;
            rutaNueva.TipoTerreno = (int)nudTipoTerreno.Value;
            rutaNueva.Indicaciones = (int)nudIndicaciones.Value;
            rutaNueva.Temporadas = txtTemporada.Text;
            rutaNueva.Accesibilidad = chkAccesibilidad.Checked ? 1 : 0;
            rutaNueva.RutaFamiliar = chkFamiliar.Checked ? 1 : 0;
            rutaNueva.ArchivoGPX = string.IsNullOrWhiteSpace(lblRutaGPX.Text) ? null : lblRutaGPX.Text;
            rutaNueva.RecomendacionesEquipo = txtRecomendaciones.Text;
            rutaNueva.ZonaGeografica = txtZonaGeo.Text;

            rutaNueva.UsuarioId = (int)Session.IdUsuario;

            if (string.IsNullOrWhiteSpace(rutaNueva.Nombre) ||
                string.IsNullOrWhiteSpace(rutaNueva.Nombre_inicioruta) ||
                string.IsNullOrWhiteSpace(rutaNueva.Nombre_finalruta))
            {
                MessageBox.Show("Los campos Nombre, Inicio y Final son obligatorios.");
                return;
            }

            try
            {
                if (_ruta != null && !_rutaCreadaConGpx)
                {
                    await _api.Update<Ruta>("api/reta3/rutas", rutaNueva.IdRuta.ToString(), rutaNueva);
                    MessageBox.Show("Ruta actualizada correctamente");
                }
                else
                {   if (_rutaCreadaConGpx == false)
            {
                MessageBox.Show("Es necesario importar un archivo .gpx con los trackpoints.", "GPX necesario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                    if (!_idRutaBorrador.HasValue)
                    {
                        MessageBox.Show("No hay ruta borrador. Importa un GPX primero.");
                        return;
                    }
                    rutaNueva.IdRuta = _idRutaBorrador.Value;

                    var ok = await _api.ConfirmarBorrador("api/reta3/rutas", rutaNueva.IdRuta, rutaNueva);
                    if (!ok) return;
                    MessageBox.Show("Ruta creada correctamente");
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
                return;
            }

            Ruta = rutaNueva;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private async void btnGPX_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecciona un archivo GPX";
                ofd.Filter = "Archivos GPX (*.gpx)|*.gpx|Todos los archivos (*.*)|*.*";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _gpxPath = ofd.FileName;
                    lblRutaGPX.Text = _gpxPath;

                    try
                    {
                        // UI bloqueada mientras procesa
                        btnGPX.Enabled = false;
                        btnAceptar.Enabled = false;
                        Cursor = Cursors.WaitCursor;

                        // Borrador minimo de ruta
                        var borrador = new Ruta
                        {
                            Nombre = "borrador",
                            Nombre_inicioruta = "borrador",
                            Nombre_finalruta = "borrador",
                            UsuarioId = (int)Session.IdUsuario
                        };

                        // Llamada al endpoint mandando borrador
                        var rutaDevuelta = await _api.CrearRutaConGpx("api/reta3/rutas/gpx", borrador, _gpxPath);

                        // A partir de ahora esta ruta ya existe en BD y tiene ID
                        _ruta = rutaDevuelta;
                        _rutaCreadaConGpx = true;
                        _idRutaBorrador = _ruta?.IdRuta;

                        // Cargar datos automáticos en el formulario
                        CargarDatos(_ruta);

                        // Dejar en blanco campos requeridos
                        txtNombre.Text = "";
                        txtInicio.Text = "";
                        txtFinal.Text = "";

                        // MUY IMPORTANTE: en el label no guardar el base64, guarda la ruta local
                        lblRutaGPX.Text = _gpxPath;
                        if (_ruta != null)
                        {
                            MessageBox.Show("GPX importado. Completa los campos y pulsa Aceptar.");
                        }
                    }
                    catch (HttpRequestException ex)
                    {
                        ApiReta.MostrarErrorHttp(ex);
                    }
                    finally
                    {
                        Cursor = Cursors.Default;
                        btnGPX.Enabled = false;
                        btnAceptar.Enabled = true;
                    }
                }
            }
        }


    }
}
