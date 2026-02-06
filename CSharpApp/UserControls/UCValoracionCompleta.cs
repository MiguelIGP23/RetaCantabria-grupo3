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
    public partial class UCValoracionCompleta : UserControl
    {
        public Valoracion valoracion { get; set; }
        public UCValoracionCompleta()
        {
            InitializeComponent();
        }

        public void SetData(Valoracion v)
        {
            valoracion = v;
            lbl_txtIdValora.Text = v.IdValora.ToString();
            lbl_txtDificultad.Text = v.Dificultad.ToString();
            lbl_txtFecha.Text = v.Fecha.ToString();
            lbl_txtEstrellas.Text = v.Estrellas.ToString();
            lbl_txtInteresCultural.Text = v.InteresCultural.ToString();
            lbl_txtBelleza.Text = v.Belleza.ToString();
            lbl_txtValoracionTecnica.Text = v.ValoracionTecnica;
            lbl_txtResena.Text = v.Resena;
            lbl_txtIdUsuario.Text = v.Usuario_idUsuario.ToString();
            lbl_txtIdRuta.Text = v.Rutas_idRuta.ToString();
        }
    }
}
