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
using UserControls;
using static System.Net.Mime.MediaTypeNames;

namespace Forms
{
    public partial class ImagenesPeligroLista : Form
    {

        private readonly ApiReta _api;

        private Ruta _ruta { get; set; }
        private PuntoPeligro _puntoPeligro { get; set; }


        public ImagenesPeligroLista(ApiReta api, Ruta ruta, PuntoPeligro puntoPeligro)
        {
            InitializeComponent();
            _api = api;
            _ruta = ruta;
            _puntoPeligro = puntoPeligro;
        }

        private void ImagenesPeligroLista_Load(object sender, EventArgs e)
        {
            CargarImagenes(_puntoPeligro);
        }



        // Metodo pra cargar datos en la lista de user controls de imagenes de peligro en el flowlayout
        private async void CargarImagenes(PuntoPeligro puntoPeligro)
        {
            try
            {
                var idPunto = puntoPeligro.Id;
                var idRuta = puntoPeligro.RutaId;

                List<ImagenPeligro> imagenes = await _api.GetAlAsync<ImagenPeligro>($"api/reta3/rutas/{idRuta}/puntospeligro/{idPunto}/imagenes");
                flpImagenes.Controls.Clear();
                foreach (ImagenPeligro i in imagenes)
                {
                    UCImagenPeligroLista uc = new UCImagenPeligroLista();
                    uc.SetData(i);
                    uc.ImagenPeligroClick += ImagenPeligroClick;
                    flpImagenes.Controls.Add(uc);
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }



        // Metodos de eventos
        private void ImagenPeligroClick(object? sender, ImagenPeligro imagen)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new ImagenPeligroDetalle(_api, _ruta, _puntoPeligro, imagen))
                {
                    form.ShowDialog(this);
                }

                CargarImagenes(_puntoPeligro);
            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate();
            }
        }



        // Metodos de botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnNuevaImagen_Click(object sender, EventArgs e)
        {
            var idRuta = _puntoPeligro.RutaId;
            var idPunto = _puntoPeligro.Id;

            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new CrearEditarImagenPeligro(_api, null, idRuta, idPunto))
                {
                    form.ShowDialog(this);
                }

                CargarImagenes(_puntoPeligro);
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
