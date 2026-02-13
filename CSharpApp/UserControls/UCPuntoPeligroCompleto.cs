using Model;

namespace UserControls
{
    public partial class UCPuntoPeligroCompleto : UserControl
    {
        // Representa el punto de peligro asociado al user control
        public PuntoPeligro PuntoPeligro { get; set; }

        public UCPuntoPeligroCompleto()
        {
            InitializeComponent();
        }

        // Carga en el user control los datos del punto de peligro dado como parámetro
        public void SetData(PuntoPeligro pp)
        {
            PuntoPeligro = pp;
            double km = pp.Kilometros ?? 0;
            double tmstmp = pp.Timestamp ?? 0;

            lbltxtRuta.Text = pp.RutaId.ToString();
            lbltxtPosicion.Text = pp.Posicion.ToString();
            lbltxtNombre.Text = pp.Nombre;
            lbltxtLatitud.Text = pp.Latitud.ToString("F4");
            lbltxtLon.Text = pp.Longitud.ToString("F4");
            lbltxtElevacion.Text = pp.Elevacion.ToString("F2");
            lbltxtKilometro.Text = km.ToString("F2");
            lbltxtGravedad.Text = pp.Gravedad.ToString();
            lbltxtTimestamp.Text = tmstmp.ToString("F2");
            lbltxtDescripcion.Text = pp.Descripcion;

        }
    }
}
