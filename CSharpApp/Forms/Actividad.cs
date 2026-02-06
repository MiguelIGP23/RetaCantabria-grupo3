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
    public partial class Actividad : Form
    {
        private Ruta _ruta { get; set; }
        private ApiReta _api { get; set; }
        public Actividad(Ruta ruta, ApiReta api)
        {
            InitializeComponent();
            _ruta = ruta;
            _api = api;
        }

        private void Actividad_Load(object sender, EventArgs e)
        {
            CargarActividad(_ruta);
        }

        private void btn_Nueva_Click(object sender, EventArgs e)
        {
            AgregarActividades agregarActividad = new AgregarActividades();
            agregarActividad.Show();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {

        }

        public async void CargarActividad(Ruta ruta)
        {
            
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
