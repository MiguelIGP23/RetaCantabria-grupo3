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

namespace Forms
{
    public partial class AgregarRuta : Form
    {
        public AgregarRuta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Ruta ruta = new Ruta();
            ruta.Nombre = txtNombre.Text;
            ruta.Nombre_inicioruta = txtInicio.Text;
            ruta.Nombre_finalruta = txtFinal.Text;
            ruta.LatitudInicial = double.Parse(txtLatini.Text);
            ruta.LatitudFinal = double.Parse(txtLatfin.Text);
            ruta.LongitudInicial = double.Parse(txtLongini.Text);
            ruta.LongitudFinal = double.Parse(txtLongfin.Text);


            ruta.Distancia = double.Parse(txtDistancia.Text);
            ruta.Duracion = txtDuracion.Text;
            ruta.DesnivelPositivo = int.Parse(txtDespos.Text);
            ruta.DesnivelNegativo = int.Parse(txtDesneg.Text);
            ruta.AltitudMax = int.Parse(txtAltmax.Text);
            ruta.AltitudMin = int.Parse(txtAltmin.Text);

            //Cuidado puede fallar depende de lo que se guarde en base de datos
            ruta.Clasificacion = (EnumClasificaciones)cmbClasificacion.SelectedItem;


            ruta.EstadoRuta = (cmbEstado.Text == "Aprobada") ? 1 : 0;

            ruta.TipoTerreno = (int)nudTerreno.Value;
            ruta.Indicaciones = (int)nudIndicaciones.Value;

            ruta.Temporadas = txtTemporada.Text;

            ruta.Accesibilidad = chkAccesibilidad.Checked ? 1 : 0;
            ruta.RutaFamiliar = chkFamiliar.Checked ? 1 : 0;

            ruta.RecomendacionesEquipo = txtRecomendaciones.Text;
            ruta.ZonaGeografica = txtZonageo.Text;

            //objeto ruta con parametros continuar aqui
        }

        private void btnGPX_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecciona un archivo GPX";
                ofd.Filter = "Archivos GPX (*.gpx)|*.gpx|Todos los archivos (*.*)|*.*";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = ofd.FileName;

                    string nombreArchivo = Path.GetFileName(ofd.FileName);


                    lblRutaGPX.Text = rutaArchivo; 
                }
            }
        }
    }
}
