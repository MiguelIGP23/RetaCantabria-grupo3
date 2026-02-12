using Model;
using Repository;
using RetaEquipo3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class CrearEditarValoraciones : BaseForm
    {
        private readonly ApiReta _api;
        private Valoracion _valoracion { get; set; }
        public Valoracion Valoracion { get; private set; }

        private Ruta _ruta { get; set; }

        public CrearEditarValoraciones(ApiReta api, Ruta ruta, Valoracion valoracion)
        {
            InitializeComponent();
            _api = api;
            _ruta = ruta;
            _valoracion = valoracion;

            if(Session.Rol != EnumRoles.ADMINISTRADOR)
            {
                mCalendario.Enabled = false;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //aqui poner validaciones de campos rellenos


            Valoracion valoracion = _valoracion ?? new Valoracion();

            DateTime fecha = mCalendario.SelectionStart.Date;

            valoracion.Fecha = DateOnly.FromDateTime(fecha);
            valoracion.Dificultad = (byte)nud_Dificultad.Value;
            valoracion.Estrellas = (byte)nud_Estrellas.Value;
            valoracion.InteresCultural =(byte)nudInteres.Value;
            valoracion.Belleza=(byte)nudBelleza.Value;
            valoracion.ValoracionTecnica = tbValoracionTecnica.Text;
            valoracion.Resena = tbResena.Text;

            try
            {
                int idRuta = _ruta.Id;
                valoracion.RutaId = idRuta;
                if (_valoracion == null)
                {
                    //crear
                    int idUSuario = (int)Session.IdUsuario;
                    valoracion.UsuarioId = idUSuario;
                    await _api.Create<Valoracion>($"/api/reta3/rutas/{idRuta}/valoraciones", valoracion);
                    MessageBox.Show("Valoracion sobre ruta guardada.");
                }
                else
                {
                    //editar
                    await _api.Update<Valoracion>($"api/reta3/rutas/{_ruta.Id}/valoraciones", valoracion.IdValora.ToString(), valoracion);
                    MessageBox.Show("Valoración modificada.");
                }
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
                return;
            }
            Valoracion = valoracion;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void CargarDatos()
        {
            try
            {
                mCalendario.SetDate(_valoracion.Fecha.ToDateTime(TimeOnly.MinValue));
                nud_Dificultad.Value = _valoracion.Dificultad;
                nud_Estrellas.Value = _valoracion.Estrellas;
                nudInteres.Value = _valoracion.InteresCultural;
                nudBelleza.Value = _valoracion.Belleza;
                tbValoracionTecnica.Text = _valoracion.ValoracionTecnica;
                tbResena.Text = _valoracion.Resena;
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
                this.Close();
            }
        }

        private void CrearEditarValoraciones_Load(object sender, EventArgs e)
        {
            if (_valoracion != null)
            {
                CargarDatos();
            }
            else
            {
                mCalendario.SetDate(DateTime.Today);
                nud_Dificultad.Value = 1;
                nud_Estrellas.Value= 1;
                nudInteres.Value= 1;
                nudBelleza.Value= 1;
                tbValoracionTecnica.Text = "";
                tbResena.Text = "";
            }
        }

    }
}
