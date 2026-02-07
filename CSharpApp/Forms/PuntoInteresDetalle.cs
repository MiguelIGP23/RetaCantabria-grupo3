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
    public partial class PuntoInteresDetalle : Form
    {

        private readonly ApiReta _api;
        private PuntoInteres _puntoInteres { get; set; }

        public PuntoInteresDetalle(ApiReta api, PuntoInteres puntoInteres)
        {
            InitializeComponent();
            _api = api;
            _puntoInteres = puntoInteres;
        }



        // Carga en el user control los datos del punto de interes pasado
        private void PuntoInteresDetalle_Load(object sender, EventArgs e)
        {
            ucPuntoDeInteresCompleto1.SetData(_puntoInteres);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
