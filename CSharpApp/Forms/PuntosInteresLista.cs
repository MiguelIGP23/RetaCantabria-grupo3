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


        private async void CargarPuntosInteres(Ruta ruta)
        {
            List<PuntoInteres> puntosInteres = await _api.GetAllAsync<PuntoInteres>($"api/reta3/rutas/{ruta.IdRuta}/puntosinteres");
            flpListaPuntos.Controls.Clear();
            foreach (PuntoInteres p in puntosInteres)
            {
                UCPuntoDeInteresLista uc = new UCPuntoDeInteresLista(ruta);
                uc.SetData(p, ruta);
                flpListaPuntos.Controls.Add(uc);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
