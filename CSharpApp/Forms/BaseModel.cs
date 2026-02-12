using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetaEquipo3
{
    public abstract class BaseForm : Form
    {
        public BaseForm()
        {
            this.BackColor = Color.DarkSlateGray;
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10);
            this.DoubleBuffered = true;     //Evita parpadeos
        }
    }
}
