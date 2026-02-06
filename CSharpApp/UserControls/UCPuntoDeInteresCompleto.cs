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
    public partial class UCPuntoDeInteresCompleto : UserControl
    {
        public PuntoInteres puntoInteres { get; set; }
        public UCPuntoDeInteresCompleto()
        {
            InitializeComponent();
        }

        public void SetData(PuntoInteres p)
        {
            puntoInteres = p;
            lbltxtIdPuntoDeInteres.Text = p.IdPuntosinteres.ToString();
            lbltxtNombre.Text = p.Nombre;
            lbltxtLatitud.Text = p.Latitud.ToString();
            lbltxtLogitud.Text = p.Longitud.ToString();
            lbltxtElevacion.Text = p.Elevacion.ToString();
            lbltxtCaracteristicas.Text = p.Caracteristicas;
            lblTipo.Text = p.Tipo.ToString();
            lbltxtDescripcion.Text = p.Descripcion;
            lbltxtTimestamp.Text = p.Timestamp.ToString();
               




                
            

        }

    }
}
