using Model;
using Repository;
using RetaEquipo3;
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
    public partial class EditarPuntoPeligro : BaseForm
    {

        private readonly ApiReta _api;
        private PuntoPeligro _puntoPeligro { get; set; }
        public PuntoPeligro PuntoPeligro { get; private set; }


        public EditarPuntoPeligro(ApiReta api, PuntoPeligro puntoInteres)
        {
            InitializeComponent();
            _api = api;
            _puntoPeligro = puntoInteres;
        }

        private void EditarPuntoPeligro_Load(object sender, EventArgs e)
        {
            if (_puntoPeligro != null)
            {
                CargarDatos(_puntoPeligro);
            }
            else
            {
                lbltxtRuta.Text = "0";
                tbNombre.Text = "";
                nudPosicion.Value = 0;
                nudLatitud.Value = 0;
                nudLongitud.Value = 0;
                nudElevacion.Value = 0;
                nudKilometro.Value = 0;
                nudGravedad.Value = 1;
                nudTimestamp.Value = 0;
                tbDescripcion.Text = "";

            }
        }



        public void CargarDatos(PuntoPeligro puntoInteres)
        {
            lbltxtRuta.Text = puntoInteres.RutaId.ToString();
            tbNombre.Text = puntoInteres.Nombre;
            nudPosicion.Value = puntoInteres.Posicion != null ? (decimal)puntoInteres.Posicion : 0;
            nudLatitud.Value = (decimal)puntoInteres.Latitud;
            nudLongitud.Value = (decimal)puntoInteres.Longitud;
            nudElevacion.Value = (decimal)puntoInteres.Elevacion;
            nudKilometro.Value = puntoInteres.Kilometros != null ? (decimal)puntoInteres.Kilometros : 0;
            nudGravedad.Value = puntoInteres.Gravedad != null ? (decimal)puntoInteres.Gravedad : 0;
            nudTimestamp.Value = puntoInteres.Timestamp != null ? (decimal)puntoInteres.Timestamp : 0;
            tbDescripcion.Text = puntoInteres.Descripcion;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            _puntoPeligro.Nombre = tbNombre.Text;
            _puntoPeligro.Posicion = (int)nudPosicion.Value;
            _puntoPeligro.Latitud = (double)nudLatitud.Value;
            _puntoPeligro.Longitud = (double)nudLongitud.Value;
            _puntoPeligro.Elevacion = (double)nudElevacion.Value;
            _puntoPeligro.Kilometros = (double)nudKilometro.Value;
            _puntoPeligro.Gravedad = (int)nudGravedad.Value;
            _puntoPeligro.Timestamp = (int)nudTimestamp.Value;
            _puntoPeligro.Descripcion = tbDescripcion.Text;

            if(string.IsNullOrWhiteSpace(_puntoPeligro.Nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                await _api.Update<PuntoPeligro>($"api/reta3/rutas/{_puntoPeligro.RutaId}/puntospeligro", _puntoPeligro.Id.ToString(), _puntoPeligro);
                MessageBox.Show("Punto de peligro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
                return;
            }

            PuntoPeligro = _puntoPeligro;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
