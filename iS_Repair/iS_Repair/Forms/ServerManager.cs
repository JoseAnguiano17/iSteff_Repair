using iS_Repair.Clases.DataBase;
using iS_Repair.Clases.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iS_Repair.Forms
{
    public partial class ServerManager : Form
    {
        int xClick = 0, yClick = 0;

        private void pnAjustar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            {
                this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick);
                if (Top < 0)
                    Top = 0;
                if (Top > this.Height - 35)
                    Top = this.Height - 35;
                if (Left < 0 - this.Width + 50)
                    Left = 0 - this.Width + 50;
                if (Left > Screen.PrimaryScreen.WorkingArea.Width - 40)
                    Left = Screen.PrimaryScreen.WorkingArea.Width - 40;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void ServerManager_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ServerManager_Deactivate(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
