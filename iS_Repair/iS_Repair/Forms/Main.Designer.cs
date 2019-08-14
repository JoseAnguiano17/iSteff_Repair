namespace iS_Repair
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.pnContenido = new System.Windows.Forms.Panel();
            this.pnBajo = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnAjustar = new System.Windows.Forms.FlowLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnClientes = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTelefonos = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPendientes = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPedidos = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnQuit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDBCon = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdmin = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnPrincipal.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnAjustar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDBCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.pnContenido);
            this.pnPrincipal.Controls.Add(this.pnBajo);
            this.pnPrincipal.Controls.Add(this.pnMenu);
            this.pnPrincipal.Controls.Add(this.pnAjustar);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(971, 640);
            this.pnPrincipal.TabIndex = 0;
            // 
            // pnContenido
            // 
            this.pnContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenido.Location = new System.Drawing.Point(0, 113);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(971, 502);
            this.pnContenido.TabIndex = 1;
            // 
            // pnBajo
            // 
            this.pnBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.pnBajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBajo.Location = new System.Drawing.Point(0, 615);
            this.pnBajo.Name = "pnBajo";
            this.pnBajo.Size = new System.Drawing.Size(971, 25);
            this.pnBajo.TabIndex = 2;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.pnMenu.Controls.Add(this.pbLogo);
            this.pnMenu.Controls.Add(this.btnClientes);
            this.pnMenu.Controls.Add(this.btnTelefonos);
            this.pnMenu.Controls.Add(this.btnPendientes);
            this.pnMenu.Controls.Add(this.btnPedidos);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 29);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(971, 84);
            this.pnMenu.TabIndex = 3;
            // 
            // pnAjustar
            // 
            this.pnAjustar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.pnAjustar.Controls.Add(this.btnQuit);
            this.pnAjustar.Controls.Add(this.btnMaximize);
            this.pnAjustar.Controls.Add(this.btnMinimize);
            this.pnAjustar.Controls.Add(this.btnDBCon);
            this.pnAjustar.Controls.Add(this.btnAdmin);
            this.pnAjustar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAjustar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnAjustar.Location = new System.Drawing.Point(0, 0);
            this.pnAjustar.Name = "pnAjustar";
            this.pnAjustar.Size = new System.Drawing.Size(971, 29);
            this.pnAjustar.TabIndex = 9;
            this.pnAjustar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnAjustar_MouseDoubleClick);
            this.pnAjustar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::iS_Repair.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(10, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(247, 79);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnClientes.Image = global::iS_Repair.Properties.Resources.clients;
            this.btnClientes.ImageActive = null;
            this.btnClientes.InitialImage = null;
            this.btnClientes.Location = new System.Drawing.Point(267, 5);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(71, 69);
            this.btnClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClientes.TabIndex = 5;
            this.btnClientes.TabStop = false;
            this.btnClientes.Zoom = 10;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnTelefonos
            // 
            this.btnTelefonos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnTelefonos.Image = global::iS_Repair.Properties.Resources.telephones;
            this.btnTelefonos.ImageActive = null;
            this.btnTelefonos.InitialImage = null;
            this.btnTelefonos.Location = new System.Drawing.Point(348, 5);
            this.btnTelefonos.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.btnTelefonos.Name = "btnTelefonos";
            this.btnTelefonos.Size = new System.Drawing.Size(71, 69);
            this.btnTelefonos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTelefonos.TabIndex = 6;
            this.btnTelefonos.TabStop = false;
            this.btnTelefonos.Zoom = 10;
            this.btnTelefonos.Click += new System.EventHandler(this.btnTelefonos_Click);
            // 
            // btnPendientes
            // 
            this.btnPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnPendientes.Image = global::iS_Repair.Properties.Resources.pending;
            this.btnPendientes.ImageActive = null;
            this.btnPendientes.InitialImage = null;
            this.btnPendientes.Location = new System.Drawing.Point(429, 5);
            this.btnPendientes.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.Size = new System.Drawing.Size(71, 69);
            this.btnPendientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPendientes.TabIndex = 7;
            this.btnPendientes.TabStop = false;
            this.btnPendientes.Zoom = 10;
            this.btnPendientes.Click += new System.EventHandler(this.btnPendientes_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnPedidos.Image = global::iS_Repair.Properties.Resources.box;
            this.btnPedidos.ImageActive = null;
            this.btnPedidos.InitialImage = null;
            this.btnPedidos.Location = new System.Drawing.Point(510, 5);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(71, 69);
            this.btnPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPedidos.TabIndex = 9;
            this.btnPedidos.TabStop = false;
            this.btnPedidos.Zoom = 10;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnQuit.Image = global::iS_Repair.Properties.Resources.remove;
            this.btnQuit.ImageActive = null;
            this.btnQuit.Location = new System.Drawing.Point(943, 5);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(28, 21);
            this.btnQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnQuit.TabIndex = 8;
            this.btnQuit.TabStop = false;
            this.btnQuit.Zoom = 10;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnMaximize.Image = global::iS_Repair.Properties.Resources.maximize;
            this.btnMaximize.ImageActive = null;
            this.btnMaximize.Location = new System.Drawing.Point(915, 5);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 21);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 9;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Zoom = 10;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnMinimize.Image = global::iS_Repair.Properties.Resources.minus;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(887, 5);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 21);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnDBCon
            // 
            this.btnDBCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnDBCon.Image = global::iS_Repair.Properties.Resources.database_error;
            this.btnDBCon.ImageActive = null;
            this.btnDBCon.Location = new System.Drawing.Point(853, 5);
            this.btnDBCon.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDBCon.Name = "btnDBCon";
            this.btnDBCon.Size = new System.Drawing.Size(34, 21);
            this.btnDBCon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDBCon.TabIndex = 11;
            this.btnDBCon.TabStop = false;
            this.btnDBCon.Zoom = 10;
            this.btnDBCon.Click += new System.EventHandler(this.btnDBCon_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnAdmin.Image = global::iS_Repair.Properties.Resources.admin;
            this.btnAdmin.ImageActive = null;
            this.btnAdmin.Location = new System.Drawing.Point(819, 5);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(34, 21);
            this.btnAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdmin.TabIndex = 12;
            this.btnAdmin.TabStop = false;
            this.btnAdmin.Zoom = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 640);
            this.Controls.Add(this.pnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                    ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.pnPrincipal.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnAjustar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDBCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Panel pnContenido;
        private System.Windows.Forms.Panel pnBajo;
        private System.Windows.Forms.FlowLayoutPanel pnMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnClientes;
        private Bunifu.Framework.UI.BunifuImageButton btnTelefonos;
        private Bunifu.Framework.UI.BunifuImageButton btnPendientes;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.FlowLayoutPanel pnAjustar;
        private Bunifu.Framework.UI.BunifuImageButton btnQuit;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnPedidos;
        private Bunifu.Framework.UI.BunifuImageButton btnDBCon;
        private Bunifu.Framework.UI.BunifuImageButton btnAdmin;
    }
}

