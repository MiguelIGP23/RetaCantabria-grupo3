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
    public partial class PuntosPeligroLista : Form
    {
        private Ruta _ruta { get; set; }
        private ApiReta _api { get; set; }

        public PuntosPeligroLista(Ruta ruta, ApiReta api)
        {
            InitializeComponent();
            _ruta = ruta;
            _api = api;
        }

        private void PuntosPeligroLista_Load(object sender, EventArgs e)
        {
            CargarPuntosPeligro(_ruta);
        }


        public async void CargarPuntosPeligro(Ruta ruta)
        {
            List<PuntoPeligro> puntosPeligro = await _api.GetAllAsync<PuntoPeligro>($"api/reta3/rutas/{ruta.IdRuta}/puntospeligro");
            flpPuntosPeligro.Controls.Clear();
            foreach (PuntoPeligro p in puntosPeligro)
            {
                UCPuntoPeligroLista uc = new UCPuntoPeligroLista();
                uc.SetData(p, ruta);
                flpPuntosPeligro.Controls.Add(uc);
            }
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
