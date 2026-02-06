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

namespace Forms
{
    public partial class EditarPuntoInteres : Form
    {
        public EditarPuntoInteres()
        {
            InitializeComponent();
        }

        private void EditarPuntoInteres_Load(object sender, EventArgs e)
        {
            cbTipo.DataSource = Enum.GetValues(typeof(EnumTiposPuntoInteres));
        }
    }
}
