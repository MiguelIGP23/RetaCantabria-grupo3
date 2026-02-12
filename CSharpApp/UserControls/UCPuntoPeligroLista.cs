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
        
        private Ruta _ruta { get; set; }


        public UCPuntoPeligroLista() { }
        public UCPuntoPeligroLista(Ruta ruta)
        {
            InitializeComponent();
            _ruta = ruta;
        }


        // Carga en el user control los datos del punto de peligro dado como parámetro
        public void SetData(PuntoPeligro pp, Ruta ruta)
        {
            PuntoPeligro = pp;
            lbltxtRuta.Text = ruta.Id.ToString();
            lbltxtPosicion.Text = pp.Posicion.ToString();
            lbltxtNombre.Text = pp.Nombre;
            BackColor = pp.Gravedad switch
            {
                1 => Color.Chartreuse,
                2 => Color.YellowGreen,
                3 => Color.Khaki,
                4 => Color.LightSalmon,
                5 => Color.Red,
                _=> Color.LightGray
            };
        }


        // Evento que se dispara al hacer click en el user control o sus etiquetas
        public event EventHandler<PuntoPeligro> PuntoPeligroClick;

        private void lblRuta_Click(object sender, EventArgs e)
        {
            PuntoPeligroClick?.Invoke(this, PuntoPeligro);
        }

        private void lbltxtRuta_Click(object sender, EventArgs e)
        {
            PuntoPeligroClick?.Invoke(this, PuntoPeligro);
        }

        private void lblPos_Click(object sender, EventArgs e)
        {
            PuntoPeligroClick?.Invoke(this, PuntoPeligro);
        }

        private void lbltxtPosicion_Click(object sender, EventArgs e)
        {
            PuntoPeligroClick?.Invoke(this, PuntoPeligro);
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            PuntoPeligroClick?.Invoke(this, PuntoPeligro);
        }

        private void lbltxtNombre_Click(object sender, EventArgs e)
        {
            PuntoPeligroClick?.Invoke(this, PuntoPeligro);
        }

        private void UCPuntoPeligroLista_Click(object sender, EventArgs e)
        {
            PuntoPeligroClick?.Invoke(this, PuntoPeligro);
        }
    }
}
