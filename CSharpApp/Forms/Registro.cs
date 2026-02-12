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
    public partial class Registro : BaseForm
    {
        private readonly ApiReta _api;
        private Usuario _usuario { get; set; }
        public Usuario Usuario { get; private set; }


        public Registro(ApiReta api, Usuario usuario)
        {
            InitializeComponent();
            _api = api;
            _usuario = usuario;
            cbRol.DataSource = Enum.GetValues(typeof(EnumRoles));

            
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            CargarDatos();
            if (Session.Rol != EnumRoles.ADMINISTRADOR)
            {
                btEliminar.Visible = false;
                ckPassword.Visible = false;
                cbRol.Visible = false;
                lblRol.Visible = false;
            }
            else
            {
                ckPassword.Visible = true;
                cbRol.Visible = true;
                lblRol.Visible = true;
                txt_password.Enabled = false;
                txt_rep_password.Enabled = false;
            }
        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btn_guardar_Click(object sender, EventArgs e)
        {
            bool creando = (_usuario == null);
            bool cambiarPass = creando || ckPassword.Checked;

            if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
               string.IsNullOrWhiteSpace(txt_apellido.Text) ||
               string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Nombre, apellido y email obligatorios.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cambiarPass)
            {
                if (string.IsNullOrWhiteSpace(txt_password.Text) ||
                    string.IsNullOrWhiteSpace(txt_rep_password.Text))
                {
                    MessageBox.Show("La contraseña es obligatoria");
                    return;
                }

                if (!string.Equals(txt_password.Text, txt_rep_password.Text))
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    return;
                }
            }


            Usuario usuario = _usuario ?? new Usuario();

            usuario.Nombre = txt_nombre.Text;
            usuario.Apellido = txt_apellido.Text;
            usuario.Email = txt_email.Text;

            if (cambiarPass)
            {
                usuario.Password = txt_password.Text;
            }
            else
            {
                usuario.Password = null;
            }

            try
            {
                if (_usuario == null)
                {
                    //crear
                    usuario.Rol = EnumRoles.ALUMNO;
                    await _api.Create<Usuario>($"/api/reta3/usuarios", usuario);
                    MessageBox.Show("Usuario creado.");
                }
                else
                {
                    //editar
                    if (Session.Rol == EnumRoles.ADMINISTRADOR) usuario.Rol = (EnumRoles)cbRol.SelectedItem;
                    await _api.Update<Usuario>("api/reta3/usuarios", usuario.Id.ToString(), usuario);
                    MessageBox.Show("Modificación correcta.");

                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
                return;
            }
            Usuario = usuario;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        public void CargarDatos()
        {
            txt_password.Text = "";
            txt_rep_password.Text = "";

            if (_usuario == null)
            {
                txt_nombre.Text = "";
                txt_apellido.Text = "";
                txt_email.Text = "";
            }
            else
            {
                txt_nombre.Text = _usuario.Nombre;
                txt_apellido.Text = _usuario.Apellido;
                txt_email.Text = _usuario.Email;
                cbRol.SelectedItem = _usuario.Rol;
                txt_password.Text = "";
                txt_rep_password.Text = "";
            }
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que quieres eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var exito = await _api.Delete($"/api/reta3/usuarios", _usuario.Id.ToString());
                    if (exito)
                    {
                        MessageBox.Show("Usuario eliminado correctamente");
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

        private void ckPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPassword.Checked)
            {
                txt_password.Enabled = true;
                txt_rep_password.Enabled = true;
            }
            else
            {
                txt_password.Text = "";
                txt_rep_password.Text = "";
                txt_password.Enabled = false;
                txt_rep_password.Enabled = false;
            }
        }
    }
}
