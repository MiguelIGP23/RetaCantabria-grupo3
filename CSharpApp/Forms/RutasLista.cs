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


        // Método para cargar datos en la lista de user controls de rutas en el flowlayout
        public async Task CargarRutas()
        {
            List<Ruta> rutas = await _api.GetAllAsync<Ruta>("api/reta3/rutas");
            flpRutas.Controls.Clear();
            foreach (Ruta ruta in rutas)
            {
                UCRutaLista uc = new UCRutaLista();
                uc.SetData(ruta);
                uc.RutaClick += RutaClick;
                flpRutas.Controls.Add(uc);
            }
        }


        private async void btn_borrar_Click(object sender, EventArgs e)
        {
            int idRuta = 1; // la ruta seleccionada

            string downloads = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Downloads"
            );

            string destino = Path.Combine(
                downloads,
                "ficha-organizacion.txt"
            );
            await _api.DescargarFichaOrganizacionAsync(idRuta, destino);


            destino = Path.Combine(
                downloads,
                "ficha-seguridad.txt"
            );
            await _api.DescargarFichaSeguridadAsync(idRuta, destino);


            destino = Path.Combine(
                downloads,
                "ficha-usuario.txt"
            );
            await _api.DescargarFichaUsuarioAsync(idRuta, destino);

            MessageBox.Show("Ficha descargada en Descargas");
        }

        private async void Rutas_Load(object sender, EventArgs e)
        {
            await CargarRutas();
        }


        // Métodos de eventos
        private void RutaClick(object? sender, Ruta e)
        {
            new RutasDetalle().Show();
        }
    }
}
