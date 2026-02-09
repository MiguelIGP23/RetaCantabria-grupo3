using Model;
using Repository;
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

        public RutasLista(ApiReta api)
        {
            InitializeComponent();
            _api = api;
        }

        private async void Rutas_Load(object sender, EventArgs e)
        {
            await CargarRutas();
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
    }
}
