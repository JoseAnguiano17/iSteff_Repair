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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btn1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnAjustar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDBCon = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnPrincipal.SuspendLayout();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.pnAjustar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDBCon)).BeginInit();
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
            this.pnPrincipal.Size = new System.Drawing.Size(971, 643);
            this.pnPrincipal.TabIndex = 0;
            // 
            // pnContenido
            // 
            this.pnContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenido.Location = new System.Drawing.Point(0, 113);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(971, 505);
            this.pnContenido.TabIndex = 1;
            // 
            // pnBajo
            // 
            this.pnBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.pnBajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBajo.Location = new System.Drawing.Point(0, 618);
            this.pnBajo.Name = "pnBajo";
            this.pnBajo.Size = new System.Drawing.Size(971, 25);
            this.pnBajo.TabIndex = 2;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.pnMenu.Controls.Add(this.pbLogo);
            this.pnMenu.Controls.Add(this.btn1);
            this.pnMenu.Controls.Add(this.btn2);
            this.pnMenu.Controls.Add(this.btn3);
            this.pnMenu.Controls.Add(this.bunifuImageButton1);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 29);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(971, 84);
            this.pnMenu.TabIndex = 3;
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
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btn1.Image = global::iS_Repair.Properties.Resources.clients;
            this.btn1.ImageActive = null;
            this.btn1.InitialImage = null;
            this.btn1.Location = new System.Drawing.Point(267, 5);
            this.btn1.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(71, 69);
            this.btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn1.TabIndex = 5;
            this.btn1.TabStop = false;
            this.btn1.Zoom = 10;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btn2.Image = global::iS_Repair.Properties.Resources.telephones;
            this.btn2.ImageActive = null;
            this.btn2.InitialImage = null;
            this.btn2.Location = new System.Drawing.Point(348, 5);
            this.btn2.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(71, 69);
            this.btn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn2.TabIndex = 6;
            this.btn2.TabStop = false;
            this.btn2.Zoom = 10;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btn3.Image = global::iS_Repair.Properties.Resources.pending;
            this.btn3.ImageActive = null;
            this.btn3.InitialImage = null;
            this.btn3.Location = new System.Drawing.Point(429, 5);
            this.btn3.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(71, 69);
            this.btn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn3.TabIndex = 7;
            this.btn3.TabStop = false;
            this.btn3.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.bunifuImageButton1.Image = global::iS_Repair.Properties.Resources.box;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(510, 5);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 69);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // pnAjustar
            // 
            this.pnAjustar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.pnAjustar.Controls.Add(this.btnQuit);
            this.pnAjustar.Controls.Add(this.btnMaximize);
            this.pnAjustar.Controls.Add(this.btnMinimize);
            this.pnAjustar.Controls.Add(this.btnDBCon);
            this.pnAjustar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAjustar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnAjustar.Location = new System.Drawing.Point(0, 0);
            this.pnAjustar.Name = "pnAjustar";
            this.pnAjustar.Size = new System.Drawing.Size(971, 29);
            this.pnAjustar.TabIndex = 9;
            this.pnAjustar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnAjustar_MouseDoubleClick);
            this.pnAjustar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 643);
            this.Controls.Add(this.pnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                    ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.pnPrincipal.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.pnAjustar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDBCon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Panel pnContenido;
        private System.Windows.Forms.Panel pnBajo;
        private System.Windows.Forms.FlowLayoutPanel pnMenu;
        private Bunifu.Framework.UI.BunifuImageButton btn1;
        private Bunifu.Framework.UI.BunifuImageButton btn2;
        private Bunifu.Framework.UI.BunifuImageButton btn3;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.FlowLayoutPanel pnAjustar;
        private Bunifu.Framework.UI.BunifuImageButton btnQuit;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnDBCon;
    }
}

