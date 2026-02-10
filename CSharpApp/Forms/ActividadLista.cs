using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Repository;
using UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class ActividadLista : Form
    {
        private ApiReta api;
        private Ruta ruta;
        private List<Actividad> listaActividad = new List<Actividad>();

        public ActividadLista()
        {
            InitializeComponent();
        }

        public ActividadLista(ApiReta api, Ruta ruta)
        {
            this.api = api;
            this.ruta = ruta;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void ActividadClick(object? sender, Actividad actividad)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new CrearEditarActividades(api, actividad))
                {
                    form.ShowDialog(this);
                }

                await CargarActividades();
            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate(); // recupera foco en caso de que no se abra el hijo
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearEditarActividades crearEditarActividades = new CrearEditarActividades(api,null);
            crearEditarActividades.ShowDialog();
        }
        public async Task CargarActividades()
        {
            try
            {
                string ruta;
                List<Actividad> actividades = await api.GetAllAsync<Actividad>("api/reta3/actividades");
                listaActividad.Clear();
                flpActividad.Controls.Clear();
                foreach (Actividad a in actividades)
                {
                    UCActividaLista uc = new UCActividaLista();
                    uc.SetData(a);
                    uc.ActividadClick += ActividadClick;
                    flpActividad.Controls.Add(uc);
                    listaActividad.Add(a);
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }
    }
}
