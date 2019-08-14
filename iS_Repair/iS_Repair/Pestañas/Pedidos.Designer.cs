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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.dgvClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnContIzq = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnDownTopPanel = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCosto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPieza = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnContIzq.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownTopPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvClientes.ColumnHeadersHeight = 30;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Pieza,
            this.Costo,
            this.Pedido});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.DoubleBuffered = true;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvClientes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.dgvClientes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvClientes.Location = new System.Drawing.Point(223, 50);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 60;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvClientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientes.RowTemplate.Height = 30;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(748, 570);
            this.dgvClientes.TabIndex = 18;
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
            this.pnContIzq.Location = new System.Drawing.Point(0, 50);
            this.pnContIzq.Name = "pnContIzq";
            this.pnContIzq.Size = new System.Drawing.Size(223, 570);
            this.pnContIzq.TabIndex = 19;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.White;
            this.pnTop.Controls.Add(this.btnDownTopPanel);
            this.pnTop.Controls.Add(this.bunifuCustomLabel5);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(971, 50);
            this.pnTop.TabIndex = 20;
            // 
            // btnDownTopPanel
            // 
            this.btnDownTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnDownTopPanel.Image = global::iS_Repair.Properties.Resources.box;
            this.btnDownTopPanel.ImageActive = null;
            this.btnDownTopPanel.Location = new System.Drawing.Point(22, 10);
            this.btnDownTopPanel.Name = "btnDownTopPanel";
            this.btnDownTopPanel.Size = new System.Drawing.Size(34, 33);
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
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(61, 10);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(85, 30);
            this.bunifuCustomLabel5.TabIndex = 15;
            this.bunifuCustomLabel5.Text = "Pedidos";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Pieza
            // 
            this.Pieza.HeaderText = "Pieza";
            this.Pieza.Name = "Pieza";
            this.Pieza.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Pedido
            // 
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.ReadOnly = true;
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
            this.btnRegistrar.Location = new System.Drawing.Point(50, 294);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 38);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(61, 28);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(104, 23);
            this.bunifuCustomLabel4.TabIndex = 21;
            this.bunifuCustomLabel4.Text = "ID: 000001";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(87, 204);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(51, 19);
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
            this.txtCosto.Location = new System.Drawing.Point(31, 224);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(162, 38);
            this.txtCosto.TabIndex = 19;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(87, 135);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(50, 19);
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
            this.txtPieza.Location = new System.Drawing.Point(31, 159);
            this.txtPieza.Margin = new System.Windows.Forms.Padding(5);
            this.txtPieza.Name = "txtPieza";
            this.txtPieza.Size = new System.Drawing.Size(162, 40);
            this.txtPieza.TabIndex = 17;
            this.txtPieza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(81, 68);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 19);
            this.bunifuCustomLabel1.TabIndex = 26;
            this.bunifuCustomLabel1.Text = "Cliente";
            // 
            // cboClientes
            // 
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.ItemHeight = 20;
            this.cboClientes.Location = new System.Drawing.Point(31, 90);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(161, 28);
            this.cboClientes.TabIndex = 27;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pnContIzq);
            this.Controls.Add(this.pnTop);
            this.Name = "Pedidos";
            this.Size = new System.Drawing.Size(971, 620);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnContIzq.ResumeLayout(false);
            this.pnContIzq.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownTopPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvClientes;
        private System.Windows.Forms.Panel pnContIzq;
        private System.Windows.Forms.Panel pnTop;
        private Bunifu.Framework.UI.BunifuImageButton btnDownTopPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCosto;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPieza;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cboClientes;
    }
}
