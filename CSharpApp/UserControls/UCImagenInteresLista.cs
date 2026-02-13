using Model;

namespace UserControls
{
    public partial class UCImagenInteresLista : UserControl
    {
        // Representa la imagende interes asociada al user control
        public ImagenInteres ImagenInteres { get; set; }

        public UCImagenInteresLista()
        {
            InitializeComponent();
        }

        // Carga en el user control los datos de la imagen de interes dada como parámetro
        public void SetData(ImagenInteres i)
        {
            ImagenInteres = i;
            lbltxtId.Text = i.Id.ToString();
            lbltxtDescripcion.Text = i.Descripcion;
            BackColor = Color.Gainsboro;
        }



        // Event que se dispara al hacer click en el user control o sus etiquetas
        public event EventHandler<ImagenInteres> ImagenInteresClick;

        private void lblPuntoInteres_Click(object sender, EventArgs e)
        {
            ImagenInteresClick?.Invoke(this, ImagenInteres);
        }

        private void lbltxtPuntoInteres_Click(object sender, EventArgs e)
        {
            ImagenInteresClick?.Invoke(this, ImagenInteres);
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {
            ImagenInteresClick?.Invoke(this, ImagenInteres);
        }

        private void lbltxtDescripcion_Click(object sender, EventArgs e)
        {
            ImagenInteresClick?.Invoke(this, ImagenInteres);
        }

        private void UCImagenInteresLista_Click(object sender, EventArgs e)
        {
            ImagenInteresClick?.Invoke(this, ImagenInteres);
        }
    }
}
