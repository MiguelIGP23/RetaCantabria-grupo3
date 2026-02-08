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
                List<PuntoInteres> puntosInteres = await _api.GetAllAsync<PuntoInteres>($"api/reta3/rutas/{ruta.IdRuta}/puntosinteres");
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
            using (var frm = new PuntoInteresDetalle(_api, _ruta, puntoInteres))
            {
                var result = frm.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    CargarPuntosInteres(_ruta);
                }
            }
        }




        // Métodos de botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
