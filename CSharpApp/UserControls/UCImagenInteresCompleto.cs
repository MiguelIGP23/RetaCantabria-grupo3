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
    public partial class UCImagenInteresCompleto : UserControl
    {

        public ImagenInteres ImagenInteres { get; private set; }
        public UCImagenInteresCompleto()
        {
            InitializeComponent();
        }

        public void SetData(Model.ImagenInteres imagenInteres)
        {
            ImagenInteres = imagenInteres;
            lbltxtPuntoInteres.Text = imagenInteres.PuntosInteresId.ToString();
            lbltxtImagen.Text = imagenInteres.Id.ToString();
            lbltxtDescripcion.Text = imagenInteres.Descripcion;
            //Falta cargar la imagen en el picturebox, se necesita un metodo para convertir el byte[] a imagen
        }
    }
}
