
namespace Prototipo1P
{
    partial class frmCobros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobros));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblProto = new System.Windows.Forms.Label();
            this.pnlPagos = new System.Windows.Forms.Panel();
            this.pnlIconoPagos = new System.Windows.Forms.Panel();
            this.lblPagos = new System.Windows.Forms.Label();
            this.pnlCobros = new System.Windows.Forms.Panel();
            this.pnlIconoCobros = new System.Windows.Forms.Panel();
            this.lblCobros = new System.Windows.Forms.Label();
            this.lblTtuloCobros = new System.Windows.Forms.Label();
            this.txtCodigoCo = new System.Windows.Forms.TextBox();
            this.pnlContenidoCC = new System.Windows.Forms.Panel();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblIngresarC = new System.Windows.Forms.Label();
            this.lblModificarC = new System.Windows.Forms.Label();
            this.pnlBordeIC = new System.Windows.Forms.Panel();
            this.pnlBordeMC = new System.Windows.Forms.Panel();
            this.pnlContenidoTC = new System.Windows.Forms.Panel();
            this.cbxTC = new System.Windows.Forms.ComboBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.pnlCP = new System.Windows.Forms.Panel();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.pnlDV = new System.Windows.Forms.Panel();
            this.cbxDV = new System.Windows.Forms.ComboBox();
            this.lblDC = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.pnlIconoC = new System.Windows.Forms.Panel();
            this.pnlMC = new System.Windows.Forms.Panel();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.pnlIconoBC = new System.Windows.Forms.Panel();
            this.txtBuscarC = new System.Windows.Forms.TextBox();
            this.dvgCobro = new System.Windows.Forms.DataGridView();
            this.pnlCerrar = new System.Windows.Forms.Panel();
            this.pnlSaldoV = new System.Windows.Forms.Panel();
            this.lblSaldoVenta = new System.Windows.Forms.Label();
            this.txtSaldoVenta = new System.Windows.Forms.TextBox();
            this.pnlLlenarCamp = new System.Windows.Forms.Panel();
            this.lblEliminarC = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.codigoCobroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSidebar.SuspendLayout();
            this.pnlPagos.SuspendLayout();
            this.pnlCobros.SuspendLayout();
            this.pnlContenidoCC.SuspendLayout();
            this.pnlContenidoTC.SuspendLayout();
            this.pnlCP.SuspendLayout();
            this.pnlDV.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCobro)).BeginInit();
            this.pnlSaldoV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.pnlSidebar.Controls.Add(this.lblProto);
            this.pnlSidebar.Controls.Add(this.pnlPagos);
            this.pnlSidebar.Controls.Add(this.pnlCobros);
            this.pnlSidebar.Location = new System.Drawing.Point(-3, -2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(188, 551);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblProto
            // 
            this.lblProto.AutoSize = true;
            this.lblProto.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProto.Location = new System.Drawing.Point(37, 25);
            this.lblProto.Name = "lblProto";
            this.lblProto.Size = new System.Drawing.Size(111, 28);
            this.lblProto.TabIndex = 13;
            this.lblProto.Text = "Prototipo";
            // 
            // pnlPagos
            // 
            this.pnlPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.pnlPagos.Controls.Add(this.pnlIconoPagos);
            this.pnlPagos.Controls.Add(this.lblPagos);
            this.pnlPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPagos.Location = new System.Drawing.Point(3, 263);
            this.pnlPagos.Name = "pnlPagos";
            this.pnlPagos.Size = new System.Drawing.Size(185, 33);
            this.pnlPagos.TabIndex = 3;
            this.pnlPagos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPagos_MouseClick);
            // 
            // pnlIconoPagos
            // 
            this.pnlIconoPagos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIconoPagos.BackgroundImage")));
            this.pnlIconoPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIconoPagos.Location = new System.Drawing.Point(15, 8);
            this.pnlIconoPagos.Name = "pnlIconoPagos";
            this.pnlIconoPagos.Size = new System.Drawing.Size(20, 19);
            this.pnlIconoPagos.TabIndex = 2;
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Location = new System.Drawing.Point(81, 11);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(37, 13);
            this.lblPagos.TabIndex = 1;
            this.lblPagos.Text = "Pagos";
            // 
            // pnlCobros
            // 
            this.pnlCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.pnlCobros.Controls.Add(this.pnlIconoCobros);
            this.pnlCobros.Controls.Add(this.lblCobros);
            this.pnlCobros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCobros.Location = new System.Drawing.Point(3, 230);
            this.pnlCobros.Name = "pnlCobros";
            this.pnlCobros.Size = new System.Drawing.Size(185, 33);
            this.pnlCobros.TabIndex = 1;
            this.pnlCobros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCobros_MouseClick);
            // 
            // pnlIconoCobros
            // 
            this.pnlIconoCobros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIconoCobros.BackgroundImage")));
            this.pnlIconoCobros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIconoCobros.Location = new System.Drawing.Point(15, 8);
            this.pnlIconoCobros.Name = "pnlIconoCobros";
            this.pnlIconoCobros.Size = new System.Drawing.Size(20, 19);
            this.pnlIconoCobros.TabIndex = 2;
            // 
            // lblCobros
            // 
            this.lblCobros.AutoSize = true;
            this.lblCobros.Location = new System.Drawing.Point(83, 11);
            this.lblCobros.Name = "lblCobros";
            this.lblCobros.Size = new System.Drawing.Size(40, 13);
            this.lblCobros.TabIndex = 1;
            this.lblCobros.Text = "Cobros";
            // 
            // lblTtuloCobros
            // 
            this.lblTtuloCobros.AutoSize = true;
            this.lblTtuloCobros.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtuloCobros.Location = new System.Drawing.Point(203, 9);
            this.lblTtuloCobros.Name = "lblTtuloCobros";
            this.lblTtuloCobros.Size = new System.Drawing.Size(84, 28);
            this.lblTtuloCobros.TabIndex = 1;
            this.lblTtuloCobros.Text = "Cobros";
            // 
            // txtCodigoCo
            // 
            this.txtCodigoCo.Location = new System.Drawing.Point(11, 38);
            this.txtCodigoCo.Name = "txtCodigoCo";
            this.txtCodigoCo.Size = new System.Drawing.Size(108, 20);
            this.txtCodigoCo.TabIndex = 2;
            // 
            // pnlContenidoCC
            // 
            this.pnlContenidoCC.Controls.Add(this.lblCC);
            this.pnlContenidoCC.Controls.Add(this.txtCodigoCo);
            this.pnlContenidoCC.Location = new System.Drawing.Point(276, 167);
            this.pnlContenidoCC.Name = "pnlContenidoCC";
            this.pnlContenidoCC.Size = new System.Drawing.Size(133, 70);
            this.pnlContenidoCC.TabIndex = 3;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(13, 13);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(71, 13);
            this.lblCC.TabIndex = 3;
            this.lblCC.Text = "Codigo Cobro";
            // 
            // lblIngresarC
            // 
            this.lblIngresarC.AutoSize = true;
            this.lblIngresarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIngresarC.Location = new System.Drawing.Point(273, 87);
            this.lblIngresarC.Name = "lblIngresarC";
            this.lblIngresarC.Size = new System.Drawing.Size(76, 13);
            this.lblIngresarC.TabIndex = 4;
            this.lblIngresarC.Text = "Ingresar Cobro";
            this.lblIngresarC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblIngresarC_MouseClick);
            // 
            // lblModificarC
            // 
            this.lblModificarC.AutoSize = true;
            this.lblModificarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblModificarC.Location = new System.Drawing.Point(528, 87);
            this.lblModificarC.Name = "lblModificarC";
            this.lblModificarC.Size = new System.Drawing.Size(81, 13);
            this.lblModificarC.TabIndex = 5;
            this.lblModificarC.Text = "Modificar Cobro";
            this.lblModificarC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblModificarC_MouseClick);
            // 
            // pnlBordeIC
            // 
            this.pnlBordeIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.pnlBordeIC.Location = new System.Drawing.Point(270, 102);
            this.pnlBordeIC.Name = "pnlBordeIC";
            this.pnlBordeIC.Size = new System.Drawing.Size(82, 3);
            this.pnlBordeIC.TabIndex = 7;
            // 
            // pnlBordeMC
            // 
            this.pnlBordeMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.pnlBordeMC.Location = new System.Drawing.Point(527, 103);
            this.pnlBordeMC.Name = "pnlBordeMC";
            this.pnlBordeMC.Size = new System.Drawing.Size(82, 3);
            this.pnlBordeMC.TabIndex = 8;
            // 
            // pnlContenidoTC
            // 
            this.pnlContenidoTC.Controls.Add(this.cbxTC);
            this.pnlContenidoTC.Controls.Add(this.lblTipoPago);
            this.pnlContenidoTC.Location = new System.Drawing.Point(499, 167);
            this.pnlContenidoTC.Name = "pnlContenidoTC";
            this.pnlContenidoTC.Size = new System.Drawing.Size(133, 70);
            this.pnlContenidoTC.TabIndex = 4;
            // 
            // cbxTC
            // 
            this.cbxTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTC.FormattingEnabled = true;
            this.cbxTC.Location = new System.Drawing.Point(6, 37);
            this.cbxTC.Name = "cbxTC";
            this.cbxTC.Size = new System.Drawing.Size(121, 21);
            this.cbxTC.TabIndex = 4;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(5, 13);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(59, 13);
            this.lblTipoPago.TabIndex = 3;
            this.lblTipoPago.Text = "Tipo Cobro";
            // 
            // pnlCP
            // 
            this.pnlCP.Controls.Add(this.lblPago);
            this.pnlCP.Controls.Add(this.txtCP);
            this.pnlCP.Location = new System.Drawing.Point(704, 167);
            this.pnlCP.Name = "pnlCP";
            this.pnlCP.Size = new System.Drawing.Size(133, 70);
            this.pnlCP.TabIndex = 4;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(13, 13);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(77, 13);
            this.lblPago.TabIndex = 3;
            this.lblPago.Text = "Cantidad Pago";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(11, 38);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(108, 20);
            this.txtCP.TabIndex = 2;
            // 
            // pnlDV
            // 
            this.pnlDV.Controls.Add(this.cbxDV);
            this.pnlDV.Controls.Add(this.lblDC);
            this.pnlDV.Location = new System.Drawing.Point(276, 268);
            this.pnlDV.Name = "pnlDV";
            this.pnlDV.Size = new System.Drawing.Size(133, 70);
            this.pnlDV.TabIndex = 5;
            // 
            // cbxDV
            // 
            this.cbxDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDV.FormattingEnabled = true;
            this.cbxDV.Location = new System.Drawing.Point(6, 37);
            this.cbxDV.Name = "cbxDV";
            this.cbxDV.Size = new System.Drawing.Size(121, 21);
            this.cbxDV.TabIndex = 4;
            this.cbxDV.SelectedIndexChanged += new System.EventHandler(this.cbxDV_SelectedIndexChanged);
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(5, 13);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(93, 13);
            this.lblDC.TabIndex = 3;
            this.lblDC.Text = "Documento Venta";
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.lblCliente);
            this.pnlCliente.Controls.Add(this.txtCliente);
            this.pnlCliente.Location = new System.Drawing.Point(499, 268);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(133, 70);
            this.pnlCliente.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(13, 13);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(11, 38);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(108, 20);
            this.txtCliente.TabIndex = 2;
            // 
            // pnlIconoC
            // 
            this.pnlIconoC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIconoC.BackgroundImage")));
            this.pnlIconoC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIconoC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlIconoC.Location = new System.Drawing.Point(315, 363);
            this.pnlIconoC.Name = "pnlIconoC";
            this.pnlIconoC.Size = new System.Drawing.Size(43, 42);
            this.pnlIconoC.TabIndex = 10;
            this.pnlIconoC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlIconoC_MouseClick);
            // 
            // pnlMC
            // 
            this.pnlMC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMC.BackgroundImage")));
            this.pnlMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMC.Location = new System.Drawing.Point(315, 363);
            this.pnlMC.Name = "pnlMC";
            this.pnlMC.Size = new System.Drawing.Size(43, 42);
            this.pnlMC.TabIndex = 11;
            this.pnlMC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlMC_MouseClick);
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEliminar.BackgroundImage")));
            this.pnlEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlEliminar.Location = new System.Drawing.Point(313, 363);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(43, 42);
            this.pnlEliminar.TabIndex = 12;
            this.pnlEliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlEliminar_MouseClick);
            // 
            // pnlIconoBC
            // 
            this.pnlIconoBC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIconoBC.BackgroundImage")));
            this.pnlIconoBC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIconoBC.Location = new System.Drawing.Point(893, 363);
            this.pnlIconoBC.Name = "pnlIconoBC";
            this.pnlIconoBC.Size = new System.Drawing.Size(21, 20);
            this.pnlIconoBC.TabIndex = 29;
            this.pnlIconoBC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlIconoBC_MouseClick);
            // 
            // txtBuscarC
            // 
            this.txtBuscarC.Location = new System.Drawing.Point(573, 363);
            this.txtBuscarC.Name = "txtBuscarC";
            this.txtBuscarC.Size = new System.Drawing.Size(314, 20);
            this.txtBuscarC.TabIndex = 27;
            // 
            // dvgCobro
            // 
            this.dvgCobro.AutoGenerateColumns = false;
            this.dvgCobro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCobro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCobroDataGridViewTextBoxColumn,
            this.tipoPagoDataGridViewTextBoxColumn,
            this.documentoVentaDataGridViewTextBoxColumn,
            this.cantidadPagoDataGridViewTextBoxColumn});
            this.dvgCobro.DataSource = this.cobrosBindingSource;
            this.dvgCobro.Location = new System.Drawing.Point(573, 389);
            this.dvgCobro.Name = "dvgCobro";
            this.dvgCobro.Size = new System.Drawing.Size(341, 150);
            this.dvgCobro.TabIndex = 28;
            // 
            // pnlCerrar
            // 
            this.pnlCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCerrar.BackgroundImage")));
            this.pnlCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCerrar.Location = new System.Drawing.Point(905, 9);
            this.pnlCerrar.Name = "pnlCerrar";
            this.pnlCerrar.Size = new System.Drawing.Size(21, 22);
            this.pnlCerrar.TabIndex = 30;
            // 
            // pnlSaldoV
            // 
            this.pnlSaldoV.Controls.Add(this.lblSaldoVenta);
            this.pnlSaldoV.Controls.Add(this.txtSaldoVenta);
            this.pnlSaldoV.Location = new System.Drawing.Point(704, 269);
            this.pnlSaldoV.Name = "pnlSaldoV";
            this.pnlSaldoV.Size = new System.Drawing.Size(133, 70);
            this.pnlSaldoV.TabIndex = 5;
            // 
            // lblSaldoVenta
            // 
            this.lblSaldoVenta.AutoSize = true;
            this.lblSaldoVenta.Location = new System.Drawing.Point(13, 13);
            this.lblSaldoVenta.Name = "lblSaldoVenta";
            this.lblSaldoVenta.Size = new System.Drawing.Size(67, 13);
            this.lblSaldoVenta.TabIndex = 3;
            this.lblSaldoVenta.Text = "Saldo Actual";
            // 
            // txtSaldoVenta
            // 
            this.txtSaldoVenta.Enabled = false;
            this.txtSaldoVenta.Location = new System.Drawing.Point(11, 38);
            this.txtSaldoVenta.Name = "txtSaldoVenta";
            this.txtSaldoVenta.Size = new System.Drawing.Size(108, 20);
            this.txtSaldoVenta.TabIndex = 2;
            // 
            // pnlLlenarCamp
            // 
            this.pnlLlenarCamp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLlenarCamp.BackgroundImage")));
            this.pnlLlenarCamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLlenarCamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLlenarCamp.Location = new System.Drawing.Point(432, 441);
            this.pnlLlenarCamp.Name = "pnlLlenarCamp";
            this.pnlLlenarCamp.Size = new System.Drawing.Size(119, 22);
            this.pnlLlenarCamp.TabIndex = 31;
            this.pnlLlenarCamp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlLlenarCamp_MouseClick);
            // 
            // lblEliminarC
            // 
            this.lblEliminarC.AutoSize = true;
            this.lblEliminarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminarC.Location = new System.Drawing.Point(764, 86);
            this.lblEliminarC.Name = "lblEliminarC";
            this.lblEliminarC.Size = new System.Drawing.Size(74, 13);
            this.lblEliminarC.TabIndex = 6;
            this.lblEliminarC.Text = "Eliminar Cobro";
            this.lblEliminarC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblEliminarC_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.panel2.Location = new System.Drawing.Point(761, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 3);
            this.panel2.TabIndex = 9;
            // 
            // codigoCobroDataGridViewTextBoxColumn
            // 
            this.codigoCobroDataGridViewTextBoxColumn.DataPropertyName = "CodigoCobro";
            this.codigoCobroDataGridViewTextBoxColumn.HeaderText = "Codigo Cobro";
            this.codigoCobroDataGridViewTextBoxColumn.Name = "codigoCobroDataGridViewTextBoxColumn";
            // 
            // tipoPagoDataGridViewTextBoxColumn
            // 
            this.tipoPagoDataGridViewTextBoxColumn.DataPropertyName = "TipoPago";
            this.tipoPagoDataGridViewTextBoxColumn.HeaderText = "Tipo Pago";
            this.tipoPagoDataGridViewTextBoxColumn.Name = "tipoPagoDataGridViewTextBoxColumn";
            // 
            // documentoVentaDataGridViewTextBoxColumn
            // 
            this.documentoVentaDataGridViewTextBoxColumn.DataPropertyName = "DocumentoVenta";
            this.documentoVentaDataGridViewTextBoxColumn.HeaderText = "Documento Venta";
            this.documentoVentaDataGridViewTextBoxColumn.Name = "documentoVentaDataGridViewTextBoxColumn";
            // 
            // cantidadPagoDataGridViewTextBoxColumn
            // 
            this.cantidadPagoDataGridViewTextBoxColumn.DataPropertyName = "CantidadPago";
            this.cantidadPagoDataGridViewTextBoxColumn.HeaderText = "Cantidad Pago";
            this.cantidadPagoDataGridViewTextBoxColumn.Name = "cantidadPagoDataGridViewTextBoxColumn";
            // 
            // cobrosBindingSource
            // 
            this.cobrosBindingSource.DataSource = typeof(Prototipo1P.Clases.Cobros);
            // 
            // frmCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 546);
            this.Controls.Add(this.pnlLlenarCamp);
            this.Controls.Add(this.pnlSaldoV);
            this.Controls.Add(this.pnlCerrar);
            this.Controls.Add(this.pnlIconoBC);
            this.Controls.Add(this.txtBuscarC);
            this.Controls.Add(this.dvgCobro);
            this.Controls.Add(this.pnlEliminar);
            this.Controls.Add(this.pnlMC);
            this.Controls.Add(this.pnlIconoC);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.pnlDV);
            this.Controls.Add(this.pnlCP);
            this.Controls.Add(this.pnlContenidoTC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBordeMC);
            this.Controls.Add(this.pnlBordeIC);
            this.Controls.Add(this.lblEliminarC);
            this.Controls.Add(this.lblModificarC);
            this.Controls.Add(this.lblIngresarC);
            this.Controls.Add(this.pnlContenidoCC);
            this.Controls.Add(this.lblTtuloCobros);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCobros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobros";
            this.Load += new System.EventHandler(this.frmCobros_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlPagos.ResumeLayout(false);
            this.pnlPagos.PerformLayout();
            this.pnlCobros.ResumeLayout(false);
            this.pnlCobros.PerformLayout();
            this.pnlContenidoCC.ResumeLayout(false);
            this.pnlContenidoCC.PerformLayout();
            this.pnlContenidoTC.ResumeLayout(false);
            this.pnlContenidoTC.PerformLayout();
            this.pnlCP.ResumeLayout(false);
            this.pnlCP.PerformLayout();
            this.pnlDV.ResumeLayout(false);
            this.pnlDV.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCobro)).EndInit();
            this.pnlSaldoV.ResumeLayout(false);
            this.pnlSaldoV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlCobros;
        private System.Windows.Forms.Panel pnlIconoCobros;
        private System.Windows.Forms.Label lblCobros;
        private System.Windows.Forms.Panel pnlPagos;
        private System.Windows.Forms.Panel pnlIconoPagos;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label lblTtuloCobros;
        private System.Windows.Forms.TextBox txtCodigoCo;
        private System.Windows.Forms.Panel pnlContenidoCC;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblIngresarC;
        private System.Windows.Forms.Label lblModificarC;
        private System.Windows.Forms.Panel pnlBordeIC;
        private System.Windows.Forms.Panel pnlBordeMC;
        private System.Windows.Forms.Panel pnlContenidoTC;
        private System.Windows.Forms.ComboBox cbxTC;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Panel pnlCP;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Panel pnlDV;
        private System.Windows.Forms.ComboBox cbxDV;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Panel pnlIconoC;
        private System.Windows.Forms.Panel pnlMC;
        private System.Windows.Forms.Panel pnlEliminar;
        private System.Windows.Forms.Label lblProto;
        private System.Windows.Forms.Panel pnlIconoBC;
        private System.Windows.Forms.TextBox txtBuscarC;
        private System.Windows.Forms.DataGridView dvgCobro;
        private System.Windows.Forms.Panel pnlCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCobroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cobrosBindingSource;
        private System.Windows.Forms.Panel pnlSaldoV;
        private System.Windows.Forms.Label lblSaldoVenta;
        private System.Windows.Forms.TextBox txtSaldoVenta;
        private System.Windows.Forms.Panel pnlLlenarCamp;
        private System.Windows.Forms.Label lblEliminarC;
        private System.Windows.Forms.Panel panel2;
    }
}

