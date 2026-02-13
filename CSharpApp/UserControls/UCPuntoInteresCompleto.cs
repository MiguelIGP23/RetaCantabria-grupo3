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
    public partial class UCPuntoInteresCompleto : UserControl
    {
        public PuntoInteres PuntoInteres { get; set; }
        public UCPuntoInteresCompleto()
        {
            InitializeComponent();
        }


        // Método para cargar los datos del punto de interes en el user control
        public void SetData(PuntoInteres p)
        {
            PuntoInteres = p;
            lbltxtIdPuntoDeInteres.Text = p.Id.ToString();
            lbltxtRutasid.Text = p.RutaId.ToString();
            lbltxtNombre.Text = p.Nombre;
            lbltxtLatitud.Text = p.Latitud.ToString("F4");
            lbltxtLogitud.Text = p.Longitud.ToString("f4");
            lbltxtElevacion.Text = p.Elevacion.ToString("F3");
            lbltxtCaracteristicas.Text = p.Caracteristicas;
            lbltxtTipo.Text = p.Tipo.ToString();
            lbltxtDescripcion.Text = p.Descripcion;
            lbltxtTimestamp.Text = p.Timestamp.ToString();
  
        }
    }
}
