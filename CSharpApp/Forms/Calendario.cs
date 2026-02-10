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
    public partial class Calendario : Form
    {

        private readonly ApiReta _api;

        public Calendario(ApiReta api)
        {
            InitializeComponent();
            _api = api;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void mcCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dia = mcCalendario.SelectionStart.Date;
            string fecha = dia.ToString("yyyy-MM-dd");
            var rutas = await _api.GetAllAsync<Ruta>($"/api/reta3/calendario/fecha/{fecha}");
            int numRutas = rutas.Count;
            lbFecha.Text = dia.ToString() + ": "+numRutas;
        }
    }
}
