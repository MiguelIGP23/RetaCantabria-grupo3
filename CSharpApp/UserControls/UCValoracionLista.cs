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
        }
    }
}
