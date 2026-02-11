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



    public partial class UCCalendarioCompleto : UserControl
    {

        public Calendario Calendario { get; set; }

        public UCCalendarioCompleto()
        {
            InitializeComponent();
        }



        // Evento que se dispara al dar click al boton volver
        public event EventHandler VolverClick;

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VolverClick?.Invoke(this, EventArgs.Empty);
        }


        // Evento que se dispara al dar en boton ver ruta
        public event EventHandler<Calendario> VerRutaClick;
        private void btnRuta_Click(object sender, EventArgs e)
        {
            VerRutaClick?.Invoke(this, Calendario);
        }


        public async void SetData(Calendario calendario, Usuario usuario, Ruta ruta)
        {
            Calendario = calendario;
            lbltxtRutaId.Text = calendario.RutaId.ToString();
            lbltxtNombreRuta.Text = ruta.Nombre.ToString();
            string fecha = calendario.Fecha.ToString("dd-MM-yyyy");
            lbltxtFecha.Text = fecha; ;
            lbltxtHora.Text = calendario.HoraInicio.ToString();
            lbltxtUsuario.Text = usuario.Nombre.ToString();
            lbltxtInformacion.Text = calendario.Info.ToString();
        }


        //Evento que se dispara al dar click en editar
        public event EventHandler<Calendario> EditarClick;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarClick?.Invoke(this, Calendario);
        }
    }
}
