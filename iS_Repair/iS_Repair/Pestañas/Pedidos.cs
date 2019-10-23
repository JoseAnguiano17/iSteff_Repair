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
                dgvPedidos.Rows.Add(pedido.ID, pedido.Pieza, pedido.Costo.ToString("C"), (pedido.YaPedido)? "Sí": "No", pedido.FechaPedido, pedido.FechaRegistro, pedido.IDCliente, pedido.Usuario);
            }
        }
    }
}
