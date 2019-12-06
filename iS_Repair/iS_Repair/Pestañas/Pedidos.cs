using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iS_Repair.Clases.ClasesTablas;
using iS_Repair.Clases.DataBase;
using System.Data.SqlClient;
using iS_Repair.Clases.Utils;

namespace iS_Repair.Pestañas
{
    public partial class Pedidos : UserControl
    {
        public Pedidos()
        {
            InitializeComponent();
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ActualizarDGV();
        }

        void ActualizarDGV()
        {
            dgvPedidos.Rows.Clear();
            foreach (Pedido pedido in ConexionBD.CargarPedidos())
            {
                dgvPedidos.Rows.Add(pedido.ID, pedido.Pieza, pedido.Costo.ToString("C"), (pedido.FechaPedido==DateTime.MinValue)? "N/A": pedido.FechaPedido.ToString(),(pedido.YaPedido) ? "Sí" : "No");
            }
        }

        private void dgvPedidos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvPedidos[e.ColumnIndex, e.RowIndex].Selected = true;
                cmsPedido.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void marcarComoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageUtil.Confirmation("Se marcara la pieza como pedida.\n         ¿Desea continuar?"))
                {
                    ConexionBD.MarcarComoPedido((int.Parse(dgvPedidos.SelectedRows[0].Cells[0].Value.ToString())));
                    ActualizarDGV();
                }
            }
            catch (Exception ex)
            {
                MessageUtil.Error("Ocurrio un error innesperado.\n" + ex.Message);
            }
        }
    }
}
