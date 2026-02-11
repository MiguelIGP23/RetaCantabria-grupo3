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
    public partial class RutasDetalle : Form
    {
        private Ruta _ruta { get; set; }
        private readonly ApiReta _api;

        public RutasDetalle(Ruta ruta, ApiReta api)
        {
            InitializeComponent();
            _ruta = ruta;
            _api = api;
            cbFicha.SelectedIndex = 0;
        }



        // Carga en el user control los datos de la ruta pasada
        private void RutasDetalle_Load(object sender, EventArgs e)
        {
            ucRutaCompleto1.SetData(_ruta);
            btnValidar.Text = (_ruta.EstadoRuta == (byte)0) ? "Validar" : "Invalidar";
        }



        // Metodos de botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnPuntosPeligro_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new PuntosPeligroLista(_api, _ruta))
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



        private async void pbDescarga_Click(object sender, EventArgs e)
        {
            int idRuta = _ruta.Id;

            string downloads = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string opcion = cbFicha.SelectedItem?.ToString();

            try
            {
                switch (opcion)
                {
                    case "Usuario":
                        await _api.DescargarFichaUsuarioAsync(idRuta, downloads);
                        break;

                    case "Organización":
                        await _api.DescargarFichaOrganizacionAsync(idRuta, downloads);
                        break;

                    case "Seguridad":
                        await _api.DescargarFichaSeguridadAsync(idRuta, downloads);
                        break;
                }
                MessageBox.Show("Ficha guardada en Descargas");
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }



        private void btnPuntosInteres_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new PuntosInteresLista(_api, _ruta))
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



        private void btnActividades_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new ActividadLista(_api, _ruta))
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



        private void btnValoraciones_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.Enabled = false;
            //    this.Opacity = 0;

            //    using (var form = new ValoracionesLista(_api, _ruta))
            //    {
            //        form.ShowDialog(this);
            //    }

            //}
            //finally
            //{
            //    this.Opacity = 1;
            //    this.Enabled = true;
            //    this.Activate();
            //}
        }



        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = _ruta.Id;
                if (MessageBox.Show("¿Seguro que quieres eliminar esta ruta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var exito = await _api.Delete($"/api/reta3/rutas", id.ToString());
                    if (exito)
                    {
                        MessageBox.Show("Ruta eliminada correctamente");
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

                using (var form = new CrearEditarRuta(_api, _ruta))
                {
                    var result = form.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        _ruta = form.Ruta;
                        ucRutaCompleto1.SetData(_ruta);
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


        private async void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = _ruta.Id;
                string msj = (_ruta.EstadoRuta == (byte)0) ? "Validar" : "Quitar validación de";
                if (MessageBox.Show($"¿{msj} esta ruta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var exito = await _api.Validar($"/api/reta3/rutas/{_ruta.Id}/validar", _ruta);
                    if (exito != null)
                    {
                        msj = (exito.EstadoRuta == (byte)1) ? "validada" : "invalidada";
                        MessageBox.Show($"Ruta {msj} correctamente");
                        _ruta = exito;
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }

            ucRutaCompleto1.SetData(_ruta);
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            using (var form = new Mapa(_api, _ruta))
            {
                var result = form.ShowDialog(this);
            }
        }
    }
}
