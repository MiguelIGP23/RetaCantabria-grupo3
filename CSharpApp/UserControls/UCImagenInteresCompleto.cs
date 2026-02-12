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

namespace UserControls
{
    public partial class UCImagenInteresCompleto : UserControl
    {
        public ImagenInteres ImagenInteres { get; private set; }

        public UCImagenInteresCompleto()
        {
            InitializeComponent();
        }


        public void SetData(ApiReta api, ImagenInteres imagenInteres)
        {
            ImagenInteres = imagenInteres;
            lbltxtPuntoInteres.Text = imagenInteres.PuntosInteresId.ToString();
            lbltxtImagen.Text = imagenInteres.Id.ToString();
            lbltxtDescripcion.Text = imagenInteres.Descripcion;

            pbImagen.Image?.Dispose();
            pbImagen.Image = null;
            if (!string.IsNullOrWhiteSpace(imagenInteres.Url))
            {
                byte[] bytes = Convert.FromBase64String(imagenInteres.Url);
                using var ms = new MemoryStream(bytes);
                pbImagen.Image = Image.FromStream(ms);
                pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }



       
    }
}
