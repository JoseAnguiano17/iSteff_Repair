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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.dgvClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlFiltros = new Bunifu.Framework.UI.BunifuCards();
            this.chkFiltroNoTelefono = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkFiltroNombre = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkFiltroID = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtFiltroNoTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFiltroNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFiltroID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sepFiltro = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblFiltros = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cardDatosCLiente = new Bunifu.Framework.UI.BunifuCards();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sepDivisor = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDownTopPanel = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnContenido = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            this.cardDatosCLiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownTopPanel)).BeginInit();
            this.pnTop.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.NoTelefono});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvClientes.DoubleBuffered = true;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.dgvClientes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvClientes.Location = new System.Drawing.Point(280, 17);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(668, 376);
            this.dgvClientes.TabIndex = 1;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(219)))));
            this.pnlFiltros.BorderRadius = 5;
            this.pnlFiltros.BottomSahddow = true;
            this.pnlFiltros.color = System.Drawing.Color.Transparent;
            this.pnlFiltros.Controls.Add(this.chkFiltroNoTelefono);
            this.pnlFiltros.Controls.Add(this.chkFiltroNombre);
            this.pnlFiltros.Controls.Add(this.chkFiltroID);
            this.pnlFiltros.Controls.Add(this.txtFiltroNoTelefono);
            this.pnlFiltros.Controls.Add(this.txtFiltroNombre);
            this.pnlFiltros.Controls.Add(this.txtFiltroID);
            this.pnlFiltros.Controls.Add(this.sepFiltro);
            this.pnlFiltros.Controls.Add(this.lblFiltros);
            this.pnlFiltros.LeftSahddow = false;
            this.pnlFiltros.Location = new System.Drawing.Point(17, 74);
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.RightSahddow = true;
            this.pnlFiltros.ShadowDepth = 20;
            this.pnlFiltros.Size = new System.Drawing.Size(234, 318);
            this.pnlFiltros.TabIndex = 2;
            // 
            // chkFiltroNoTelefono
            // 
            this.chkFiltroNoTelefono.BackColor = System.Drawing.Color.Gainsboro;
            this.chkFiltroNoTelefono.ChechedOffColor = System.Drawing.Color.Gainsboro;
            this.chkFiltroNoTelefono.Checked = false;
            this.chkFiltroNoTelefono.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.chkFiltroNoTelefono.ForeColor = System.Drawing.Color.White;
            this.chkFiltroNoTelefono.Location = new System.Drawing.Point(14, 264);
            this.chkFiltroNoTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.chkFiltroNoTelefono.Name = "chkFiltroNoTelefono";
            this.chkFiltroNoTelefono.Size = new System.Drawing.Size(20, 20);
            this.chkFiltroNoTelefono.TabIndex = 11;
            // 
            // chkFiltroNombre
            // 
            this.chkFiltroNombre.BackColor = System.Drawing.Color.Gainsboro;
            this.chkFiltroNombre.ChechedOffColor = System.Drawing.Color.Gainsboro;
            this.chkFiltroNombre.Checked = false;
            this.chkFiltroNombre.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.chkFiltroNombre.ForeColor = System.Drawing.Color.White;
            this.chkFiltroNombre.Location = new System.Drawing.Point(16, 180);
            this.chkFiltroNombre.Margin = new System.Windows.Forms.Padding(4);
            this.chkFiltroNombre.Name = "chkFiltroNombre";
            this.chkFiltroNombre.Size = new System.Drawing.Size(20, 20);
            this.chkFiltroNombre.TabIndex = 10;
            // 
            // chkFiltroID
            // 
            this.chkFiltroID.BackColor = System.Drawing.Color.Gainsboro;
            this.chkFiltroID.ChechedOffColor = System.Drawing.Color.Gainsboro;
            this.chkFiltroID.Checked = false;
            this.chkFiltroID.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.chkFiltroID.ForeColor = System.Drawing.Color.White;
            this.chkFiltroID.Location = new System.Drawing.Point(14, 94);
            this.chkFiltroID.Margin = new System.Windows.Forms.Padding(4);
            this.chkFiltroID.Name = "chkFiltroID";
            this.chkFiltroID.Size = new System.Drawing.Size(20, 20);
            this.chkFiltroID.TabIndex = 9;
            // 
            // txtFiltroNoTelefono
            // 
            this.txtFiltroNoTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroNoTelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroNoTelefono.ForeColor = System.Drawing.Color.White;
            this.txtFiltroNoTelefono.HintForeColor = System.Drawing.Color.White;
            this.txtFiltroNoTelefono.HintText = "No. Teléfono...";
            this.txtFiltroNoTelefono.isPassword = false;
            this.txtFiltroNoTelefono.LineFocusedColor = System.Drawing.Color.White;
            this.txtFiltroNoTelefono.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFiltroNoTelefono.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtFiltroNoTelefono.LineThickness = 2;
            this.txtFiltroNoTelefono.Location = new System.Drawing.Point(41, 255);
            this.txtFiltroNoTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroNoTelefono.Name = "txtFiltroNoTelefono";
            this.txtFiltroNoTelefono.Size = new System.Drawing.Size(178, 29);
            this.txtFiltroNoTelefono.TabIndex = 8;
            this.txtFiltroNoTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroNombre.ForeColor = System.Drawing.Color.White;
            this.txtFiltroNombre.HintForeColor = System.Drawing.Color.White;
            this.txtFiltroNombre.HintText = "Nombre...";
            this.txtFiltroNombre.isPassword = false;
            this.txtFiltroNombre.LineFocusedColor = System.Drawing.Color.White;
            this.txtFiltroNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFiltroNombre.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtFiltroNombre.LineThickness = 2;
            this.txtFiltroNombre.Location = new System.Drawing.Point(43, 171);
            this.txtFiltroNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(176, 29);
            this.txtFiltroNombre.TabIndex = 7;
            this.txtFiltroNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiltroID
            // 
            this.txtFiltroID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroID.ForeColor = System.Drawing.Color.White;
            this.txtFiltroID.HintForeColor = System.Drawing.Color.White;
            this.txtFiltroID.HintText = "ID...";
            this.txtFiltroID.isPassword = false;
            this.txtFiltroID.LineFocusedColor = System.Drawing.Color.White;
            this.txtFiltroID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFiltroID.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtFiltroID.LineThickness = 2;
            this.txtFiltroID.Location = new System.Drawing.Point(41, 89);
            this.txtFiltroID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroID.Name = "txtFiltroID";
            this.txtFiltroID.Size = new System.Drawing.Size(178, 29);
            this.txtFiltroID.TabIndex = 6;
            this.txtFiltroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroID.OnValueChanged += new System.EventHandler(this.TxtFiltroID_OnValueChanged);
            // 
            // sepFiltro
            // 
            this.sepFiltro.BackColor = System.Drawing.Color.Transparent;
            this.sepFiltro.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sepFiltro.LineThickness = 2;
            this.sepFiltro.Location = new System.Drawing.Point(14, 55);
            this.sepFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.sepFiltro.Name = "sepFiltro";
            this.sepFiltro.Size = new System.Drawing.Size(205, 23);
            this.sepFiltro.TabIndex = 4;
            this.sepFiltro.Transparency = 255;
            this.sepFiltro.Vertical = false;
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.ForeColor = System.Drawing.Color.White;
            this.lblFiltros.Location = new System.Drawing.Point(82, 18);
            this.lblFiltros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(67, 25);
            this.lblFiltros.TabIndex = 5;
            this.lblFiltros.Text = "Filtros";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.HintForeColor = System.Drawing.Color.Black;
            this.txtBuscar.HintText = "Buscar...";
            this.txtBuscar.isPassword = false;
            this.txtBuscar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.txtBuscar.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(219)))));
            this.txtBuscar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(30)))), ((int)(((byte)(219)))));
            this.txtBuscar.LineThickness = 3;
            this.txtBuscar.Location = new System.Drawing.Point(17, 16);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 45);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardDatosCLiente
            // 
            this.cardDatosCLiente.BackColor = System.Drawing.Color.Gainsboro;
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
            this.cardDatosCLiente.Location = new System.Drawing.Point(22, 55);
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
            this.btnRegistrar.BackColor = System.Drawing.Color.Gainsboro;
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
            this.bunifuMaterialTextbox2.BackColor = System.Drawing.Color.Silver;
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
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.Color.Silver;
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = global::iS_Repair.Properties.Resources.search;
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.Location = new System.Drawing.Point(214, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 29);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Zoom = 10;
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
            // pnContenido
            // 
            this.pnContenido.Controls.Add(this.txtBuscar);
            this.pnContenido.Controls.Add(this.dgvClientes);
            this.pnContenido.Controls.Add(this.pnlFiltros);
            this.pnContenido.Controls.Add(this.btnBuscar);
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenido.Location = new System.Drawing.Point(0, 50);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(971, 630);
            this.pnContenido.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 30;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // NoTelefono
            // 
            this.NoTelefono.HeaderText = "No. Teléfono";
            this.NoTelefono.MinimumWidth = 6;
            this.NoTelefono.Name = "NoTelefono";
            this.NoTelefono.ReadOnly = true;
            this.NoTelefono.Width = 125;
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
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.cardDatosCLiente.ResumeLayout(false);
            this.cardDatosCLiente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownTopPanel)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvClientes;
        private Bunifu.Framework.UI.BunifuCards pnlFiltros;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFiltros;
        private Bunifu.Framework.UI.BunifuSeparator sepFiltro;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuCheckbox chkFiltroNoTelefono;
        private Bunifu.Framework.UI.BunifuCheckbox chkFiltroNombre;
        private Bunifu.Framework.UI.BunifuCheckbox chkFiltroID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltroNoTelefono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltroNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltroID;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoTelefono;
    }
}
