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

namespace Forms
{
    public partial class ImagenPeligroDetalle : Form
    {

        private readonly ApiReta _api;

        private Ruta _ruta { get; set; }
        private PuntoPeligro _puntoPeligro { get; set; }
        private ImagenPeligro _imagenPeligro { get; set; }

        public ImagenPeligroDetalle(ApiReta api, Ruta ruta, PuntoPeligro puntoPeligro, ImagenPeligro imagenPeligro)
        {
            InitializeComponent();
            _api = api;
            _ruta = ruta;
            _puntoPeligro = puntoPeligro;
            _imagenPeligro = imagenPeligro;
        }

        private void ImagenPeligroDetalle_Load(object sender, EventArgs e)
        {
            imagenPeligroCompleto1.SetData(_imagenPeligro);
            if (Session.Rol != EnumRoles.ADMINISTRADOR)
            {
                btnEditar.Visible = false;
                btnEditar.Visible = false;
                this.Size = new Size(445, 610);
            }
        }



        // Metodos de los botones

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new CrearEditarImagenPeligro(_api, _imagenPeligro, _imagenPeligro.RutaId, _imagenPeligro.PuntosPeligroId))
                {
                    var result = form.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        _imagenPeligro = form.ImagenPeligro;
                        imagenPeligroCompleto1.SetData(_imagenPeligro);
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



        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var idRuta = _imagenPeligro.RutaId;
            var idPunto = _imagenPeligro.PuntosPeligroId;
            var idImagen = _imagenPeligro.Id;

            try
            {
                if (MessageBox.Show("¿Seguro que quieres eliminar esta imágen?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var exito = await _api.Delete($"/api/reta3/rutas/{idRuta}/puntospeligro/{idPunto}/imagenes", idImagen.ToString());
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



    }
}
