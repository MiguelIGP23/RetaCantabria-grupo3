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

namespace Forms
{
    public partial class UsuariosLista : Form
    {
        private ApiReta _api;


        public UsuariosLista(ApiReta api)
        {
            InitializeComponent();
            _api = api;
        }

        private async void UsuariosLista_Load(object sender, EventArgs e)
        {
            await CargarUsuarios();
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new Registro(_api, null))
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


        private async void UsuClick(object? sender, Usuario usuario)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new Registro(_api, usuario))
                {
                    form.ShowDialog(this);
                }

                await CargarUsuarios();
            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate(); // recupera foco en caso de que no se abra el hijo
            }
        }


        public async Task CargarUsuarios()
        {
            try
            {
                string ruta;
                List<Usuario> usuarios = await _api.GetAlAsync<Usuario>("api/reta3/usuarios");
                flpUsuarios.Controls.Clear();
                foreach (Usuario usu in usuarios)
                {
                    UCUsuarioLista uc = new UCUsuarioLista();
                    uc.SetData(usu);
                    uc.UsuarioClick += UsuClick;
                    flpUsuarios.Controls.Add(uc);
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }

 
    }
}
