namespace iS_Repair.Pestañas
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.dgvClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardDatosCLiente = new Bunifu.Framework.UI.BunifuCards();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sepDivisor = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnDownTopPanel = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnContenido = new System.Windows.Forms.Panel();
            this.pnContIzq = new System.Windows.Forms.Panel();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.cardDatosCLiente.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownTopPanel)).BeginInit();
            this.pnContenido.SuspendLayout();
            this.pnContIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeight = 30;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.NoTelefono});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.DoubleBuffered = true;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvClientes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.dgvClientes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvClientes.Location = new System.Drawing.Point(202, 0);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientes.RowTemplate.Height = 30;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(769, 630);
            this.dgvClientes.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 60;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // NoTelefono
            // 
            this.NoTelefono.HeaderText = "No. Teléfono";
            this.NoTelefono.MinimumWidth = 6;
            this.NoTelefono.Name = "NoTelefono";
            this.NoTelefono.ReadOnly = true;
            // 
            // cardDatosCLiente
            // 
            this.cardDatosCLiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cardDatosCLiente.BorderRadius = 5;
            this.cardDatosCLiente.BottomSahddow = true;
            this.cardDatosCLiente.color = System.Drawing.Color.Transparent;
            this.cardDatosCLiente.Controls.Add(this.btnRegistrar);
            this.cardDatosCLiente.Controls.Add(this.bunifuCustomLabel4);
            this.cardDatosCLiente.Controls.Add(this.bunifuCustomLabel3);
            this.cardDatosCLiente.Controls.Add(this.bunifuMaterialTextbox2);
            this.cardDatosCLiente.Controls.Add(this.bunifuCustomLabel2);
            this.cardDatosCLiente.Controls.Add(this.bunifuMaterialTextbox1);
            this.cardDatosCLiente.LeftSahddow = false;
            this.cardDatosCLiente.Location = new System.Drawing.Point(22, 59);
            this.cardDatosCLiente.Margin = new System.Windows.Forms.Padding(2);
            this.cardDatosCLiente.Name = "cardDatosCLiente";
            this.cardDatosCLiente.RightSahddow = true;
            this.cardDatosCLiente.ShadowDepth = 20;
            this.cardDatosCLiente.Size = new System.Drawing.Size(463, 208);
            this.cardDatosCLiente.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ActiveBorderThickness = 1;
            this.btnRegistrar.ActiveCornerRadius = 20;
            this.btnRegistrar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnRegistrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegistrar.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
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
            this.btnRegistrar.Location = new System.Drawing.Point(170, 165);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 38);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(169, 9);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(126, 23);
            this.bunifuCustomLabel4.TabIndex = 15;
            this.bunifuCustomLabel4.Text = "ID: 19100000";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(178, 108);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(108, 19);
            this.bunifuCustomLabel3.TabIndex = 14;
            this.bunifuCustomLabel3.Text = "No. Teléfono:";
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox2.HintText = "(123) 456 7890";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(219)))));
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.bunifuMaterialTextbox2.LineThickness = 4;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(151, 126);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(162, 38);
            this.bunifuMaterialTextbox2.TabIndex = 13;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(194, 37);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(77, 19);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Nombre:";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.HintText = "Nombre(s) Apellido P. Apellido M.";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(219)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.bunifuMaterialTextbox1.LineThickness = 4;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(49, 61);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(367, 40);
            this.bunifuMaterialTextbox1.TabIndex = 1;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sepDivisor
            // 
            this.sepDivisor.BackColor = System.Drawing.Color.Transparent;
            this.sepDivisor.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.sepDivisor.LineThickness = 5;
            this.sepDivisor.Location = new System.Drawing.Point(22, 269);
            this.sepDivisor.Margin = new System.Windows.Forms.Padding(4);
            this.sepDivisor.Name = "sepDivisor";
            this.sepDivisor.Size = new System.Drawing.Size(926, 23);
            this.sepDivisor.TabIndex = 13;
            this.sepDivisor.Transparency = 255;
            this.sepDivisor.Vertical = false;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(61, 10);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(193, 30);
            this.bunifuCustomLabel5.TabIndex = 15;
            this.bunifuCustomLabel5.Text = "Registro de clientes";
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.White;
            this.pnTop.Controls.Add(this.btnDownTopPanel);
            this.pnTop.Controls.Add(this.bunifuCustomLabel5);
            this.pnTop.Controls.Add(this.cardDatosCLiente);
            this.pnTop.Controls.Add(this.sepDivisor);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(971, 50);
            this.pnTop.TabIndex = 16;
            // 
            // btnDownTopPanel
            // 
            this.btnDownTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnDownTopPanel.Image = global::iS_Repair.Properties.Resources.teclado;
            this.btnDownTopPanel.ImageActive = null;
            this.btnDownTopPanel.Location = new System.Drawing.Point(22, 10);
            this.btnDownTopPanel.Name = "btnDownTopPanel";
            this.btnDownTopPanel.Size = new System.Drawing.Size(34, 33);
            this.btnDownTopPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDownTopPanel.TabIndex = 14;
            this.btnDownTopPanel.TabStop = false;
            this.btnDownTopPanel.Zoom = 10;
            this.btnDownTopPanel.Click += new System.EventHandler(this.btnDownTopPanel_Click);
            // 
            // pnContenido
            // 
            this.pnContenido.Controls.Add(this.dgvClientes);
            this.pnContenido.Controls.Add(this.pnContIzq);
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenido.Location = new System.Drawing.Point(0, 50);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(971, 630);
            this.pnContenido.TabIndex = 17;
            // 
            // pnContIzq
            // 
            this.pnContIzq.BackColor = System.Drawing.Color.White;
            this.pnContIzq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContIzq.Controls.Add(this.btnBuscar);
            this.pnContIzq.Controls.Add(this.pbBuscar);
            this.pnContIzq.Controls.Add(this.txtBuscar);
            this.pnContIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContIzq.Location = new System.Drawing.Point(0, 0);
            this.pnContIzq.Name = "pnContIzq";
            this.pnContIzq.Size = new System.Drawing.Size(202, 630);
            this.pnContIzq.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.BorderRadius = 0;
            this.btnBuscar.ButtonText = "Buscar";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Iconimage")));
            this.btnBuscar.Iconimage_right = null;
            this.btnBuscar.Iconimage_right_Selected = null;
            this.btnBuscar.Iconimage_Selected = null;
            this.btnBuscar.IconMarginLeft = 0;
            this.btnBuscar.IconMarginRight = 0;
            this.btnBuscar.IconRightVisible = true;
            this.btnBuscar.IconRightZoom = 0D;
            this.btnBuscar.IconVisible = false;
            this.btnBuscar.IconZoom = 90D;
            this.btnBuscar.IsTab = false;
            this.btnBuscar.Location = new System.Drawing.Point(127, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnBuscar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.btnBuscar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscar.selected = false;
            this.btnBuscar.Size = new System.Drawing.Size(63, 39);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Textcolor = System.Drawing.Color.White;
            this.btnBuscar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = global::iS_Repair.Properties.Resources.search;
            this.pbBuscar.Location = new System.Drawing.Point(16, 25);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(33, 29);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBuscar.TabIndex = 5;
            this.pbBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.txtBuscar.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.txtBuscar.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.txtBuscar.BorderThickness = 2;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.isPassword = false;
            this.txtBuscar.Location = new System.Drawing.Point(8, 19);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(120, 40);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnContenido);
            this.Controls.Add(this.pnTop);
            this.Name = "Clientes";
            this.Size = new System.Drawing.Size(971, 680);
            this.SizeChanged += new System.EventHandler(this.Clientes_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.cardDatosCLiente.ResumeLayout(false);
            this.cardDatosCLiente.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownTopPanel)).EndInit();
            this.pnContenido.ResumeLayout(false);
            this.pnContIzq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvClientes;
        private Bunifu.Framework.UI.BunifuCards cardDatosCLiente;
        private Bunifu.Framework.UI.BunifuSeparator sepDivisor;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuImageButton btnDownTopPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnContenido;
        private System.Windows.Forms.Panel pnContIzq;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoTelefono;
    }
}
