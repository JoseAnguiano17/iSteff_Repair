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
    public partial class Clientes : UserControl
    {
        public Clientes()
        {
            InitializeComponent();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.Columns[0].Width = 30;
        }

        private void Clientes_SizeChanged(object sender, EventArgs e)
        {
            //dgvClientes.Height = (int)(this.Height * .9);
            //dgvClientes.Width = (int)(this.Width * .7);
            //pnlFiltros.Height = (int)(this.Height * .8);
        }

        private void TxtFiltroID_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
