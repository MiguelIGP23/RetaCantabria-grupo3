using Repository;


namespace CSharpApp
{
    public partial class Rutas : Form
    {

        private readonly ApiReta _api = new ApiReta("http://localhost:8080");

        public Rutas()
        {
            InitializeComponent();
        }

        private void Rutas_Load(object sender, EventArgs e)
        {

        }
    }
}
