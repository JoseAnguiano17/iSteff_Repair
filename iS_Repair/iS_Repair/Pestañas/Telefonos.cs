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
    public partial class Telefonos : UserControl
    {
        public Telefonos()
        {
            InitializeComponent();
            dgvTelefonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ActualizarDGV();
        }

        private void ActualizarDGV()
        {
            dgvTelefonos.Rows.Clear();
            int i = 0;
            foreach (Telefono telf in ConexionBD.CargarTelefonos())
            {
                dgvTelefonos.Rows.Add(telf.ID, telf.Modelo, (telf.Armado) ? "Sí" : "No", (telf.Rango == 1) ? "Baja prioridad" : (telf.Rango == 2) ? "Media prioridad" : "Alta prioridad", telf.IDEstado);
                dgvTelefonos[3,i].Style.BackColor = (telf.Rango == 1) ? Color.LightSeaGreen : (telf.Rango == 2) ? Color.LightSteelBlue: Color.IndianRed;
                i++;
            }
        }
    }
}
