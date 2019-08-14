namespace iS_Repair.Pestañas
{
    partial class Pendientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pendientes));
            this.dgvClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnContIzq = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnDownTopPanel = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
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
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClientes.ColumnHeadersHeight = 30;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Registrada});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.DoubleBuffered = true;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvClientes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.dgvClientes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvClientes.Location = new System.Drawing.Point(216, 50);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 60;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvClientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientes.RowTemplate.Height = 30;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(755, 570);
            this.dgvClientes.TabIndex = 5;
            // 
            // pnContIzq
            // 
            this.pnContIzq.BackColor = System.Drawing.Color.White;
            this.pnContIzq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContIzq.Controls.Add(this.txtDescripcion);
            this.pnContIzq.Controls.Add(this.bunifuCustomLabel4);
            this.pnContIzq.Controls.Add(this.btnRegistrar);
            this.pnContIzq.Controls.Add(this.bunifuCustomLabel2);
            this.pnContIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContIzq.Location = new System.Drawing.Point(0, 50);
            this.pnContIzq.Name = "pnContIzq";
            this.pnContIzq.Size = new System.Drawing.Size(216, 570);
            this.pnContIzq.TabIndex = 6;
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
            this.pnTop.TabIndex = 17;
            // 
            // btnDownTopPanel
            // 
            this.btnDownTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnDownTopPanel.Image = global::iS_Repair.Properties.Resources.pending;
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
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(114, 30);
            this.bunifuCustomLabel5.TabIndex = 15;
            this.bunifuCustomLabel5.Text = "Pendientes";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Registrada
            // 
            this.Registrada.HeaderText = "Registrada";
            this.Registrada.Name = "Registrada";
            this.Registrada.ReadOnly = true;
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
            this.btnRegistrar.Location = new System.Drawing.Point(43, 214);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 38);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(55, 58);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(100, 19);
            this.bunifuCustomLabel2.TabIndex = 19;
            this.bunifuCustomLabel2.Text = "Descripción";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(59, 30);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(93, 23);
            this.bunifuCustomLabel4.TabIndex = 23;
            this.bunifuCustomLabel4.Text = "ID: 00001";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(21, 82);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(170, 128);
            this.txtDescripcion.TabIndex = 24;
            this.txtDescripcion.Text = "";
            // 
            // Pendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pnContIzq);
            this.Controls.Add(this.pnTop);
            this.Name = "Pendientes";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registrada;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.RichTextBox txtDescripcion;
    }
}
