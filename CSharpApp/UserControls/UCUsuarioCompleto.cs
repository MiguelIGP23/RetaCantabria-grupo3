using Model;

namespace UserControls
{
    public partial class UCUsuarioCompleto : UserControl
    {
        public Usuario usuario { get; set; }
        public UCUsuarioCompleto()
        {
            InitializeComponent();
        }

        public void SetData(Usuario u)
        {
            usuario = u;
            lbltxtId.Text = u.Id.ToString();
            lbltxtNombre.Text= u.Nombre;
            lbltxtApellido.Text= u.Apellido;
            lbltxtEmail.Text= u.Email;
            lbltxtRol.Text= u.Rol.ToString();
        }
    }
}
