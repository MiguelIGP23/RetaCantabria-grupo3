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

        
    }
}
