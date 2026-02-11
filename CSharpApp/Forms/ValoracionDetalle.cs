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
    public partial class ValoracionDetalle : Form
    {
        private readonly ApiReta _api;
        private Valoracion _valoracion { get; set; }
        public Valoracion Valoracion { get; private set; }


        public ValoracionDetalle(ApiReta api, Valoracion valoracion)
        {
            InitializeComponent();
            _api = api;
            _valoracion = valoracion;
        }

        private void ValoracionDetalle_Load(object sender, EventArgs e)
        {
            ucValoracionCompleto1.SetData(_valoracion);
        }

        private async void btn_borrar_Click(object sender, EventArgs e)
        {
            var idValoracion = _valoracion.IdValora;
            var idRuta = _valoracion.RutaId;

            try
            {
                if (MessageBox.Show("¿Seguro que quieres eliminar esta valoracion?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var exito = await _api.Delete($"/api/reta3/rutas/{idRuta}/valoraciones", idValoracion.ToString());
                    if (exito)
                    {
                        MessageBox.Show("Valoracion eliminada correctamente");
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

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new CrearEditarValoraciones(_api, _valoracion))
                {
                    form.ShowDialog(this);
                }
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
