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
    public partial class UCPuntoPeligroLista : UserControl
    {
        // Representa el punto de peligro asociado al user control
        public PuntoPeligro PuntoPeligro { get; set; }

        public UCPuntoPeligroLista()
        {
            InitializeComponent();
        }


        // Carga en el user control los datos del punto de peligro dado como parámetro
        public void SetData(PuntoPeligro pp, Ruta ruta)
        {
            PuntoPeligro = pp;
            lbltxtRuta.Text = ruta.IdRuta.ToString();
            lbltxtPosicion.Text = pp.Posicion.ToString();
            lbltxtNombre.Text = pp.Nombre;
            BackColor = pp.Gravedad switch
            {
                1 => Color.Chartreuse,
                2 => Color.YellowGreen,
                3 => Color.Khaki,
                4 => Color.LightSalmon,
                5 => Color.Red,
            };
        }
    }
}
