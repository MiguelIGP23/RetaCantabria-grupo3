using Model;
using Repository;
using System.DirectoryServices.ActiveDirectory;
using System.Net.Http.Json;
using UserControls;
using Utils;
using static System.Net.WebRequestMethods;


namespace Forms
{
    public partial class RutasLista : Form
    {

        private readonly ApiReta _api;

        private List<Ruta> _rutas = new List<Ruta>();
        private bool filtroActivo = true;

        public RutasLista(ApiReta api)
        {
            InitializeComponent();
            _api = api;
            cbClasificacion.DataSource = Enum.GetValues(typeof(EnumClasificaciones));
        }

        private async void Rutas_Load(object sender, EventArgs e)
        {
            await CargarRutas();
            MostrarFiltros(false);
        }


        // Métodos para cargar datos en la lista de user controls de rutas en el flowlayout
        public async Task CargarRutas()
        {
            try
            {
                string ruta;
                if (Session.Rol != EnumRoles.ADMINISTRADOR)
                {
                    ruta = "api/reta3/rutas/validadas";
                }
                else
                {
                    ruta = "api/reta3/rutas";
                }
                List<Ruta> rutas = await _api.GetAllAsync<Ruta>(ruta);
                _rutas.Clear();
                flpRutas.Controls.Clear();
                foreach (Ruta r in rutas)
                {
                    UCRutaLista uc = new UCRutaLista();
                    uc.SetData(r);
                    uc.RutaClick += RutaClick;
                    flpRutas.Controls.Add(uc);
                    _rutas.Add(r);
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }


        public void CargarRutasFiltradas(List<Ruta> rutasFiltradas)
        {
            flpRutas.Controls.Clear();
            foreach (Ruta r in rutasFiltradas)
            {
                UCRutaLista uc = new UCRutaLista();
                uc.SetData(r);
                uc.RutaClick += RutaClick;
                flpRutas.Controls.Add(uc);
            }
        }



        // Métodos de eventos
        private async void RutaClick(object? sender, Ruta ruta)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new RutasDetalle(ruta, _api))
                {
                    form.ShowDialog(this);
                }

                await CargarRutas();
            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate(); // recupera foco en caso de que no se abra el hijo
            }
        }



        // Métodos de botones
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new CrearEditarRuta(_api, null))
                {
                    form.ShowDialog(this);
                }

                await CargarRutas();
            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate();
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        public void MostrarFiltros(bool mostrar)
        {
            if (mostrar)
            {
                this.Size = new Size(900, 1000);
                flpRutas.Location = new Point(95, 430);
                btnLogout.Location = new Point(270, 880);
                btnAgregar.Location = new Point(550, 880);

                ckNombre.Visible = true;
                ckNombre.Checked = false;
                tbNombre.Visible = true;

                ckPuntuacion.Visible = true;
                ckPuntuacion.Checked = false;
                nudPuntuacionMin.Visible = true;
                nudPuntuacionMax.Visible = true;

                ckDistancia.Visible = true;
                ckDistancia.Checked = false;
                nudDistanciaMin.Visible = true;
                nudDistanciaMax.Visible = true;

                ckDuracion.Visible = true;
                ckDuracion.Checked = false;
                nudDuracionMin.Visible = true;
                nudDuracionMax.Visible = true;

                ckClasificacion.Visible = true;
                ckClasificacion.Checked = false;
                cbClasificacion.Visible = true;

                ckAccesible.Visible = true;
                ckAccesible.Checked = false;

                ckFamiliar.Visible = true;
                ckFamiliar.Checked = false;

                ckEsfuerzo.Visible = true;
                ckEsfuerzo.Checked = false;
                nudEsfuerzoMin.Visible = true;
                nudEsfuerzoMax.Visible = true;

                ckRiesgo.Visible = true;
                ckRiesgo.Checked = false;
                nudRiesgoMin.Visible = true;
                nudRiesgoMax.Visible = true;

                ckTemporada.Visible = true;
                ckTemporada.Checked = false;
                ckPrimavera.Visible = true;
                ckPrimavera.Checked = false;
                ckVerano.Visible = true;
                ckVerano.Checked = false;
                ckOtono.Visible = true;
                ckOtono.Checked = false;
                ckInvierno.Visible = true;
                ckInvierno.Checked = false;

                btnFiltrar.Visible = true;
            }
            else
            {
                this.Size = new Size(900, 600);
                flpRutas.Location = new Point(95, 60);
                btnLogout.Location = new Point(270, 490);
                btnAgregar.Location = new Point(550, 490);

                ckNombre.Visible = false;
                ckNombre.Checked = false;
                tbNombre.Visible = false;

                ckPuntuacion.Visible = false;
                ckPuntuacion.Checked = false;
                nudPuntuacionMin.Visible = false;
                nudPuntuacionMax.Visible = false;

                ckDistancia.Visible = false;
                ckDistancia.Checked = false;
                nudDistanciaMin.Visible = false;
                nudDistanciaMax.Visible = false;

                ckDuracion.Visible = false;
                ckDuracion.Checked = false;
                nudDuracionMin.Visible = false;
                nudDuracionMax.Visible = false;

                ckClasificacion.Visible = false;
                ckClasificacion.Checked = false;
                cbClasificacion.Visible = false;

                ckAccesible.Visible = false;
                ckAccesible.Checked = false;

                ckFamiliar.Visible = false;
                ckFamiliar.Checked = false;

                ckEsfuerzo.Visible = false;
                ckEsfuerzo.Checked = false;
                nudEsfuerzoMin.Visible = false;
                nudEsfuerzoMax.Visible = false;

                ckRiesgo.Visible = false;
                ckRiesgo.Checked = false;
                nudRiesgoMin.Visible = false;
                nudRiesgoMax.Visible = false;

                ckTemporada.Visible = false;
                ckTemporada.Checked = false;
                ckPrimavera.Visible = false;
                ckPrimavera.Checked = false;
                ckVerano.Visible = false;
                ckVerano.Checked = false;
                ckOtono.Visible = false;
                ckOtono.Checked = false;
                ckInvierno.Visible = false;
                ckInvierno.Checked = false;

                btnFiltrar.Visible = false;
            }
        }


        // Método para construir el filtro de rutas desde los componentes de la interfaz
        private RutaFilter BuildFilterFromUI()
        {
            // Temporadas: si no hay ninguna marcada -> null
            string? temporadas = null;
            if (ckTemporada.Checked)
            {
                var temps = new List<string>();
                if (ckPrimavera.Checked) temps.Add("Primavera");
                if (ckVerano.Checked) temps.Add("Verano");
                if (ckOtono.Checked) temps.Add("Otoño");
                if (ckInvierno.Checked) temps.Add("Invierno");

                temporadas = temps.Count == 0 ? null : string.Join(",", temps);
            }

            return new RutaFilter
            {
                // Nombre
                Nombre = ckNombre.Checked
                    ? (string.IsNullOrWhiteSpace(tbNombre.Text) ? null : tbNombre.Text.Trim())
                    : null,

                // Puntuación
                PuntuacionMin = ckPuntuacion.Checked ? (int)nudPuntuacionMin.Value : null,
                PuntuacionMax = ckPuntuacion.Checked ? (int)nudPuntuacionMax.Value : null,

                // Distancia
                DistanciaMin = ckDistancia.Checked ? (double)nudDistanciaMin.Value : null,
                DistanciaMax = ckDistancia.Checked ? (double)nudDistanciaMax.Value : null,

                // Duración 
                DuracionMin = ckDuracion.Checked ? TimeSpan.FromMinutes((double)nudDuracionMin.Value) : null,
                DuracionMax = ckDuracion.Checked ? TimeSpan.FromMinutes((double)nudDuracionMax.Value) : null,

                // Clasificación (ComboBox de enum)
                Clasificaciones = ckClasificacion.Checked
                    ? (cbClasificacion.SelectedItem is EnumClasificaciones c ? c : (EnumClasificaciones?)null)
                    : null,

                // Esfuerzo
                EsfuerzoMin = ckEsfuerzo.Checked ? (int)nudEsfuerzoMin.Value : null,
                EsfuerzoMax = ckEsfuerzo.Checked ? (int)nudEsfuerzoMax.Value : null,

                // Riesgo
                RiesgoMin = ckRiesgo.Checked ? (int)nudRiesgoMin.Value : null,
                RiesgoMax = ckRiesgo.Checked ? (int)nudRiesgoMax.Value : null,

                // Temporadas (string con varias)
                Temporada = temporadas,

                // Accesible / Familiar
                Accesible = ckAccesible.Checked ? true : (bool?)null,
                Familiar = ckFamiliar.Checked ? true : (bool?)null
            };
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var filtro = BuildFilterFromUI();
            var pred = RutaFiltering.BuildPredicate(filtro);

            var filtradas = _rutas.Where(pred).ToList();
            CargarRutasFiltradas(filtradas);
        }

        private void btnMostrarFiltros_Click(object sender, EventArgs e)
        {
            if (filtroActivo)
            {
                MostrarFiltros(true);
                filtroActivo = !filtroActivo;
                btnMostrarFiltros.Text = "Ocultar filtros";
            }
            else
            {
                MostrarFiltros(false);
                filtroActivo = !filtroActivo;
                btnMostrarFiltros.Text = "Mostrar filtros";
            }
        }
    }
}
