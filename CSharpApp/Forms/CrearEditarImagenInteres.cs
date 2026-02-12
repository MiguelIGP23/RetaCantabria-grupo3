using Model;
using Repository;
using System.Windows.Forms;

namespace Forms
{
    public partial class CrearEditarImagenInteres : Form
    {

        private readonly ApiReta _api;

        public ImagenInteres ImagenInteres { get; private set; }

        private ImagenInteres _imagenInteres { get; set; }
        private readonly int _idRuta;
        private readonly int _idPuntoInteres;
        private string? _archivoSeleccionado64;

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
            lbltxtPuntoInteres.Text = _idPuntoInteres.ToString();
            tbDescripcion.Text = _imagenInteres != null ? _imagenInteres.Descripcion : "";
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
            nueva.Url = _archivoSeleccionado64;

            nueva.RutaId = _idRuta;
            nueva.PuntosInteresId = _idPuntoInteres;

            if (string.IsNullOrWhiteSpace(nueva.Descripcion) || string.IsNullOrWhiteSpace(nueva.Url))
            {
                MessageBox.Show("La descripción y la imágen son obligatorios.");
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
                ofd.Filter = "Imágenes|*.png;*.jpg;*.jpeg";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (ofd.ShowDialog() != DialogResult.OK) return;

                byte[] bytes = File.ReadAllBytes(ofd.FileName);
                _archivoSeleccionado64 = Convert.ToBase64String(bytes);
                lblImagen.Text = "Imágen cargada!";
                //// Previsualizar
                //pb.Image?.Dispose();
                //using var ms = new MemoryStream(bytes);
                //pictureBox1.Image = Image.FromStream(ms);
                //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
