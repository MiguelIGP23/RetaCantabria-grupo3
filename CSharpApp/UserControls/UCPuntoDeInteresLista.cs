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
    public partial class UCPuntoDeInteresLista : UserControl
    {
        public PuntoInteres puntoInteres { get; set; }
        private Ruta _ruta { get; set; }

        public UCPuntoDeInteresLista(Ruta ruta)
        {
            InitializeComponent();
            _ruta = ruta;
        }
        public void SetData(PuntoInteres p, Ruta ruta)
        {
            puntoInteres = p;
            lbltxtNombre.Text = p.Nombre;
            lbltxtRuta.Text = ruta.IdRuta.ToString();
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
            };
        }

    }
}
