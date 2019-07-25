using iS_Repair.Clases.Utils;
using System;
using System.Windows.Forms;

namespace iS_Repair
{
    public partial class MainForm : Form
    {
        int xClick = 0, yClick = 0;

        public MainForm()
        {
            InitializeComponent();
           this.Height = Screen.PrimaryScreen.WorkingArea.Height;
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
        
        private void pnAjustar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnMaximize_Click(sender, e);
        }
        
    }
}
