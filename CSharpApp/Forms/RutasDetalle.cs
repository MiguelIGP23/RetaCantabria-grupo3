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
        }



        // Metodos de botones

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnPuntosPeligro_Click(object sender, EventArgs e)
        {
            PuntosPeligroLista form = new PuntosPeligroLista(_ruta, _api);
            form.Show();
        }



        private async void pbDescarga_Click(object sender, EventArgs e)
        {
            int idRuta = _ruta.IdRuta;

            string downloads = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string opcion = cbFicha.SelectedItem?.ToString();

            switch (opcion)
            {
                case "Usuario":
                    downloads = Path.Combine(downloads, "ficha-usuario.txt");
                    await _api.DescargarFichaUsuarioAsync(idRuta, downloads);
                    break;

                case "Organización":
                    downloads = Path.Combine(downloads, "ficha-organizacion.txt");
                    await _api.DescargarFichaOrganizacionAsync(idRuta, downloads);
                    break;

                case "Seguridad":
                    downloads = Path.Combine(downloads, "ficha-seguridad.txt");
                    await _api.DescargarFichaSeguridadAsync(idRuta, downloads);
                    break;
            }
            MessageBox.Show("Ficha guardada en Descargas");
        }



        private void btnPuntosInteres_Click(object sender, EventArgs e)
        {
            PuntosInteresLista form = new PuntosInteresLista(_api, _ruta);
            form.Show();
        }



        private void btnActividades_Click(object sender, EventArgs e)
        {
            
        }



        private void btnValoraciones_Click(object sender, EventArgs e)
        {

        }



        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = _ruta.IdRuta;
            if(MessageBox.Show("¿Seguro que quieres eliminar esta ruta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var exito = await _api.Delete($"/api/reta3/rutas/", id.ToString());
                if(exito)
                {
                    MessageBox.Show("Ruta eliminada correctamente");
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }


        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (var form = new CrearEditarRuta(_api, _ruta))
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    _ruta = form.Ruta;
                    ucRutaCompleto1.SetData(_ruta);
                }
            }


            
        }
    }
}
