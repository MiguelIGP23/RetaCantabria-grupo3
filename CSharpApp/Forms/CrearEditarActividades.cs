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
        public Actividad Actividad { get; private set; }

        public CrearEditarActividades(ApiReta api, Actividad actividad)
        {
            InitializeComponent();
            _api = api;
            _actividad = actividad;

            if (Session.Rol != EnumRoles.ADMINISTRADOR)
            {
                cmbRuta.Enabled = false;
            }

        }
        private void CrearEditarActividades_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public async void CargarDatos()
        {
            await cargarRutas();
            if (_actividad != null)
            {
                txtNombre.Text = _actividad.Nombre;
                cmbRuta.SelectedValue = _actividad.RutaId;
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
                cmbRuta.DataSource= await _api.GetAlAsync<Ruta>("api/reta3/rutas");

                cmbRuta.DisplayMember = "Nombre";
                cmbRuta.ValueMember = "Id";
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }

        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Nombre obligatorio.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(cmbRuta.SelectedValue == null)
            {
                MessageBox.Show("Ruta obligatoria.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Actividad actividad = _actividad ?? new Actividad();
            actividad.Nombre = txtNombre.Text;
            actividad.RutaId = (int)cmbRuta.SelectedValue;

            try
            {
                if (_actividad == null)
                {
                    //crear
                    await _api.Create<Actividad>($"/api/reta3/rutas/{actividad.RutaId}/actividades", actividad);
                    MessageBox.Show("Actividad creada.");
                }
                else
                {
                    //editar
                    await _api.Update<Actividad>($"api/reta3/rutas/{actividad.RutaId}/actividades", actividad.Id.ToString(), actividad);
                    MessageBox.Show("Modificación correcta.");
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
                return;
            }
            Actividad = actividad;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private async void btnBorrar_Click(object sender, EventArgs e)
        {

            try
            {
                var id = _actividad.Id.ToString();
                var rutaId = _actividad.RutaId.ToString();
                if (MessageBox.Show("¿Seguro que quieres eliminar esta actividad?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var exito = await _api.Delete($"/api/reta3/rutas/{rutaId}/actividad", id);
                    if (exito)
                    {
                        MessageBox.Show("Acrividad eliminada correctamente");
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }
    }
    
}
