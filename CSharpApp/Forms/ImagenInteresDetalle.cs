using Model;
using Repository;

namespace Forms
{
    public partial class ImagenInteresDetalle : Form
    {

        private readonly ApiReta _api;

        private Ruta _ruta { get; set; }
        private PuntoInteres _puntoInteres { get; set; }
        private ImagenInteres _imagenInteres { get; set; }

        public ImagenInteresDetalle(ApiReta api, Ruta ruta, PuntoInteres puntoInteres, ImagenInteres imagenInteres)
        {
            InitializeComponent();
            _api = api;
            _ruta = ruta;
            _puntoInteres = puntoInteres;
            _imagenInteres = imagenInteres;

        }

        private void ImagenInteresDetalle_Load(object sender, EventArgs e)
        {
            ucImagenInteresCompleto1.SetData(_api, _imagenInteres);
            if (Session.Rol != EnumRoles.ADMINISTRADOR)
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
            }
        }



        // Métodos de botones

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var idRuta = _imagenInteres.RutaId;
            var idPunto = _imagenInteres.PuntosInteresId;
            var idImagen = _imagenInteres.Id;

            try
            {
                if (MessageBox.Show("¿Seguro que quieres eliminar esta imágen?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var exito = await _api.Delete($"/api/reta3/rutas/{idRuta}/puntosinteres/{idPunto}/imagenes", idImagen.ToString());
                    if (exito)
                    {
                        MessageBox.Show("Imágen eliminada correctamente");
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new CrearEditarImagenInteres(_api, _imagenInteres, _imagenInteres.RutaId, _imagenInteres.PuntosInteresId))
                {
                    var result = form.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        _imagenInteres = form.ImagenInteres;
                        ucImagenInteresCompleto1.SetData(_api, _imagenInteres);
                    }
                }

            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate();
            }
        }
    }
}
