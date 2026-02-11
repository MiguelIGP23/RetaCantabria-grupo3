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
using UserControls;

namespace UserControls
{
    public partial class UCCalendarioLista : UserControl
    {

        // Representa el calendario (ruta+dia) asociado al user control

        public Calendario Calendario { get; set; }

        public UCCalendarioLista()
        {
            InitializeComponent();
        }

        // Carga en el user control los datos del calendario dado como parámetro

        public void SetData(Calendario calendario, Ruta ruta)
        {
            Calendario = calendario;
            lblTxtFecha.Text = calendario.Fecha.ToString();
            lblTxtHora.Text = calendario.HoraInicio.ToString();
            lblTxtRuta.Text = ruta.Nombre;
            BackColor = Color.SkyBlue;

        }



        // Evento que se dispara al hacer click en el usr control o sus componentes
        public event EventHandler<Calendario> CalendarClick;

        private void lblFecha_Click(object sender, EventArgs e)
        {
            CalendarClick?.Invoke(this, Calendario);
        }

        private void lblTxtFecha_Click(object sender, EventArgs e)
        {
            CalendarClick?.Invoke(this, Calendario);
        }

        private void lblHora_Click(object sender, EventArgs e)
        {
            CalendarClick?.Invoke(this, Calendario);
        }

        private void lblTxtHora_Click(object sender, EventArgs e)
        {
            CalendarClick?.Invoke(this, Calendario);
        }

        private void lblRuta_Click(object sender, EventArgs e)
        {
            CalendarClick?.Invoke(this, Calendario);
        }

        private void lblTxtRuta_Click(object sender, EventArgs e)
        {
            CalendarClick?.Invoke(this, Calendario);
        }

        private void UCCalendarioLista_Click(object sender, EventArgs e)
        {
            CalendarClick?.Invoke(this, Calendario);
        }
    }
}



