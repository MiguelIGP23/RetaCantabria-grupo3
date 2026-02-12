using Model;
using Repository;

namespace Forms
{
    public partial class PuntoInteresDetalle : Form
    {

        private readonly ApiReta _api;

        private Ruta _ruta { get; set; }
        private PuntoInteres _puntoInteres { get; set; }

        public PuntoInteresDetalle(ApiReta api, Ruta ruta, PuntoInteres puntoInteres)
        {
            InitializeComponent();
            _api = api;
            _ruta = ruta;
            _puntoInteres = puntoInteres;
        }



        // Carga en el user control los datos del punto de interes pasado
        private void PuntoInteresDetalle_Load(object sender, EventArgs e)
        {
            ucPuntoDeInteresCompleto1.SetData(_puntoInteres);
            if (Session.Rol != EnumRoles.ADMINISTRADOR)
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
            }
        }

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

                using (var form = new EditarPuntoInteres(_api, _puntoInteres))
                {
                    var result = form.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        _puntoInteres = form.PuntoInteres;
                        ucPuntoDeInteresCompleto1.SetData(_puntoInteres);
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
            var idRuta = _puntoInteres.RutaId;
            var idPunto = _puntoInteres.Id;

            try
            {
                if (MessageBox.Show("¿Seguro que quieres eliminar este punto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var exito = await _api.Delete($"/api/reta3/rutas/{idRuta}/puntosinteres", idPunto.ToString());
                    if (exito)
                    {
                        MessageBox.Show("Punto eliminado correctamente");
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

        private void btnImagenes_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new ImagenesInteresLista(_api, _ruta, _puntoInteres))
                {
                    form.ShowDialog(this);
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
