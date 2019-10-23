using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iS_Repair.Pestañas
{
    public partial class Telefonos : UserControl
    {
        public Telefonos()
        {
            InitializeComponent();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            pbBuscar.Visible = false;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            pbBuscar.Visible = true;
            txtBuscar.ResetText();
        }
    }
}
