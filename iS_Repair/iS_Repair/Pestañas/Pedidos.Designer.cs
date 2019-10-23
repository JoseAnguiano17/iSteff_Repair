namespace iS_Repair.Pestañas
{
    partial class Pedidos
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.dgvPedidos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnContIzq = new System.Windows.Forms.Panel();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCosto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPieza = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnDownTopPanel = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.pnContIzq.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownTopPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeColumns = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.ColumnHeadersHeight = 30;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Pieza,
            this.Costo,
            this.Pedido,
            this.FechaP,
            this.FechaR,
            this.IDCliente,
            this.Usuario});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.DoubleBuffered = true;
            this.dgvPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvPedidos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.dgvPedidos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPedidos.Location = new System.Drawing.Point(297, 62);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPedidos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedidos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPedidos.RowTemplate.Height = 30;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(998, 701);
            this.dgvPedidos.TabIndex = 18;
            // 
            // pnContIzq
            // 
            this.pnContIzq.BackColor = System.Drawing.Color.White;
            this.pnContIzq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContIzq.Controls.Add(this.cboClientes);
            this.pnContIzq.Controls.Add(this.bunifuCustomLabel1);
            this.pnContIzq.Controls.Add(this.btnRegistrar);
            this.pnContIzq.Controls.Add(this.bunifuCustomLabel4);
            this.pnContIzq.Controls.Add(this.bunifuCustomLabel3);
            this.pnContIzq.Controls.Add(this.txtCosto);
            this.pnContIzq.Controls.Add(this.bunifuCustomLabel2);
            this.pnContIzq.Controls.Add(this.txtPieza);
            this.pnContIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContIzq.Location = new System.Drawing.Point(0, 62);
            this.pnContIzq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnContIzq.Name = "pnContIzq";
            this.pnContIzq.Size = new System.Drawing.Size(297, 701);
            this.pnContIzq.TabIndex = 19;
            // 
            // cboClientes
            // 
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.ItemHeight = 22;
            this.cboClientes.Location = new System.Drawing.Point(41, 111);
            this.cboClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(213, 30);
            this.cboClientes.TabIndex = 27;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(108, 84);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(80, 23);
            this.bunifuCustomLabel1.TabIndex = 26;
            this.bunifuCustomLabel1.Text = "Cliente";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ActiveBorderThickness = 1;
            this.btnRegistrar.ActiveCornerRadius = 20;
            this.btnRegistrar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnRegistrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegistrar.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.ButtonText = "Registrar";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.IdleBorderThickness = 1;
            this.btnRegistrar.IdleCornerRadius = 20;
            this.btnRegistrar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(219)))));
            this.btnRegistrar.IdleForecolor = System.Drawing.Color.White;
            this.btnRegistrar.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Location = new System.Drawing.Point(67, 362);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(165, 47);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(81, 34);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(128, 28);
            this.bunifuCustomLabel4.TabIndex = 21;
            this.bunifuCustomLabel4.Text = "ID: 000001";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(116, 251);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(67, 23);
            this.bunifuCustomLabel3.TabIndex = 20;
            this.bunifuCustomLabel3.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCosto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.ForeColor = System.Drawing.Color.Black;
            this.txtCosto.HintForeColor = System.Drawing.Color.Black;
            this.txtCosto.HintText = "";
            this.txtCosto.isPassword = false;
            this.txtCosto.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.txtCosto.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(219)))));
            this.txtCosto.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.txtCosto.LineThickness = 4;
            this.txtCosto.Location = new System.Drawing.Point(41, 276);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(216, 47);
            this.txtCosto.TabIndex = 19;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(116, 166);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(61, 23);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "Pieza";
            // 
            // txtPieza
            // 
            this.txtPieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPieza.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPieza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPieza.ForeColor = System.Drawing.Color.Black;
            this.txtPieza.HintForeColor = System.Drawing.Color.Black;
            this.txtPieza.HintText = "";
            this.txtPieza.isPassword = false;
            this.txtPieza.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.txtPieza.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(219)))));
            this.txtPieza.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.txtPieza.LineThickness = 4;
            this.txtPieza.Location = new System.Drawing.Point(41, 196);
            this.txtPieza.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPieza.Name = "txtPieza";
            this.txtPieza.Size = new System.Drawing.Size(216, 49);
            this.txtPieza.TabIndex = 17;
            this.txtPieza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.White;
            this.pnTop.Controls.Add(this.btnDownTopPanel);
            this.pnTop.Controls.Add(this.bunifuCustomLabel5);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1295, 62);
            this.pnTop.TabIndex = 20;
            // 
            // btnDownTopPanel
            // 
            this.btnDownTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnDownTopPanel.Image = global::iS_Repair.Properties.Resources.box;
            this.btnDownTopPanel.ImageActive = null;
            this.btnDownTopPanel.Location = new System.Drawing.Point(29, 12);
            this.btnDownTopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDownTopPanel.Name = "btnDownTopPanel";
            this.btnDownTopPanel.Size = new System.Drawing.Size(45, 41);
            this.btnDownTopPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDownTopPanel.TabIndex = 14;
            this.btnDownTopPanel.TabStop = false;
            this.btnDownTopPanel.Zoom = 10;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(81, 12);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(111, 37);
            this.bunifuCustomLabel5.TabIndex = 15;
            this.bunifuCustomLabel5.Text = "Pedidos";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Pieza
            // 
            this.Pieza.HeaderText = "Pieza";
            this.Pieza.MinimumWidth = 6;
            this.Pieza.Name = "Pieza";
            this.Pieza.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Pedido
            // 
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.MinimumWidth = 6;
            this.Pedido.Name = "Pedido";
            this.Pedido.ReadOnly = true;
            // 
            // FechaP
            // 
            this.FechaP.HeaderText = "Fecha Pedido";
            this.FechaP.MinimumWidth = 6;
            this.FechaP.Name = "FechaP";
            this.FechaP.ReadOnly = true;
            // 
            // FechaR
            // 
            this.FechaR.HeaderText = "Fecha Registro";
            this.FechaR.MinimumWidth = 6;
            this.FechaR.Name = "FechaR";
            this.FechaR.ReadOnly = true;
            // 
            // IDCliente
            // 
            this.IDCliente.HeaderText = "ID Cliente";
            this.IDCliente.MinimumWidth = 6;
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.pnContIzq);
            this.Controls.Add(this.pnTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pedidos";
            this.Size = new System.Drawing.Size(1295, 763);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.pnContIzq.ResumeLayout(false);
            this.pnContIzq.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownTopPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvPedidos;
        private System.Windows.Forms.Panel pnContIzq;
        private System.Windows.Forms.Panel pnTop;
        private Bunifu.Framework.UI.BunifuImageButton btnDownTopPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCosto;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPieza;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaR;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}
