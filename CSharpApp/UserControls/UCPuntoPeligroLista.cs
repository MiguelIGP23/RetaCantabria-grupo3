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
                1 => ColorTranslator.FromHtml("#F3E9DD"),
                2 => ColorTranslator.FromHtml("#E6D2BE"),
                3 => ColorTranslator.FromHtml("#D6B59A"),
                4 => ColorTranslator.FromHtml("#C29573"),
                5 => ColorTranslator.FromHtml("#A6734F"),
                _ => Color.Gainsboro
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
