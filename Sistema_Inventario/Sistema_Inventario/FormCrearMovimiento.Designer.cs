namespace Sistema_Inventario
{
    partial class FormCrearMovimiento
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTemperaturaPromedio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCapacidadActual = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCapacidadMaxima = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.cmbAuxiliar = new System.Windows.Forms.ComboBox();
            this.lblAuxiliar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.lblBodega = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtVentaTotalSinIva = new System.Windows.Forms.TextBox();
            this.txtVentaTotalConIva = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cmbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroMovimiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarDetalleMovimiento = new System.Windows.Forms.Button();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetallesMovimientos = new System.Windows.Forms.DataGridView();
            this.btnCrearMovimiento = new System.Windows.Forms.Button();
            this.btnCancelarMovimiento = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.id_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_unitario_promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia_anterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtTemperaturaPromedio);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCapacidadActual);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCapacidadMaxima);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCostoUnitario);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.Controls.Add(this.txtIdUsuario);
            this.groupBox1.Controls.Add(this.cmbAuxiliar);
            this.groupBox1.Controls.Add(this.lblAuxiliar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbBodega);
            this.groupBox1.Controls.Add(this.lblBodega);
            this.groupBox1.Controls.Add(this.cmbProducto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtVentaTotalSinIva);
            this.groupBox1.Controls.Add(this.txtVentaTotalConIva);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.cmbTipoMovimiento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumeroMovimiento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // txtTemperaturaPromedio
            // 
            this.txtTemperaturaPromedio.BackColor = System.Drawing.Color.White;
            this.txtTemperaturaPromedio.ForeColor = System.Drawing.Color.Black;
            this.txtTemperaturaPromedio.Location = new System.Drawing.Point(453, 168);
            this.txtTemperaturaPromedio.Name = "txtTemperaturaPromedio";
            this.txtTemperaturaPromedio.ReadOnly = true;
            this.txtTemperaturaPromedio.Size = new System.Drawing.Size(82, 20);
            this.txtTemperaturaPromedio.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(309, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 15);
            this.label14.TabIndex = 38;
            this.label14.Text = "Temperatura Promedio:";
            // 
            // txtCapacidadActual
            // 
            this.txtCapacidadActual.BackColor = System.Drawing.Color.White;
            this.txtCapacidadActual.ForeColor = System.Drawing.Color.Black;
            this.txtCapacidadActual.Location = new System.Drawing.Point(453, 103);
            this.txtCapacidadActual.Name = "txtCapacidadActual";
            this.txtCapacidadActual.ReadOnly = true;
            this.txtCapacidadActual.Size = new System.Drawing.Size(82, 20);
            this.txtCapacidadActual.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(309, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 15);
            this.label13.TabIndex = 36;
            this.label13.Text = "Capacidad Actual:";
            // 
            // txtCapacidadMaxima
            // 
            this.txtCapacidadMaxima.BackColor = System.Drawing.Color.White;
            this.txtCapacidadMaxima.ForeColor = System.Drawing.Color.Black;
            this.txtCapacidadMaxima.Location = new System.Drawing.Point(453, 34);
            this.txtCapacidadMaxima.Name = "txtCapacidadMaxima";
            this.txtCapacidadMaxima.ReadOnly = true;
            this.txtCapacidadMaxima.Size = new System.Drawing.Size(82, 20);
            this.txtCapacidadMaxima.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(309, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Capacidad Máxima:";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.BackColor = System.Drawing.Color.White;
            this.txtCostoUnitario.ForeColor = System.Drawing.Color.Black;
            this.txtCostoUnitario.Location = new System.Drawing.Point(699, 106);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.ReadOnly = true;
            this.txtCostoUnitario.Size = new System.Drawing.Size(82, 20);
            this.txtCostoUnitario.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(562, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "Costo Unitario:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.White;
            this.nudCantidad.ForeColor = System.Drawing.Color.Black;
            this.nudCantidad.Location = new System.Drawing.Point(453, 244);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.ReadOnly = true;
            this.nudCantidad.Size = new System.Drawing.Size(82, 20);
            this.nudCantidad.TabIndex = 31;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.calcularTotales);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.Color.White;
            this.txtIdUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtIdUsuario.Location = new System.Drawing.Point(1192, 288);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(49, 20);
            this.txtIdUsuario.TabIndex = 30;
            // 
            // cmbAuxiliar
            // 
            this.cmbAuxiliar.BackColor = System.Drawing.Color.White;
            this.cmbAuxiliar.ForeColor = System.Drawing.Color.Black;
            this.cmbAuxiliar.FormattingEnabled = true;
            this.cmbAuxiliar.Location = new System.Drawing.Point(1026, 168);
            this.cmbAuxiliar.Name = "cmbAuxiliar";
            this.cmbAuxiliar.Size = new System.Drawing.Size(120, 21);
            this.cmbAuxiliar.TabIndex = 29;
            // 
            // lblAuxiliar
            // 
            this.lblAuxiliar.AutoSize = true;
            this.lblAuxiliar.BackColor = System.Drawing.Color.White;
            this.lblAuxiliar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuxiliar.ForeColor = System.Drawing.Color.Black;
            this.lblAuxiliar.Location = new System.Drawing.Point(902, 173);
            this.lblAuxiliar.Name = "lblAuxiliar";
            this.lblAuxiliar.Size = new System.Drawing.Size(63, 15);
            this.lblAuxiliar.TabIndex = 28;
            this.lblAuxiliar.Text = "lblAuxiliar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(309, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Cantidad:";
            // 
            // cmbBodega
            // 
            this.cmbBodega.BackColor = System.Drawing.Color.White;
            this.cmbBodega.Enabled = false;
            this.cmbBodega.ForeColor = System.Drawing.Color.Black;
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(167, 241);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(120, 21);
            this.cmbBodega.TabIndex = 25;
            this.cmbBodega.SelectionChangeCommitted += new System.EventHandler(this.cmbBodega_SelectedIndexChanged);
            // 
            // lblBodega
            // 
            this.lblBodega.AutoSize = true;
            this.lblBodega.BackColor = System.Drawing.Color.White;
            this.lblBodega.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodega.ForeColor = System.Drawing.Color.Black;
            this.lblBodega.Location = new System.Drawing.Point(24, 247);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(53, 15);
            this.lblBodega.TabIndex = 24;
            this.lblBodega.Text = "Bodega:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.BackColor = System.Drawing.Color.White;
            this.cmbProducto.Enabled = false;
            this.cmbProducto.ForeColor = System.Drawing.Color.Black;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(167, 170);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(120, 21);
            this.cmbProducto.TabIndex = 23;
            this.cmbProducto.SelectionChangeCommitted += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Producto:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(1026, 103);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(155, 20);
            this.txtUsuario.TabIndex = 21;
            // 
            // txtVentaTotalSinIva
            // 
            this.txtVentaTotalSinIva.BackColor = System.Drawing.Color.White;
            this.txtVentaTotalSinIva.ForeColor = System.Drawing.Color.Black;
            this.txtVentaTotalSinIva.Location = new System.Drawing.Point(699, 244);
            this.txtVentaTotalSinIva.Name = "txtVentaTotalSinIva";
            this.txtVentaTotalSinIva.ReadOnly = true;
            this.txtVentaTotalSinIva.Size = new System.Drawing.Size(155, 20);
            this.txtVentaTotalSinIva.TabIndex = 20;
            // 
            // txtVentaTotalConIva
            // 
            this.txtVentaTotalConIva.BackColor = System.Drawing.Color.White;
            this.txtVentaTotalConIva.ForeColor = System.Drawing.Color.Black;
            this.txtVentaTotalConIva.Location = new System.Drawing.Point(699, 168);
            this.txtVentaTotalConIva.Name = "txtVentaTotalConIva";
            this.txtVentaTotalConIva.ReadOnly = true;
            this.txtVentaTotalConIva.Size = new System.Drawing.Size(155, 20);
            this.txtVentaTotalConIva.TabIndex = 19;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.White;
            this.txtFecha.ForeColor = System.Drawing.Color.Black;
            this.txtFecha.Location = new System.Drawing.Point(1026, 30);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(118, 20);
            this.txtFecha.TabIndex = 18;
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.BackColor = System.Drawing.Color.White;
            this.cmbTipoMovimiento.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(167, 103);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(120, 21);
            this.cmbTipoMovimiento.TabIndex = 17;
            this.cmbTipoMovimiento.SelectionChangeCommitted += new System.EventHandler(this.validarSeleccionTipoMovimiento);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(902, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(562, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Costo Total sin IVA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(906, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(562, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Costo Total con IVA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Movimiento:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(699, 34);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(155, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(555, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // txtNumeroMovimiento
            // 
            this.txtNumeroMovimiento.BackColor = System.Drawing.Color.White;
            this.txtNumeroMovimiento.ForeColor = System.Drawing.Color.Black;
            this.txtNumeroMovimiento.Location = new System.Drawing.Point(167, 31);
            this.txtNumeroMovimiento.Name = "txtNumeroMovimiento";
            this.txtNumeroMovimiento.ReadOnly = true;
            this.txtNumeroMovimiento.Size = new System.Drawing.Size(55, 20);
            this.txtNumeroMovimiento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Movimiento:";
            // 
            // btnAgregarDetalleMovimiento
            // 
            this.btnAgregarDetalleMovimiento.BackColor = System.Drawing.Color.White;
            this.btnAgregarDetalleMovimiento.Enabled = false;
            this.btnAgregarDetalleMovimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalleMovimiento.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarDetalleMovimiento.Location = new System.Drawing.Point(421, 361);
            this.btnAgregarDetalleMovimiento.Name = "btnAgregarDetalleMovimiento";
            this.btnAgregarDetalleMovimiento.Size = new System.Drawing.Size(175, 32);
            this.btnAgregarDetalleMovimiento.TabIndex = 2;
            this.btnAgregarDetalleMovimiento.Text = "Agregar a detalle";
            this.btnAgregarDetalleMovimiento.UseVisualStyleBackColor = false;
            this.btnAgregarDetalleMovimiento.Click += new System.EventHandler(this.btnAgregarDetalleMovimiento_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dgvDetallesMovimientos);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(9, 411);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1250, 295);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // dgvDetallesMovimientos
            // 
            this.dgvDetallesMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_detalle,
            this.id_movimiento,
            this.nombre_producto,
            this.id_producto,
            this.nombre_bodega,
            this.id_bodega,
            this.fecha_vencimiento,
            this.lote,
            this.cantidad,
            this.costo_unitario,
            this.costo_unitario_promedio,
            this.existencia_anterior,
            this.existencia_total,
            this.descripcion_estado,
            this.estado});
            this.dgvDetallesMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetallesMovimientos.Location = new System.Drawing.Point(3, 16);
            this.dgvDetallesMovimientos.Name = "dgvDetallesMovimientos";
            this.dgvDetallesMovimientos.Size = new System.Drawing.Size(1244, 276);
            this.dgvDetallesMovimientos.TabIndex = 0;
            // 
            // btnCrearMovimiento
            // 
            this.btnCrearMovimiento.BackColor = System.Drawing.Color.White;
            this.btnCrearMovimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearMovimiento.ForeColor = System.Drawing.Color.Black;
            this.btnCrearMovimiento.Location = new System.Drawing.Point(521, 738);
            this.btnCrearMovimiento.Name = "btnCrearMovimiento";
            this.btnCrearMovimiento.Size = new System.Drawing.Size(75, 32);
            this.btnCrearMovimiento.TabIndex = 18;
            this.btnCrearMovimiento.Text = "Agregar";
            this.btnCrearMovimiento.UseVisualStyleBackColor = false;
            this.btnCrearMovimiento.Click += new System.EventHandler(this.btnCrearMovimiento_Click);
            // 
            // btnCancelarMovimiento
            // 
            this.btnCancelarMovimiento.BackColor = System.Drawing.Color.White;
            this.btnCancelarMovimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMovimiento.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarMovimiento.Location = new System.Drawing.Point(681, 738);
            this.btnCancelarMovimiento.Name = "btnCancelarMovimiento";
            this.btnCancelarMovimiento.Size = new System.Drawing.Size(75, 32);
            this.btnCancelarMovimiento.TabIndex = 1;
            this.btnCancelarMovimiento.Text = "Cancelar";
            this.btnCancelarMovimiento.UseVisualStyleBackColor = false;
            this.btnCancelarMovimiento.Click += new System.EventHandler(this.btnCancelarMovimiento_Click);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.BackColor = System.Drawing.Color.White;
            this.btnEliminarDetalle.Enabled = false;
            this.btnEliminarDetalle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetalle.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(649, 361);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(175, 32);
            this.btnEliminarDetalle.TabIndex = 19;
            this.btnEliminarDetalle.Text = "Eliminar detalle";
            this.btnEliminarDetalle.UseVisualStyleBackColor = false;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // id_detalle
            // 
            this.id_detalle.HeaderText = "Numero de detalle";
            this.id_detalle.Name = "id_detalle";
            this.id_detalle.ReadOnly = true;
            // 
            // id_movimiento
            // 
            this.id_movimiento.HeaderText = "Número de Movimiento";
            this.id_movimiento.Name = "id_movimiento";
            this.id_movimiento.ReadOnly = true;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Producto";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "id_producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Visible = false;
            // 
            // nombre_bodega
            // 
            this.nombre_bodega.HeaderText = "Bodega";
            this.nombre_bodega.Name = "nombre_bodega";
            this.nombre_bodega.ReadOnly = true;
            // 
            // id_bodega
            // 
            this.id_bodega.HeaderText = "id_bodega";
            this.id_bodega.Name = "id_bodega";
            this.id_bodega.ReadOnly = true;
            this.id_bodega.Visible = false;
            // 
            // fecha_vencimiento
            // 
            this.fecha_vencimiento.HeaderText = "Fecha de Vencimiento";
            this.fecha_vencimiento.Name = "fecha_vencimiento";
            this.fecha_vencimiento.ReadOnly = true;
            // 
            // lote
            // 
            this.lote.HeaderText = "Número de Lote";
            this.lote.Name = "lote";
            this.lote.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // costo_unitario
            // 
            this.costo_unitario.HeaderText = "Costo Unitario";
            this.costo_unitario.Name = "costo_unitario";
            this.costo_unitario.ReadOnly = true;
            // 
            // costo_unitario_promedio
            // 
            this.costo_unitario_promedio.HeaderText = "Costo Unitario Promedio";
            this.costo_unitario_promedio.Name = "costo_unitario_promedio";
            this.costo_unitario_promedio.ReadOnly = true;
            // 
            // existencia_anterior
            // 
            this.existencia_anterior.HeaderText = "Existencia Anterior";
            this.existencia_anterior.Name = "existencia_anterior";
            this.existencia_anterior.ReadOnly = true;
            // 
            // existencia_total
            // 
            this.existencia_total.HeaderText = "Existencia Total";
            this.existencia_total.Name = "existencia_total";
            this.existencia_total.ReadOnly = true;
            // 
            // descripcion_estado
            // 
            this.descripcion_estado.HeaderText = "Estado";
            this.descripcion_estado.Name = "descripcion_estado";
            this.descripcion_estado.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // FormCrearMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 795);
            this.Controls.Add(this.btnEliminarDetalle);
            this.Controls.Add(this.btnCrearMovimiento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAgregarDetalleMovimiento);
            this.Controls.Add(this.btnCancelarMovimiento);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrearMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Movimiento";
            this.Load += new System.EventHandler(this.FormCrearMovimiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroMovimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarDetalleMovimiento;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTipoMovimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBodega;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtVentaTotalSinIva;
        private System.Windows.Forms.TextBox txtVentaTotalConIva;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cmbAuxiliar;
        private System.Windows.Forms.Label lblAuxiliar;
        private System.Windows.Forms.Button btnCrearMovimiento;
        private System.Windows.Forms.Button btnCancelarMovimiento;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtTemperaturaPromedio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCapacidadActual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCapacidadMaxima;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvDetallesMovimientos;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_unitario_promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia_anterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}