using Dto;
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

namespace Forms
{
    public partial class Login : Form
    {

        private readonly ApiReta _api;

        public Login()
        {
            InitializeComponent();
            _api = new ApiReta("https://reta.raspiremote.org/");
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            btn_login.Enabled = false;
            try
            {
                string email = txt_usuario.Text;
                string pass = txt_password.Text;

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Petición de login al endpoint
                var req = new LoginRequest { Email = email, Password = pass };
                var resp = await _api.LoginAsync(req);

                if (resp == null || string.IsNullOrWhiteSpace(resp.Token))
                {
                    MessageBox.Show("Credenciales incorrectas.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var rol = Enum.Parse<EnumRoles>(resp.Rol, true);
                Session.Set(resp.Token, rol);

                // Abrir form principal, si se cierra volvemos a login
                var main = new RutasLista(_api);
                main.FormClosed += (_, __) =>
                {
                    txt_password.Text = "";
                    this.Show();
                };
                this.Hide();
                main.Show();

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error en la solicitud: {ex.Message}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_login.Enabled = true;
            }
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
           
        }


        

    }
}
