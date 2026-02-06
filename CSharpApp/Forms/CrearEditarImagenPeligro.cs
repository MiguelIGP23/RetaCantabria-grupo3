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
    public partial class CrearEditarImagenPeligro : Form
    {
        public CrearEditarImagenPeligro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecciona una imágen";
                ofd.Filter = "Todos los archivos (*.*)|*.*";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = ofd.FileName;

                    string nombreArchivo = Path.GetFileName(ofd.FileName);


                    lblUrlImagen.Text = rutaArchivo;
                }
            }
        }
    }
}
