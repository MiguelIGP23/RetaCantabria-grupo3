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
            lbltxtId.Text = ruta.IdRuta.ToString();
            lbltxtNombre.Text = ruta.Nombre;
            lbltxtInicioRuta.Text = ruta.Nombre_inicioruta;
            lbltxtFinRuta.Text = ruta.Nombre_finalruta;
            lbltxtLatInicial.Text = ruta.LatitudInicial.ToString();
            lbltxtLatFinal.Text = ruta.LatitudFinal.ToString();
            lbltxtLonInicial.Text = ruta.LongitudInicial.ToString();
            lbltxtLonFinal.Text = ruta.LongitudFinal.ToString();
            lbltxtDistancia.Text = ruta.Distancia.ToString("F2") + " m";
            lbltxtDuracion.Text = ruta.Duracion.ToString();
            lbltxtDesnivelPositivo.Text = ruta.DesnivelPositivo.ToString() + " m";
            lbltxtDesnivelNegativo.Text = ruta.DesnivelNegativo.ToString() + " m";
            lbltxtAltitudMaxima.Text = ruta.AltitudMax.ToString() + " m";
            lbltxtAltitudMinima.Text = ruta.AltitudMin.ToString() + " m";
            lbltxtClasificacion.Text = ruta.Clasificacion.ToString();
            lbltxtNivelEsfuerzo.Text = ruta.NivelEsfuerzo.ToString();
            lbltxtNivelRiesgo.Text = ruta.NivelRiesgo.ToString();
            lbltxtEstadoRuta.Text = (ruta.EstadoRuta == 1) ? "Aprobada" : "En espera";
            lbltxtTipoTerreno.Text = ruta.TipoTerreno.ToString();
            lbltxtIndicaciones.Text = ruta.Indicaciones.ToString();
            lbltxtTemporadas.Text = ruta.Temporadas.ToString();
            lbltxtAccesibilidad.Text = (ruta.Accesibilidad == 1) ? "SI" : "NO";
            lbltxtRutaFamiliar.Text = (ruta.RutaFamiliar == 1) ? "SI" : "NO";
            lbltxtRecomendaciones.Text = ruta.RecomendacionesEquipo;
            lbltxtZonaGeografica.Text = ruta.ZonaGeografica;
            lbltxtPuntuacion.Text = ruta.MediaEstrellas.ToString();
        }

    }
}
