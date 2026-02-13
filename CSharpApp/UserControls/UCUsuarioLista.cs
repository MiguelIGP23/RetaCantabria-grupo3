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

        public Usuario Usuario { get; set; }
        public UCUsuarioLista()
        {
            InitializeComponent();
        }

        public void SetData(Usuario u)
        {
            Usuario = u;
            lbltxtId.Text = u.Id.ToString();
            lbltxtNombre.Text = u.Nombre;
            lbltxtApellido.Text = u.Apellido;
            BackColor = Color.Gainsboro;
        }


        public event EventHandler<Usuario> UsuarioClick;
        
        private void lblId_Click(object sender, EventArgs e)
        {
            UsuarioClick?.Invoke(this, Usuario);
        }

        private void lbltxtId_Click_1(object sender, EventArgs e)
        {
            UsuarioClick?.Invoke(this, Usuario);
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            UsuarioClick?.Invoke(this, Usuario);
        }

        private void lbltxtNombre_Click_1(object sender, EventArgs e)
        {
            UsuarioClick?.Invoke(this, Usuario);
        }

        private void lblApellido_Click(object sender, EventArgs e)
        {
            UsuarioClick?.Invoke(this, Usuario);
        }

        private void lbltxtApellido_Click_1(object sender, EventArgs e)
        {
            UsuarioClick?.Invoke(this, Usuario);
        }

        private void UCUsuarioLista_Click_1(object sender, EventArgs e)
        {
            UsuarioClick?.Invoke(this, Usuario);
        }
    }
}
