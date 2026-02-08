using Model;
using Repository;
using UserControls;

namespace Forms
{
    public partial class ImagenesInteresLista : Form
    {

        private readonly ApiReta _api;

        private Ruta _ruta { get; set; }
        private PuntoInteres _puntoInteres { get; set; }

        public ImagenesInteresLista(ApiReta api, Ruta ruta, PuntoInteres puntoInteres)
        {
            InitializeComponent();
            _api = api;
            _ruta = ruta;
            _puntoInteres = puntoInteres;
        }

        private void ImagenesInteresLista_Load(object sender, EventArgs e)
        {
            CargarImagenes(_puntoInteres);
        }



        // Metodo para cargar datos la lista de user controls de imagenes de interes en el flowlayout
        private async void CargarImagenes(PuntoInteres puntoInteres)
        {
            try
            {
                var idPunto = puntoInteres.Id;
                var idRuta = puntoInteres.RutaId;

                List<ImagenInteres> imagenes = await _api.GetAllAsync<ImagenInteres>($"api/reta3/rutas/{idRuta}/puntosinteres/{idPunto}/imagenes");
                flpImagenesLista.Controls.Clear();
                foreach (ImagenInteres i in imagenes)
                {
                    UCImagenInteresLista uc = new UCImagenInteresLista();
                    uc.SetData(i);
                    uc.ImagenInteresClick += ImagenInteresClick;
                    flpImagenesLista.Controls.Add(uc);
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Metodos de eventos
        private void ImagenInteresClick(object? sender, ImagenInteres imagen)
        {
            using (var form = new ImagenInteresDetalle(_api, _ruta, _puntoInteres, imagen))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    CargarImagenes(_puntoInteres);
                }
            }
        }

        private void btnNuevaImagen_Click(object sender, EventArgs e)
        {
            var idRuta = _puntoInteres.RutaId;
            var idPunto = _puntoInteres.Id;

            using (var form = new CrearEditarImagenInteres(_api, null, idRuta, idPunto))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CargarImagenes(_puntoInteres);
                }
            }
        }
    }
}