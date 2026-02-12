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
    public partial class UCImagenPeligroCompleto : UserControl
    {

        public ImagenPeligro ImagenPeligro { get; set; }


        public UCImagenPeligroCompleto()
        {
            InitializeComponent();
        }


        public void SetData(ImagenPeligro imagenPeligro)
        {
            ImagenPeligro = imagenPeligro;
            lbltxtPuntoPeligro.Text = imagenPeligro.PuntosPeligroId.ToString();
            lbltxtImagenId.Text = imagenPeligro.Id.ToString();
            lbltxtDescripcion.Text = imagenPeligro.Descripcion;

            pbImagen.Image?.Dispose();
            pbImagen.Image = null;
            if (!string.IsNullOrWhiteSpace(imagenPeligro.Url))
            {
                byte[] bytes = Convert.FromBase64String(imagenPeligro.Url);
                using var ms = new MemoryStream(bytes);
                pbImagen.Image = Image.FromStream(ms);
                pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
