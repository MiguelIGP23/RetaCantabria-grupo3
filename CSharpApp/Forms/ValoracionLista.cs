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
    public partial class ValoracionLista : Form
    {
        private readonly ApiReta _api;
        private Ruta _ruta;


        public ValoracionLista(ApiReta api, Ruta ruta)
        {
            InitializeComponent();
            _api = api;
            _ruta = ruta;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void ValoracionLista_Load(object sender, EventArgs e)
        {
            await CargarValoraciones();
        }


        public async Task CargarValoraciones()
        {
            try
            {
                string idRuta = _ruta.Id.ToString();
                List<Valoracion> valoraciones = await _api.GetAlAsync<Valoracion>($"api/reta3/rutas/{idRuta}/valoraciones");
                flp_valoracionLista.Controls.Clear();
                foreach (Valoracion v in valoraciones)
                {
                    UCValoracionLista uc = new UCValoracionLista();
                    uc.SetData(v);
                    uc.ValoracionClick += ValoracionClick;
                    flp_valoracionLista.Controls.Add(uc);
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }

        private async void ValoracionClick(object? sender, Valoracion valoracion)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new ValoracionDetalle(_api, _ruta, valoracion))
                {
                    form.ShowDialog(this);
                }

                await CargarValoraciones();
            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate(); // recupera foco en caso de que no se abra el hijo
            }
        }

        private async void btnNueva_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new CrearEditarValoraciones(_api, _ruta, null))
                {
                    form.ShowDialog(this);
                }

                await CargarValoraciones();
            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate(); // recupera foco en caso de que no se abra el hijo
            }
        }
    }
}
