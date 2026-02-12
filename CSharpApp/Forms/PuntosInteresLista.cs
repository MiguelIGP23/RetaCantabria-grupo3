using Model;
using Repository;
using UserControls;

namespace Forms
{
    public partial class PuntosInteresLista : Form
    {

        private readonly ApiReta _api;
        private Ruta _ruta { get; set; }

        public PuntosInteresLista(ApiReta api, Ruta ruta)
        {
            InitializeComponent();
            _api = api;
            _ruta = ruta;
        }

        private void PuntosInteresLista_Load(object sender, EventArgs e)
        {
            CargarPuntosInteres(_ruta);
        }



        //Método para cargar datos en la lista de user controls de puntos de interes en el flowlayout
        private async void CargarPuntosInteres(Ruta ruta)
        {
            try
            {
                List<PuntoInteres> puntosInteres = await _api.GetAlAsync<PuntoInteres>($"api/reta3/rutas/{ruta.Id}/puntosinteres");
                flpListaPuntos.Controls.Clear();
                foreach (PuntoInteres p in puntosInteres)
                {
                    UCPuntoInteresLista uc = new UCPuntoInteresLista(ruta);
                    uc.SetData(p, ruta);
                    uc.PuntoInteresClick += PuntoInteresClick;
                    flpListaPuntos.Controls.Add(uc);
                }
            }catch(HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);   
            }
        }




        // Métodos de eventos
        private void PuntoInteresClick(object? sender, PuntoInteres puntoInteres)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new PuntoInteresDetalle(_api, _ruta, puntoInteres))
                {
                    form.ShowDialog(this);
                }

                CargarPuntosInteres(_ruta);
            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate();
            }
        }




        // Métodos de botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
