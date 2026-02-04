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
            lbltxtDistancia.Text = $"{r.Distancia} m";
            lbltxtDuracion.Text = r.Duracion;
            lbltxtEstrellas.Text = $"{r.MediaEstrellas} ★";
            BackColor = r.EstadoRuta switch
            {
                0 => Color.LightCoral,
                1 => Color.LightGreen,
            };
        }
    }
}
