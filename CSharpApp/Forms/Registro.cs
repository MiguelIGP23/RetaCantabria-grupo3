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

namespace Forms
{
    public partial class Registro : Form
    {
        private readonly ApiReta _api;
        private Usuario _usuario;
        public Registro(ApiReta api, Usuario usuario)
        {
            InitializeComponent();
            _api = api;
            _usuario = usuario;
        }

        //private async void btnBorrar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var id = _usuario.Id;
        //        if (MessageBox.Show("¿Seguro que quieres eliminar esta ruta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //        {
        //            var exito = await _api.Delete($"/api/reta3/usuarios", id.ToString());
        //            if (exito)
        //            {
        //                MessageBox.Show("Ruta eliminada correctamente");
        //                this.DialogResult = DialogResult.Cancel;
        //                this.Close();
        //            }
        //        }
        //    }
        //    catch (HttpRequestException ex)
        //    {
        //        ApiReta.MostrarErrorHttp(ex);
        //    }
        //}

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
