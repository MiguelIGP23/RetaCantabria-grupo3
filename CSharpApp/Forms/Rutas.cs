using Model;
using Repository;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;


namespace Forms
{
    public partial class Rutas : Form
    {

        private readonly ApiReta _api = new ApiReta("http://localhost:8080");

        public Rutas()
        {
            InitializeComponent();
        }

        private async void Rutas_Load(object sender, EventArgs e)
        {
            try
            {
                var rutas = await _api.GetAllAsync<Ruta>("api/reta3/rutas");

                dgv_rutas.AutoGenerateColumns = true;
                dgv_rutas.DataSource = rutas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
