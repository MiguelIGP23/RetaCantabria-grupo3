using Model;
using Repository;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;


namespace Forms
{
    public partial class Rutas : Form
    {

        private readonly ApiReta _api;

        public Rutas(ApiReta api)
        {
            InitializeComponent();
            _api = api;
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
    }
}
