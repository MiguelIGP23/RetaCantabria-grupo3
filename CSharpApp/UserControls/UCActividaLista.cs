using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class UCActividaLista : UserControl
    {

        // Representa la actividad asociada al user control
        public Actividad Actividad { get; set; }

        public UCActividaLista()
        {
            InitializeComponent();
        }

        // Carga en el user control los datos de la actividad dada como parámetro
        public void SetData(Actividad a)
        {
            Actividad = a;
            lbltxtNombre.Text = a.Nombre;
            lbltxtId.Text = a.IdActividad.ToString();
            lbltxtRuta.Text = a.RutaId.ToString();
        }

        public event EventHandler<Actividad> ActividadClick;

        private void lbltxtNombre_Click(object sender, EventArgs e)
        {
            ActividadClick?.Invoke(this, Actividad);
        }

        private void lbltxtId_Click(object sender, EventArgs e)
        {
            ActividadClick?.Invoke(this, Actividad);
        }

        private void lbltxtRuta_Click(object sender, EventArgs e)
        {
            ActividadClick?.Invoke(this, Actividad);
        }

        private void UCActividadLista_Click(object sender, EventArgs e)
        {
            ActividadClick?.Invoke(this, Actividad);
        }
    }
}
