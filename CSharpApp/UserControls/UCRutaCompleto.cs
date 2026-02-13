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
    public partial class UCRutaCompleto : UserControl
    {
        // Representa la ruta asociada al user control
        public Ruta Ruta { get; set; }

        public UCRutaCompleto()
        {
            InitializeComponent();
        }

        // Método para cargar los datos de la ruta en el user control
        public void SetData(Ruta ruta)
        {
            Ruta = ruta;
            double altMin = (double)ruta.AltitudMax;
            double altMax = (double)ruta.AltitudMin;
            double desNeg = (double)ruta.DesnivelNegativo;
            double desPos = (double)ruta.DesnivelPositivo;

            lbltxtId.Text = ruta.Id.ToString();
            lbltxtNombre.Text = ruta.Nombre;
            lbltxtInicioRuta.Text = ruta.Nombre_inicioruta;
            lbltxtFinRuta.Text = ruta.Nombre_finalruta;
            lbltxtLatInicial.Text = ruta.LatitudInicial.ToString("F4");
            lbltxtLatFinal.Text = ruta.LatitudFinal.ToString("F4");
            lbltxtLonInicial.Text = ruta.LongitudInicial.ToString("F4");
            lbltxtLonFinal.Text = ruta.LongitudFinal.ToString("F4");
            lbltxtDistancia.Text = ruta.Distancia.ToString("F2") + " m";
            lbltxtDuracion.Text = ruta.Duracion.ToString();
            lbltxtDesnivelPositivo.Text = desPos.ToString("F2") + " m";
            lbltxtDesnivelNegativo.Text = desNeg.ToString("F2") + " m";
            lbltxtAltitudMaxima.Text = altMax.ToString("F2") + " m";
            lbltxtAltitudMinima.Text = altMin.ToString("F2") + " m";
            lbltxtClasificacion.Text = ruta.Clasificacion.ToString();
            lbltxtNivelEsfuerzo.Text = ruta.NivelEsfuerzo.ToString();
            lbltxtNivelRiesgo.Text = ruta.NivelRiesgo.ToString();
            lbltxtEstadoRuta.Text = ruta.EstadoRuta switch
            {
                1 => "Aprobada",
                0 => "Pendiente",
                _ => "Borrador"
            };
            lbltxtTipoTerreno.Text = ruta.TipoTerreno.ToString();
            lbltxtIndicaciones.Text = ruta.Indicaciones.ToString();
            string temporadas = ruta.Temporadas!=null ? ruta.Temporadas.Replace(",", ", ") : "";
            lbltxtTemporadas.Text = temporadas;
            lbltxtAccesibilidad.Text = (ruta.Accesibilidad == 1) ? "SI" : "NO";
            lbltxtRutaFamiliar.Text = (ruta.RutaFamiliar == 1) ? "SI" : "NO";
            lbltxtRecomendaciones.Text = ruta.RecomendacionesEquipo;
            lbltxtZonaGeografica.Text = ruta.ZonaGeografica;
            lbltxtPuntuacion.Text = ruta.MediaEstrellas.ToString();
        }

    }
}
