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
    public partial class UCPuntoPeligroCompleto : UserControl
    {
        // Representa el punto de peligro asociado al user control
        public PuntoPeligro PuntoPeligro { get; set; }

        public UCPuntoPeligroCompleto()
        {
            InitializeComponent();
        }

        // Carga en el user control los datos del punto de peligro dado como parámetro
        public void SetData(PuntoPeligro pp)
        {
            PuntoPeligro = pp;
            lbltxtRuta.Text = pp.RutaId.ToString();
            lbltxtPosicion.Text = pp.Posicion.ToString();
            lbltxtNombre.Text = pp.Nombre;
            lbltxtLatitud.Text = pp.Latitud.ToString();
            lbltxtLon.Text = pp.Longitud.ToString();
            lbltxtElevacion.Text = pp.Elevacion.ToString();
            lbltxtKilometro.Text = pp.Kilometros.ToString();
            lbltxtGravedad.Text = pp.Gravedad.ToString();
            lbltxtTimestamp.Text = pp.Timestamp.ToString();
            lbltxtDescripcion.Text = pp.Descripcion;

        }
    }
}
