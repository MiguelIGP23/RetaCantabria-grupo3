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
        }

        // Carga en el user control los datos de la ruta pasada
        private void RutasDetalle_Load(object sender, EventArgs e)
        {
            ucRutaCompleto1.SetData(_ruta);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPuntosPeligro_Click(object sender, EventArgs e)
        {
            PuntosPeligroLista form = new PuntosPeligroLista(_ruta, _api);
            form.Show();
        }
    }
}
