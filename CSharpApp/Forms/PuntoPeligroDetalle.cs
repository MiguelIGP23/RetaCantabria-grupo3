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
    public partial class PuntoPeligroDetalle : Form
    {

        private readonly ApiReta _api;

        private Ruta _ruta { get; set; }
        private PuntoPeligro _puntoPeligro { get; set; }


        public PuntoPeligroDetalle(ApiReta api, Ruta ruta, PuntoPeligro puntoPeligro)
        {
            InitializeComponent();
            _api = api;
            _ruta = ruta;
            _puntoPeligro = puntoPeligro;
        }



        // Carga en el user control los datos del punto de peligro pasado
        private void PuntoPeligroDetalle_Load(object sender, EventArgs e)
        {
            ucPuntoPeligroCompleto1.SetData(_puntoPeligro);
            if (Session.Rol != EnumRoles.ADMINISTRADOR)
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var idRuta = _puntoPeligro.RutaId;
            var idPunto = _puntoPeligro.Id;

            try
            {
                if (MessageBox.Show("¿Seguro que quieres eliminar esta imágen?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var exito = await _api.Delete($"/api/reta3/rutas/{idRuta}/puntospeligro", idPunto.ToString());
                    if (exito)
                    {
                        MessageBox.Show("Imágen eliminada :) correctamente");
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



        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new EditarPuntoPeligro(_api, _puntoPeligro))
                {
                    var result = form.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        _puntoPeligro = form.PuntoPeligro;
                        ucPuntoPeligroCompleto1.SetData(_puntoPeligro);
                    }
                }

            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate();
            }
        }



        private void btnImagenes_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new ImagenesPeligroLista(_api, _ruta, _puntoPeligro))
                {
                    form.ShowDialog(this);
                }

            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate();
            }
        }
    }
}
