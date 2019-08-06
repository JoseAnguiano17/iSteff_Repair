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
        MainForm origen;
        DataHost dh;
        Archivo<DataHost> archivo;
        int xClick = 0, yClick = 0;

        public ServerManager(ref Archivo<DataHost> archivo, ref DataHost dh,MainForm origen)
        {
            InitializeComponent();
            if(dh!= null)
            {
                txtServer.Text = dh.Server;
                txtDB.Text = dh.Database;
                txtUsuario.Text = dh.UID;
            }
            this.origen = origen;
            this.dh = dh;
            this.archivo = archivo;
        }

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
            // Modificar si ya existen datos del servidor.
            if (dh != null)
            {
                //Si son los mismos datos se cierra.
                if(dh.Server == txtServer.Text && dh.UID == txtUsuario.Text && dh.Database == txtDB.Text && txtContrasena.Text == "")
                {
                    this.Deactivate -= ServerManager_Deactivate;
                    MessageUtil.Warning("No hay ningun cambio por guardar.");
                    Close();
                    return;
                }
            }
            // Agregar datos de un servidor o modificar los que cambiaron.
            DataHost newDataHost = new DataHost(txtServer.Text,
                                                txtDB.Text,
                                                txtUsuario.Text,
                                                txtContrasena.Text);
            dh = newDataHost;
            archivo.EliminarAchivo();
            archivo.GrabarObjeto(newDataHost);
            this.Deactivate -= ServerManager_Deactivate;
            MessageUtil.Information("Se actualizaron los datos del servidor\n ¡Correctamente!");
            Close();
            return;
        }

        private void ServerManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            origen.ConectarDB(dh);
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
