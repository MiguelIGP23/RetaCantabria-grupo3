using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UserControls
{
    public partial class UCPuntoInteresLista : UserControl
    {
        public PuntoInteres puntoInteres { get; set; }
        private Ruta _ruta { get; set; }

        public UCPuntoInteresLista(Ruta ruta)
        {
            InitializeComponent();
            _ruta = ruta;
        }
        public void SetData(PuntoInteres p, Ruta ruta)
        {
            puntoInteres = p;
            lbltxtNombre.Text = p.Nombre;
            lbltxtRuta.Text = ruta.Id.ToString();
            lbltxtTipo.Text = p.Tipo.ToString().Replace("_", " ");
            BackColor = p.Tipo switch
            {
                EnumTiposPuntoInteres.ALOJAMIENTO => Color.RebeccaPurple,
                EnumTiposPuntoInteres.AREA_DE_DESCANSO => Color.PeachPuff,
                EnumTiposPuntoInteres.BOTANICO => Color.GreenYellow,
                EnumTiposPuntoInteres.CULTURAL => Color.Chartreuse,
                EnumTiposPuntoInteres.FAUNA => Color.Salmon,
                EnumTiposPuntoInteres.GEOLOGICO => Color.Khaki,
                EnumTiposPuntoInteres.HISTORICO => Color.Aquamarine,
                EnumTiposPuntoInteres.MIRADOR => Color.Lime,
                EnumTiposPuntoInteres.PUNTO_DE_AGUA => Color.LightBlue,
                null => Color.White,
            };
        }



        // Evento que se dispara al hacer click en el user control o sus etiquetas
        public event EventHandler<PuntoInteres> PuntoInteresClick;
        private void lblRuta_Click(object sender, EventArgs e)
        {
            PuntoInteresClick?.Invoke(this, puntoInteres);
        }

        private void lbltxtRuta_Click(object sender, EventArgs e)
        {
            PuntoInteresClick?.Invoke(this, puntoInteres);
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {
            PuntoInteresClick?.Invoke(this, puntoInteres);
        }

        private void lbltxtTipo_Click(object sender, EventArgs e)
        {
            PuntoInteresClick?.Invoke(this, puntoInteres);
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            PuntoInteresClick?.Invoke(this, puntoInteres);
        }

        private void lbltxtNombre_Click(object sender, EventArgs e)
        {
            PuntoInteresClick?.Invoke(this, puntoInteres);
        }

        private void UCPuntoDeInteresLista_Click(object sender, EventArgs e)
        {
            PuntoInteresClick?.Invoke(this, puntoInteres);
        }

    }
}
