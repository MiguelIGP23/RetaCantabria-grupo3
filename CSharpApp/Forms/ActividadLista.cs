using Model;
using Repository;
using UserControls;

namespace Forms
{
    public partial class ActividadLista : Form
    {
        private ApiReta _api;
        private Ruta _ruta;

        public ActividadLista(ApiReta api, Ruta ruta)
        {
            InitializeComponent();

            this._api = api;
            this._ruta = ruta;
        }

        private async void ActividadLista_Load(object sender, EventArgs e)
        {
            await CargarActividades();
            if (Session.Rol!=EnumRoles.ADMINISTRADOR &&
                Session.Rol != EnumRoles.DISENADOR &&
                Session.Rol != EnumRoles.PROFESOR) btnCrear.Visible=false;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private async void ActividadClick(object? sender, Actividad actividad)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new CrearEditarActividades(_api, actividad))
                {
                    form.ShowDialog(this);
                }

                await CargarActividades();
            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate(); // recupera foco en caso de que no se abra el hijo
            }
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new CrearEditarActividades(_api, null))
                {
                    form.ShowDialog(this);
                }

                await CargarActividades();
            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate(); // recupera foco en caso de que no se abra el hijo
            }
        }
        public async Task CargarActividades()
        {
            try
            {
                string idRuta = _ruta.Id.ToString();
                List<Actividad> actividades = await _api.GetAlAsync<Actividad>($"api/reta3/rutas/{idRuta}/actividades");
                flpActividad.Controls.Clear();
                foreach (Actividad a in actividades)
                {
                    UCActividaLista uc = new UCActividaLista();
                    uc.SetData(a);
                    uc.ActividadClick += ActividadClick;
                    flpActividad.Controls.Add(uc);
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }

  
    }
}
