namespace iS_Repair.Forms
{
    partial class ServerManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnAjustar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnContenido = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtContrasena = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblContrasena = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblUsuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblBd = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtServer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblServer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnAjustar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).BeginInit();
            this.pnContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAjustar
            // 
            this.pnAjustar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.pnAjustar.Controls.Add(this.btnQuit);
            this.pnAjustar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAjustar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnAjustar.Location = new System.Drawing.Point(0, 0);
            this.pnAjustar.Name = "pnAjustar";
            this.pnAjustar.Size = new System.Drawing.Size(387, 29);
            this.pnAjustar.TabIndex = 10;
            this.pnAjustar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnAjustar_MouseMove);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnQuit.Image = global::iS_Repair.Properties.Resources.remove;
            this.btnQuit.ImageActive = null;
            this.btnQuit.Location = new System.Drawing.Point(359, 5);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(28, 21);
            this.btnQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnQuit.TabIndex = 8;
            this.btnQuit.TabStop = false;
            this.btnQuit.Zoom = 10;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnContenido
            // 
            this.pnContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContenido.Controls.Add(this.btnActualizar);
            this.pnContenido.Controls.Add(this.txtContrasena);
            this.pnContenido.Controls.Add(this.lblContrasena);
            this.pnContenido.Controls.Add(this.txtUsuario);
            this.pnContenido.Controls.Add(this.lblUsuario);
            this.pnContenido.Controls.Add(this.txtDB);
            this.pnContenido.Controls.Add(this.lblBd);
            this.pnContenido.Controls.Add(this.txtServer);
            this.pnContenido.Controls.Add(this.lblServer);
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenido.Location = new System.Drawing.Point(0, 29);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(387, 511);
            this.pnContenido.TabIndex = 11;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(126, 461);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(127, 37);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContrasena.HintForeColor = System.Drawing.Color.DimGray;
            this.txtContrasena.HintText = "";
            this.txtContrasena.isPassword = true;
            this.txtContrasena.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(192)))), ((int)(((byte)(95)))));
            this.txtContrasena.LineIdleColor = System.Drawing.Color.Gray;
            this.txtContrasena.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(192)))), ((int)(((byte)(95)))));
            this.txtContrasena.LineThickness = 3;
            this.txtContrasena.Location = new System.Drawing.Point(29, 387);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(6);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(317, 53);
            this.txtContrasena.TabIndex = 6;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(109, 341);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(161, 40);
            this.lblContrasena.TabIndex = 7;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(192)))), ((int)(((byte)(95)))));
            this.txtUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(192)))), ((int)(((byte)(95)))));
            this.txtUsuario.LineThickness = 3;
            this.txtUsuario.Location = new System.Drawing.Point(29, 282);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(317, 53);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(127, 236);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(114, 40);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtDB
            // 
            this.txtDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDB.HintForeColor = System.Drawing.Color.Empty;
            this.txtDB.HintText = "";
            this.txtDB.isPassword = false;
            this.txtDB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(192)))), ((int)(((byte)(95)))));
            this.txtDB.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(192)))), ((int)(((byte)(95)))));
            this.txtDB.LineThickness = 3;
            this.txtDB.Location = new System.Drawing.Point(29, 177);
            this.txtDB.Margin = new System.Windows.Forms.Padding(6);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(317, 53);
            this.txtDB.TabIndex = 2;
            this.txtDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBd
            // 
            this.lblBd.AutoSize = true;
            this.lblBd.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBd.Location = new System.Drawing.Point(85, 131);
            this.lblBd.Name = "lblBd";
            this.lblBd.Size = new System.Drawing.Size(195, 40);
            this.lblBd.TabIndex = 3;
            this.lblBd.Text = "Base de datos";
            // 
            // txtServer
            // 
            this.txtServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServer.HintForeColor = System.Drawing.Color.Empty;
            this.txtServer.HintText = "";
            this.txtServer.isPassword = false;
            this.txtServer.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(192)))), ((int)(((byte)(95)))));
            this.txtServer.LineIdleColor = System.Drawing.Color.Gray;
            this.txtServer.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(192)))), ((int)(((byte)(95)))));
            this.txtServer.LineThickness = 3;
            this.txtServer.Location = new System.Drawing.Point(29, 72);
            this.txtServer.Margin = new System.Windows.Forms.Padding(6);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(317, 53);
            this.txtServer.TabIndex = 1;
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(127, 26);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(122, 40);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Servidor";
            // 
            // ServerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 540);
            this.Controls.Add(this.pnContenido);
            this.Controls.Add(this.pnAjustar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerManager";
            this.Deactivate += new System.EventHandler(this.ServerManager_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerManager_FormClosed);
            this.pnAjustar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).EndInit();
            this.pnContenido.ResumeLayout(false);
            this.pnContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnAjustar;
        private Bunifu.Framework.UI.BunifuImageButton btnQuit;
        private System.Windows.Forms.Panel pnContenido;
        private Bunifu.Framework.UI.BunifuCustomLabel lblServer;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtServer;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContrasena;
        private Bunifu.Framework.UI.BunifuCustomLabel lblContrasena;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDB;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBd;
        private System.Windows.Forms.Button btnActualizar;
    }
}