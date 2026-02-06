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
    }
}
