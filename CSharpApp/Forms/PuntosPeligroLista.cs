using Model;
using Repository;
using UserControls;

namespace Forms
{
    public partial class PuntosPeligroLista : Form
    {
        private ApiReta _api { get; set; }
        private Ruta _ruta { get; set; }

        public PuntosPeligroLista(ApiReta api, Ruta ruta)
        {
            InitializeComponent();
            _api = api;
            _ruta = ruta;
        }

        private void PuntosPeligroLista_Load(object sender, EventArgs e)
        {
            CargarPuntosPeligro(_ruta);
        }


        // Método para cargar datos en la lista de user controls de puntos de peligro en el flowlayout
        public async void CargarPuntosPeligro(Ruta ruta)
        {
            try
            {
                List<PuntoPeligro> puntosPeligro = await _api.GetAllAsync<PuntoPeligro>($"api/reta3/rutas/{ruta.IdRuta}/puntospeligro");
                flpPuntosPeligro.Controls.Clear();
                foreach (PuntoPeligro p in puntosPeligro)
                {
                    UCPuntoPeligroLista uc = new UCPuntoPeligroLista(ruta);
                    uc.SetData(p, ruta);
                    uc.PuntoPeligroClick += PuntoPeligroClick;
                    flpPuntosPeligro.Controls.Add(uc);
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }



        // Métodos de eventos
        private void PuntoPeligroClick(object? sender, PuntoPeligro puntoPeligro)
        {
            using (var frm = new PuntoPeligroDetalle(_api, _ruta, puntoPeligro))
            {
                var result = frm.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    CargarPuntosPeligro(_ruta);
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
