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
    public partial class UCValoracionLista : UserControl
    {
        public Valoracion valoracion { get; set; }
        public UCValoracionLista()
        {
            InitializeComponent();
        }

        public void SetData(Valoracion v)
        {
            valoracion = v;
            lbl_txtIdValora.Text = v.IdValora.ToString();
            lbl_txtDificultad.Text = v.Dificultad.ToString();
            lbl_txtFecha.Text = v.Fecha.ToString();
            lbl_txtInteresCultural.Text = v.InteresCultural.ToString();
            BackColor = Color.LightGray;
        }



        // Evento que se lanza al dar click en el user control o sus componentes
        public event EventHandler<Valoracion> ValoracionClick;
        private void lbl_id_Click(object sender, EventArgs e)
        {
            ValoracionClick?.Invoke(this, valoracion);
        }

        private void lbl_txtIdValora_Click(object sender, EventArgs e)
        {
            ValoracionClick?.Invoke(this, valoracion);
        }

        private void lbl_fecha_Click(object sender, EventArgs e)
        {
            ValoracionClick?.Invoke(this, valoracion);
        }

        private void lbl_txtFecha_Click(object sender, EventArgs e)
        {
            ValoracionClick?.Invoke(this, valoracion);
        }

        private void lbl_dificultad_Click(object sender, EventArgs e)
        {
            ValoracionClick?.Invoke(this, valoracion);
        }

        private void lbl_txtDificultad_Click(object sender, EventArgs e)
        {
            ValoracionClick?.Invoke(this, valoracion);
        }

        private void lbl_InteresC_Click(object sender, EventArgs e)
        {
            ValoracionClick?.Invoke(this, valoracion);
        }

        private void lbl_txtInteresCultural_Click(object sender, EventArgs e)
        {
            ValoracionClick?.Invoke(this, valoracion);
        }

        private void UCValoracionLista_Click(object sender, EventArgs e)
        {
            ValoracionClick?.Invoke(this, valoracion);
        }
    }
}
