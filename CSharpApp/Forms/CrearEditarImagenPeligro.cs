using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class CrearEditarImagenPeligro : Form
    {

        private readonly ApiReta _api;
        public ImagenPeligro ImagenPeligro { get; private set; }

        private ImagenPeligro _imagenPeligro { get; set; }
        private readonly int _idRuta;
        private readonly int _idPuntoPeligro;
        private string? _archivoSeleccionado64;


        public CrearEditarImagenPeligro(ApiReta api, ImagenPeligro imagenPeligro, int idRuta, int idPuntoPeligro)
        {
            InitializeComponent();
            _api = api;
            _idRuta = idRuta;
            _imagenPeligro = imagenPeligro;
            _idPuntoPeligro = idPuntoPeligro;
        }


        private void CrearEditarImagenPeligro_Load(object sender, EventArgs e)
        {
            lbltxtPuntoPeligro.Text = _idPuntoPeligro.ToString();
            tbDescripcion.Text = _imagenPeligro != null ? _imagenPeligro.Descripcion : "";
        }


        // Metodos de botones

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            ImagenPeligro nueva = (_imagenPeligro != null) ? _imagenPeligro : new ImagenPeligro();
            nueva.Descripcion = tbDescripcion.Text;
            nueva.Url = _archivoSeleccionado64;

            nueva.RutaId = _idRuta;
            nueva.PuntosPeligroId = _idPuntoPeligro;

            if (string.IsNullOrWhiteSpace(nueva.Descripcion) || string.IsNullOrWhiteSpace(nueva.Url))
            {
                MessageBox.Show("La descripción y la URL son obligatorios.");
                return;
            }

            try
            {
                ImagenPeligro correcto;

                if (_imagenPeligro != null)
                {
                    correcto = await _api.Update<ImagenPeligro>($"api/reta3/rutas/{_idRuta}/puntospeligro/{_idPuntoPeligro}/imagenes", nueva.Id.ToString(), nueva);
                    MessageBox.Show("Imagen de peligro actualizada correctamente.");
                }
                else
                {

                    correcto = await _api.Create<ImagenPeligro>($"api/reta3/rutas/{_idRuta}/puntospeligro/{_idPuntoPeligro}/imagenes", nueva);
                    MessageBox.Show("Imagen de peligro creada correctamente.");
                }

                ImagenPeligro = correcto;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
