using iS_Repair.Clases.DataBase;
using iS_Repair.Clases.Utils;
using iS_Repair.Forms;
using System;
using System.Windows.Forms;

namespace iS_Repair
{
    public partial class MainForm : Form
    {
        DB myDataBase;
        Archivo<DataHost> ArchivoServer = new Archivo<DataHost>("Host.dat");
        DataHost dh = null;

        int xClick = 0, yClick = 0;

        public MainForm()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            foreach (DataHost item in ArchivoServer.LeerObjetos())
            {
                dh = item;
            }

            if (dh != null)
            {
                ConectarDB(dh);
            } else
            {
                MessageUtil.Error("No hay base de datos guardada.");
            }
        }

        public void ConectarDB(DataHost dh)
        {
            try
            {
                if (dh != null)
                {
                    this.dh = dh;
                    myDataBase = dh.getDataBase();
                    btnDBCon.Image = Properties.Resources.database_conectado;
                }
            }
            catch (Exception x)
            {
                btnDBCon.Image = Properties.Resources.database_error;
                MessageUtil.Error(x.Message);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageUtil.Confirmation("¿Desea cerrar el programa?"))
            {
                this.Close();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Image = Properties.Resources.maximize;
                WindowState = FormWindowState.Normal;
            } else
            {
                btnMaximize.Image = Properties.Resources.inside;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                WindowState = FormWindowState.Maximized;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).Bounds;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else { 
                this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick);
                if (Top < 0 )
                    Top = 0;
                if (Top > this.Height - 35)
                    Top = this.Height - 35;
                if (Left < 0 - this.Width + 50)
                    Left = 0 - this.Width + 50;
                if (Left > Screen.PrimaryScreen.WorkingArea.Width - 40)
                    Left = Screen.PrimaryScreen.WorkingArea.Width - 40;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode== (Keys.D))
            {
                new ServerManager(ref ArchivoServer,ref dh,this).Show();
            }
        }

        private void btnDBCon_Click(object sender, EventArgs e)
        {
                new ServerManager(ref ArchivoServer, ref dh, this).Show();
        }

        private void pnAjustar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnMaximize_Click(sender, e);
        }
        
    }
}
