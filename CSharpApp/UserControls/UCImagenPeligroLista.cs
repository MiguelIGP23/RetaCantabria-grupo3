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
    public partial class UCImagenPeligroLista : UserControl
    {
        // Representa la imagen de peligro asociada al user control
        public ImagenPeligro ImagenPeligro { get; set; }

        public UCImagenPeligroLista()
        {
            InitializeComponent();
        }

        // Carga en el user control los datos de la imagen de peligro dada como parámetro
        public void SetData(ImagenPeligro ip)
        {
            ImagenPeligro = ip;
            lbltxtPuntoPeligro.Text = ip.Puntospeligro_idPuntosinteres.ToString();
            lblDescripcion.Text = ip.Descripcion;
        }
    }
}
