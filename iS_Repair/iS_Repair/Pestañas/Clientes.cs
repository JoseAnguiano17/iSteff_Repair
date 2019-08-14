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
                cardDatosCLiente.Location = new Point(pnTop.Width / 3, cardDatosCLiente.Location.Y); 
            } else{

                cardDatosCLiente.Location = new Point((int)(pnTop.Width / 3.5), cardDatosCLiente.Location.Y);
            }
            sepDivisor.Width = (int)(pnContenido.Width * .96);
        }

        private void btnDownTopPanel_Click(object sender, EventArgs e)
        {
            if(pnTop.Height <= 50)
            {
                pnTop.Height = cardDatosCLiente.Height + sepDivisor.Height + 60;
            }
            else
            {
                pnTop.Height = 50;
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            pbBuscar.Visible = false;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            pbBuscar.Visible = true;
        }
    }
}
