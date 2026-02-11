using Model;
using Repository;
using System.Data;
using System.Globalization;
using UserControls;

namespace Forms
{
    public partial class CalendarioForms : Form
    {

        private readonly ApiReta _api;
        private string? _mesActual;
        public Calendario Seleccionado;

        public CalendarioForms(ApiReta api)
        {
            InitializeComponent();
            _api = api;
        }


        private async void CalendarioForms_Load(object sender, EventArgs e)
        {
            await ResaltarDiasDelMesAsync(true);
        }




        public async void CargarDatos(List<Calendario> calendarios)
        {
            flpRutas.Controls.Clear();
            foreach (Calendario c in calendarios)
            {
                UCCalendarioLista uc = new UCCalendarioLista();
                Ruta ruta = await _api.GetByIdAsync<Ruta>("/api/reta3/rutas", c.RutaId.ToString());
                uc.SetData(c, ruta);
                uc.CalendarClick += OpcionElegiga;
                flpRutas.Controls.Add(uc);
            }
        }


        //Cargar datos de ruta elegida en user control detalles
        private async void OpcionElegiga(object? sender, Calendario opcion)
        {
            Usuario usu = await _api.GetByIdAsync<Usuario>("api/reta3/usuarios", opcion.UsuarioId.ToString());
            if (usu == null)
            {
                MessageBox.Show("No se encontro al usuario que creo la ruta", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Ruta ruta = await _api.GetByIdAsync<Ruta>("api/reta3/rutas", opcion.UsuarioId.ToString());
            if (ruta == null)
            {
                MessageBox.Show("No se encontro la ruta o no existe", "Ruta no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Seleccionado = opcion;
            flpRutas.Visible = false;
            ucDetalles.Visible = true;
            ucDetalles.SetData(opcion, usu, ruta);
            ucDetalles.VolverClick += VolverALista;
            ucDetalles.VerRutaClick += VerRuta;
            ucDetalles.EditarClick += EditarRuta;
        }


        // Abrir forms de editar calendario pasando datos del seleccionado
        private void EditarRuta(object? sender, Calendario e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new CrearEditarCalendario(_api, Seleccionado))
                {
                    form.ShowDialog(this);
                }

            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate();
            }
        }


        //abrir ventana de detalles de la ruta elegida
        private async void VerRuta(object? sender, Calendario e)
        {
            int idRuta = e.RutaId;
            Ruta ruta = await _api.GetByIdAsync<Ruta>("api/reta3/rutas", idRuta.ToString());
            if (ruta == null)
            {
                MessageBox.Show("No se encontró la ruta buscada", "Ruta no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new RutasDetalle(ruta, _api))
                {
                    form.ShowDialog(this);
                }

            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate();
            }
        }


        // Cerrar detalles y volver a lista de rutas

        private void VolverALista(object? sender, EventArgs e)
        {
            ucDetalles.Visible = false;
            flpRutas.Visible = true;
        }

        // Salir del calendario

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        // Cargar lista de rutas al seleccionar dia del calendario
        // Si se cambia de mes, tambien resalta los dias con rutas
        private async void mcCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            ResaltarDiasDelMesAsync();

            DateTime dia = mcCalendario.SelectionStart.Date;
            string fecha = dia.ToString("yyyy-MM-dd");
            var calendarios = await _api.GetAlAsync<Calendario>($"/api/reta3/calendario/fecha/{fecha}");
            int numRutas = calendarios.Count;
            lbFecha.Text = $"-Día: {dia.ToString("dd-MM-yyyy")}  nº rutas: {numRutas}";
            CargarDatos(calendarios);
        }


        // Resaltar en el calendario dias con rutas
        private async Task ResaltarDiasDelMesAsync(bool force = false)
        {
            DateTime d = mcCalendario.SelectionStart.Date;
            string ym = d.ToString("yyyy-MM"); // "2026-02"

            if (!force && ym == _mesActual) return; // mismo mes => no llamo

            _mesActual = ym;

            var fechas = await _api.GetAlAsync<string>($"api/reta3/calendario/rutasmes/{ym}");
            var dias = fechas
                .Select(f => DateTime.ParseExact(f, "yyyy-MM-dd", CultureInfo.InvariantCulture))
                .ToArray();

            mcCalendario.BoldedDates = dias;
            mcCalendario.UpdateBoldedDates();
        }

        private async void btnNueva_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                this.Opacity = 0;

                using (var form = new CrearEditarCalendario(_api, null))
                {
                    var result = form.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        await ResaltarDiasDelMesAsync();
                        DateOnly fecha = form.Calendario.Fecha;
                        mcCalendario.SetDate(fecha.ToDateTime(TimeOnly.MinValue));
                    }
                }

            }
            finally
            {
                this.Opacity = 1;
                this.Enabled = true;
                this.Activate();
            }
        }
    }
}
