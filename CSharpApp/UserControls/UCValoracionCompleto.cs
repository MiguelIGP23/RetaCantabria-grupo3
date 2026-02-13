using Model;
using Repository;
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
    public partial class UCValoracionCompleto : UserControl
    {
        public Valoracion valoracion { get; set; }
        public UCValoracionCompleto()
        {
            InitializeComponent();
        }

        public async void SetData(ApiReta api, Valoracion v)
        {
            try
            {
                //Usuario usuario = await api.GetByIdAsync<Usuario>("/api/reta3/usuarios", v.UsuarioId.ToString());
                //Ruta ruta = await api.GetByIdAsync<Ruta>("/api/reta3/rutas", v.RutaId.ToString());
                valoracion = v;
                lbl_txtIdValora.Text = v.IdValora.ToString();
                lbl_txtUsuario.Text = v.UsuarioId.ToString();
                lbl_txtRuta.Text = v.RutaId.ToString();
                lbl_txtDificultad.Text = v.Dificultad.ToString();
                lbl_txtFecha.Text = v.Fecha.ToString();
                lbl_txtEstrellas.Text = v.Estrellas.ToString();
                lbl_txtInteresCultural.Text = v.InteresCultural.ToString();
                lbl_txtBelleza.Text = v.Belleza.ToString();
                lbl_txtValoracionTecnica.Text = v.ValoracionTecnica;
                lbl_txtResena.Text = v.Resena;
            }
            catch (HttpRequestException ex)
            {
                ApiReta.MostrarErrorHttp(ex);
            }
        }
    }
}
