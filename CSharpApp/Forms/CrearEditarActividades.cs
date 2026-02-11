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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class CrearEditarActividades : Form
    {
        private readonly ApiReta _api;
        private Actividad _actividad;
        public CrearEditarActividades(ApiReta api, Actividad actividad)
        {
            InitializeComponent();
            _api = api;
            _actividad = actividad;

        }
        private void CrearEditarActividades_Load(object sender, EventArgs e)
        {
            CargarDatos(_actividad);
        }

        public void CargarDatos(Actividad actividad)
        {   
            cargarRutas();
            if (actividad!= null) {
                txtNombre.Text = actividad.Nombre;

                cmbRuta.SelectedValue = actividad.RutaId;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async Task cargarRutas()
        {
            try
            {

                List<Ruta> rutas1 = await _api.GetAlAsync<Ruta>("api/reta3/rutas");

                foreach (var r in rutas1)
                {
                    cmbRuta.Items.Add(r);
                }

                cmbRuta.DisplayMember = "Nombre";
                cmbRuta.ValueMember = "Id";
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Actividad actividad = new Actividad();
            actividad.Nombre = txtNombre.Text;
            actividad.RutaId = cmbRuta.SelectedIndex;
        }


    }
}
