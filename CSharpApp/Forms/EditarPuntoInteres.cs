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

namespace Forms
{
    public partial class EditarPuntoInteres : Form
    {

        private readonly ApiReta _api;
        private PuntoInteres _puntoInteres { get; set; }
        public PuntoInteres PuntoInteres { get; private set; }

        public EditarPuntoInteres(ApiReta api, PuntoInteres puntoInteres)
        {
            InitializeComponent();
            _api = api;
            _puntoInteres = puntoInteres;
            cbTipo.DataSource = Enum.GetValues(typeof(EnumTiposPuntoInteres));
        }

        private void EditarPuntoInteres_Load(object sender, EventArgs e)
        {
            if (_puntoInteres != null)
            {
                CargarDatos(_puntoInteres);
            }
            else
            {
                lbltxtId.Text = "0";
                lbltxtIdRuta.Text = "0";
                tbNombre.Text = "";
                nudLatitud.Value = 0;
                nudLongitud.Value = 0;
                nudElevacion.Value = 0;
                nudTimestamp.Value = 0;
                cbTipo.SelectedItem = EnumTiposPuntoInteres.CULTURAL;
                tbDescripcion.Text = "";
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        public void CargarDatos(PuntoInteres puntoInteres)
        {
            lbltxtId.Text = puntoInteres.Id.ToString();
            lbltxtIdRuta.Text = puntoInteres.IdRuta.ToString();
            tbNombre.Text = puntoInteres.Nombre;
            nudLatitud.Value = (decimal)puntoInteres.Latitud;
            nudLongitud.Value = (decimal)puntoInteres.Longitud;
            nudElevacion.Value = (decimal)puntoInteres.Elevacion;
            nudTimestamp.Value = puntoInteres.Timestamp != null ? (decimal)puntoInteres.Timestamp : 0;
            cbTipo.SelectedItem = puntoInteres.Tipo;
            tbCaractetisticas.Text = puntoInteres.Caracteristicas;
            tbDescripcion.Text = puntoInteres.Descripcion;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            _puntoInteres.Nombre = tbNombre.Text;
            _puntoInteres.Latitud = (double)nudLatitud.Value;
            _puntoInteres.Longitud = (double)nudLongitud.Value;
            _puntoInteres.Elevacion = (double)nudElevacion.Value;
            _puntoInteres.Timestamp = (int)nudTimestamp.Value;
            _puntoInteres.Tipo = (EnumTiposPuntoInteres)cbTipo.SelectedItem;
            _puntoInteres.Caracteristicas = tbCaractetisticas.Text;
            _puntoInteres.Descripcion = tbDescripcion.Text;

            if(string.IsNullOrWhiteSpace(_puntoInteres.Nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                await _api.Update<PuntoInteres>($"api/reta3/rutas/{_puntoInteres.IdRuta}/puntosinteres", _puntoInteres.Id.ToString(), _puntoInteres);
                MessageBox.Show("Punto de interés actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
                return;
            }

            PuntoInteres = _puntoInteres;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
