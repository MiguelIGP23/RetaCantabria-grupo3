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
            lbltxtRuta.Text = a.rutaId.ToString();
        }
    }
}
