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

        public UCPuntoDeInteresLista()
        {
            InitializeComponent();
        }
        public void SetData(PuntoInteres p)
        {
            puntoInteres = p;
            lbltxtNombre.Text = p.Nombre;
            lbltxtLatitud.Text = p.Latitud.ToString();
            lbltxtLongitud.Text = p.Longitud.ToString();
            lblTipo.Text = p.Tipo.ToString();
        }

    }
}
