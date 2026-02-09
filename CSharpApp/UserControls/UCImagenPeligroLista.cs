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
            lbltxtImagenId.Text = ip.Id.ToString();
            lbltxtDescripcion.Text = ip.Descripcion;
            BackColor = Color.LightGray;
        }



        // Evento que se dispara al hacer click en el user control o sus etiquetas 
        public event EventHandler<ImagenPeligro> ImagenPeligroClick;

        private void lblPuntoPeligro_Click(object sender, EventArgs e)
        {
            ImagenPeligroClick?.Invoke(this, ImagenPeligro);
        }

        private void lbltxtPuntoPeligro_Click(object sender, EventArgs e)
        {
            ImagenPeligroClick?.Invoke(this, ImagenPeligro);
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {
            ImagenPeligroClick?.Invoke(this, ImagenPeligro);
        }

        private void lbltxtDescripcion_Click(object sender, EventArgs e)
        {
            ImagenPeligroClick?.Invoke(this, ImagenPeligro);
        }

        private void UCImagenPeligroLista_Click(object sender, EventArgs e)
        {
            ImagenPeligroClick?.Invoke(this, ImagenPeligro);
        }
    }
}
