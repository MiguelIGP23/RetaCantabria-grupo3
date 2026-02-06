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
    public partial class UCImagenInteresLista : UserControl
    {
        // Representa la imagende interes asociada al user control
        public ImagenInteres ImagenDeInteres { get; set; }

        public UCImagenInteresLista()
        {
            InitializeComponent();
        }

        // Carga en el user control los datos de la imagende interes dada como parámetro
        public void SetData(ImagenInteres i)
        {
            ImagenDeInteres = i;
            lbltxtPuntoInteres.Text = i.Descripcion;
            lbltxtDescripcion.Text = i.Descripcion;
        }
    }
}
