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
    public partial class UCRutaLista : UserControl
    {

        // Representa la ruta asociada al user control
        public Ruta Ruta { get; set; }

        public UCRutaLista()
        {
            InitializeComponent();
        }

        // Carga en el user control los datos del la ruta dada como parámetro
        public void SetData(Ruta r)
        {
            Ruta = r;
            lbltxtNombre.Text = r.Nombre;
            lbltxtDistancia.Text = r.Distancia.ToString("F2")+" m";
            lbltxtDuracion.Text = r.Duracion.ToString();
            lbltxtEstrellas.Text = $"{r.MediaEstrellas} ★";
            BackColor = r.EstadoRuta switch
            {
                0 => Color.LightSalmon,
                1 => Color.LightGreen,
                2 => Color.LightBlue,
            };
        }




        // Evento que se dispara al hacer click en el user control o sus etiquetas
        public event EventHandler<Ruta> RutaClick;

        private void lbltxtNombre_Click(object sender, EventArgs e)
        {
            RutaClick?.Invoke(this, Ruta);
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            RutaClick?.Invoke(this, Ruta);
        }

        private void lblDistancia_Click(object sender, EventArgs e)
        {
            RutaClick?.Invoke(this, Ruta);
        }

        private void lbltxtDistancia_Click(object sender, EventArgs e)
        {
            RutaClick?.Invoke(this, Ruta);
        }

        private void lblDuracion_Click(object sender, EventArgs e)
        {
            RutaClick?.Invoke(this, Ruta);
        }

        private void lbltxtDuracion_Click(object sender, EventArgs e)
        {
            RutaClick?.Invoke(this, Ruta);
        }

        private void lblEstrellas_Click(object sender, EventArgs e)
        {
            RutaClick?.Invoke(this, Ruta);
        }

        private void lbltxtEstrellas_Click(object sender, EventArgs e)
        {
            RutaClick?.Invoke(this, Ruta);
        }

        private void UCRutaLista_Click(object sender, EventArgs e)
        {
            RutaClick?.Invoke(this, Ruta);
        }
    }
}
