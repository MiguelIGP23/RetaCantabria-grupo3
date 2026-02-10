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

namespace UserControls
{
    public partial class UCUsuarioLista : UserControl
    {

        public Usuario usuario { get; set; }
        public UCUsuarioLista()
        {
            InitializeComponent();
        }
        public void SetData(Usuario u)
        {
            usuario = u;
            lbltxtId.Text = u.Id.ToString();
            lbltxtNombre.Text = u.Nombre;
            lbltxtApellido.Text = u.Apellido;
        }
        public event EventHandler<Usuario> UsuarioClick;
        private void lbltxtId_Click(object sender, EventArgs e)
        {
            UsuarioClick?.Invoke(this, usuario);
        }

        private void lbltxtNombre_Click(object sender, EventArgs e)
        {
            UsuarioClick?.Invoke(this, usuario);
        }

        private void lbltxtApellido_Click(object sender, EventArgs e)
        {
            UsuarioClick?.Invoke(this, usuario);
        }

        private void UCUsuarioLista_Click(object sender, EventArgs e)
        {
            UsuarioClick?.Invoke(this, usuario);
        }


    }
}
