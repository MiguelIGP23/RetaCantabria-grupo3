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
            lbltxtId.Text = i.Id.ToString();
            lbltxtDescripcion.Text = i.Descripcion;
            BackColor = Color.LightGray;
        }



        // Eventos que se disparan al hacer click en el user control o sus etiquetas
        public event EventHandler<ImagenInteres> ImagenInteresClick;

        private void lblPuntoInteres_Click(object sender, EventArgs e)
        {
            ImagenInteresClick?.Invoke(this, ImagenDeInteres);
        }

        private void lbltxtPuntoInteres_Click(object sender, EventArgs e)
        {
            ImagenInteresClick?.Invoke(this, ImagenDeInteres);
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {
            ImagenInteresClick?.Invoke(this, ImagenDeInteres);
        }

        private void lbltxtDescripcion_Click(object sender, EventArgs e)
        {
            ImagenInteresClick?.Invoke(this, ImagenDeInteres);
        }

        private void UCImagenInteresLista_Click(object sender, EventArgs e)
        {
            ImagenInteresClick?.Invoke(this, ImagenDeInteres);
        }
    }
}
