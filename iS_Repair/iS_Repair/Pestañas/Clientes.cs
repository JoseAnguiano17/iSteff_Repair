using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iS_Repair.Clases;

namespace iS_Repair.Pestañas
{
    public partial class Clientes : UserControl
    {
        MainForm origen;

        public Clientes(MainForm origen)
        {
            InitializeComponent();
            this.origen = origen;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ActualizarDGV();
        }

        void ActualizarDGV()
        {
            dgvClientes.Rows.Clear();
            foreach (Cliente item in origen.DataBase.Clientes())
            {
                dgvClientes.Rows.Add(item.ID, item.Nombre, item.NumeroTelefono);
            }
        }

        private void Clientes_SizeChanged(object sender, EventArgs e)
        {
            if(MainForm.ActiveForm.WindowState == FormWindowState.Maximized)
            {
                dgvClientes.Width = (int)(pnContenido.Width * .77);
            } else{
                dgvClientes.Width = (int)(pnContenido.Width * .7);
            }
            sepDivisor.Width = (int)(pnContenido.Width * .95);
            dgvClientes.Height = (int)(pnContenido.Height * .9);
            pnlFiltros.Height = (int)(pnContenido.Height * .8);
        }

        private void TxtFiltroID_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDownTopPanel_Click(object sender, EventArgs e)
        {
            if(pnTop.Height <= 50)
            {
                pnTop.Height = cardDatosCLiente.Height + sepDivisor.Height + 50;
            }
            else
            {
                pnTop.Height = 50;
            }
        }
    }
}
