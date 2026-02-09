using Model;
using Repository;

namespace Forms
{
    public partial class CrearEditarImagenInteres : Form
    {

        private readonly ApiReta _api;

        public ImagenInteres ImagenInteres { get; private set; }

        private ImagenInteres _imagenInteres { get; set; }
        private readonly int _idRuta;
        private readonly int _idPuntoInteres;

        public CrearEditarImagenInteres(ApiReta api, ImagenInteres imagenInteres, int idRuta, int idPuntoInteres)
        {
            InitializeComponent();
            _api = api;
            _imagenInteres = imagenInteres;
            _idRuta = idRuta;
            _idPuntoInteres = idPuntoInteres;
        }


        private void CrearEditarImagenInteres_Load(object sender, EventArgs e)
        {
            if (_imagenInteres != null)
            {
                CargarDatos(_imagenInteres);
            }
            else
            {
                lbltxtPuntoInteres.Text = "";
                tbDescripcion.Text = "";
                tbUrl.Text = "";
            }
        }


        // Metodo para cargar datos en el user control

        public void CargarDatos(ImagenInteres imagenInteres)
        {
            lbltxtPuntoInteres.Text = imagenInteres.PuntosInteresId.ToString();
            tbDescripcion.Text = imagenInteres.Descripcion;
            tbUrl.Text = imagenInteres.Url;
        }



        // Metodos de botones

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            ImagenInteres nueva = (_imagenInteres != null) ? _imagenInteres : new ImagenInteres();
            nueva.Descripcion = tbDescripcion.Text;
            nueva.Url = tbUrl.Text;

            nueva.RutaId = _idRuta;
            nueva.PuntosInteresId = _idPuntoInteres;

            if (string.IsNullOrWhiteSpace(nueva.Descripcion) || string.IsNullOrWhiteSpace(nueva.Url))
            {
                MessageBox.Show("La descripción y la URL son obligatorios.");
                return;
            }

            try
            {
                ImagenInteres correcto;

                if (_imagenInteres != null)
                {
                    correcto = await _api.Update<ImagenInteres>($"api/reta3/rutas/{_idRuta}/puntosinteres/{_idPuntoInteres}/imagenes", nueva.Id.ToString(), nueva);
                    MessageBox.Show("Imagen de interés actualizada correctamente.");
                }
                else
                {

                    correcto = await _api.Create<ImagenInteres>($"api/reta3/rutas/{_idRuta}/puntosinteres/{_idPuntoInteres}/imagenes", nueva);
                    MessageBox.Show("Imagen de interés creada correctamente.");
                }

                ImagenInteres = correcto;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }

        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecciona una imágen";
                ofd.Filter = "Todos los archivos (*.*)|*.*";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = ofd.FileName;
                    string nombreArchivo = Path.GetFileName(ofd.FileName);
                    tbUrl.Text = rutaArchivo;
                }
            }
        }
    }
}
