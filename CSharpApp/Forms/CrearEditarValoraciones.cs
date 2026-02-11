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

namespace Forms
{
    public partial class CrearEditarValoraciones : Form
    {
        private readonly ApiReta _api;
        private Valoracion _valoracion { get; set; }


        public CrearEditarValoraciones(ApiReta api, Valoracion valoracion)
        {
            InitializeComponent();
            _api = api;
            _valoracion = valoracion;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
