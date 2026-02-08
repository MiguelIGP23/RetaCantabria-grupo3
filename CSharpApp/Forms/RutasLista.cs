using Model;
using Repository;
using System.Net.Http.Json;
using UserControls;
using static System.Net.WebRequestMethods;


namespace Forms
{
    public partial class RutasLista : Form
    {

        private readonly ApiReta _api;

        public RutasLista(ApiReta api)
        {
            InitializeComponent();
            _api = api;
        }

        private async void Rutas_Load(object sender, EventArgs e)
        {
            await CargarRutas();
        }


        // Método para cargar datos en la lista de user controls de rutas en el flowlayout
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
                flpRutas.Controls.Clear();
                foreach (Ruta r in rutas)
                {
                    UCRutaLista uc = new UCRutaLista();
                    uc.SetData(r);
                    uc.RutaClick += RutaClick;
                    flpRutas.Controls.Add(uc);
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }



        // Métodos de eventos
        private async void RutaClick(object? sender, Ruta ruta)
        {
            using (var frm = new RutasDetalle(ruta, _api))
            {
                var result = frm.ShowDialog();
                if(result == DialogResult.Cancel)
                {
                    await CargarRutas();
                }
            }
        }



        // Métodos de botones
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new CrearEditarRuta(_api, null))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    await CargarRutas();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
