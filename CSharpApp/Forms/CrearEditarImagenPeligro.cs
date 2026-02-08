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
            if (_imagenPeligro != null)
            {
                CargarDatos(_imagenPeligro);
            }
            else
            {
                lbltxtPuntoPeligro.Text = "";
                tbDescripcion.Text = "";
                tbUrl.Text = "";
            }
        }



        // Metodo para cargar datos en el user control

        public void CargarDatos(ImagenPeligro imagenPeligro)
        {
            lbltxtPuntoPeligro.Text = imagenPeligro.PuntosPeligroId.ToString();
            tbDescripcion.Text = imagenPeligro.Descripcion;
            tbUrl.Text = imagenPeligro.Url;
        }



        // Metodos de botones

        private void button1_Click(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            ImagenPeligro nueva = (_imagenPeligro != null) ? _imagenPeligro : new ImagenPeligro();
            nueva.Descripcion = tbDescripcion.Text;
            nueva.Url = tbUrl.Text;

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
    }
}
