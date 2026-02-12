using Model;
using Repository;
using System.Threading.Tasks;

namespace Forms
{
    public partial class CrearEditarCalendario : Form
    {

        private readonly ApiReta _api;
        private Calendario _calendario;
        public Calendario Calendario { get; private set; }

        public CrearEditarCalendario(ApiReta api, Calendario calendario)
        {
            InitializeComponent();
            _api = api;
            _calendario = calendario;

            dtpHora.Format = DateTimePickerFormat.Custom;
            dtpHora.CustomFormat = "HH : mm";
            dtpHora.ShowUpDown = true;
        }

        private async void CrearEditarCalendario_Load(object sender, EventArgs e)
        {
            var rutas = await CargarRutasComboBox();
            cbRutas.DataSource = rutas;
            cbRutas.DisplayMember = "Nombre";
            cbRutas.ValueMember = "Id";

            if (_calendario == null)
            {
                dtpHora.Value = DateTime.Today;
                cbRutas.SelectedItem = rutas.First();
                tbInformacion.Text = "";
            }
            else
            {
                CargarDatos(_calendario);
            }

        }

        private async Task<List<Ruta>> CargarRutasComboBox()
        {
            return await _api.GetAlAsync<Ruta>("api/reta3/rutas/validadas");
        }


        public void CargarDatos(Calendario calendario)
        {
            try
            {
                mcCalendario.SetDate(calendario.Fecha.ToDateTime(TimeOnly.MinValue));
                dtpHora.Value = DateTime.Today.Add(calendario.HoraInicio);
                cbRutas.SelectedValue = calendario.RutaId;
                tbInformacion.Text = calendario.Info;
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Calendario calendario = _calendario ?? new Calendario();

            DateTime fecha = mcCalendario.SelectionStart.Date;
            TimeSpan hora = dtpHora.Value.TimeOfDay;

            calendario.Fecha = DateOnly.FromDateTime(fecha);
            calendario.HoraInicio = hora;
            calendario.Info = tbInformacion.Text;


            try
            {
                if (_calendario == null)
                {
                    //crear
                    int idUSuario = (int)Session.IdUsuario;
                    int idRuta = (int)cbRutas.SelectedValue;

                    calendario.UsuarioId = idUSuario;
                    calendario.RutaId = idRuta;

                    await _api.Create<Calendario>($"/api/reta3/calendario/{idUSuario}/{idRuta}", calendario);
                    MessageBox.Show("Ruta guardada en el calendario");
                }
                else
                {
                    //editar
                    await _api.Update<Calendario>("api/reta3/calendario", calendario.Id.ToString() ,calendario);
                    MessageBox.Show("Modificación correcta.");

                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
                return;
            }
            Calendario = calendario;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
