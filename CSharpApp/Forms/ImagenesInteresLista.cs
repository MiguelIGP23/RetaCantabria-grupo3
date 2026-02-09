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



        // Metodos de eventos
        private void ImagenInteresClick(object? sender, ImagenInteres imagen)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new ImagenInteresDetalle(_api, _ruta, _puntoInteres, imagen))
                {
                    form.ShowDialog(this);
                }

                CargarImagenes(_puntoInteres);
            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate();
            }
        }



        // Metodos de botones
        private void btnNuevaImagen_Click(object sender, EventArgs e)
        {
            var idRuta = _puntoInteres.RutaId;
            var idPunto = _puntoInteres.Id;

            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new CrearEditarImagenInteres(_api, null, idRuta, idPunto))
                {
                    form.ShowDialog(this);
                }

                CargarImagenes(_puntoInteres);
            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}