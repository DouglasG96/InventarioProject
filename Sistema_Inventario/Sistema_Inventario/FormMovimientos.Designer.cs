namespace Sistema_Inventario
{
    partial class FormMovimientos
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
            this.dtgMovimientos = new System.Windows.Forms.DataGridView();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbDescartes = new System.Windows.Forms.RadioButton();
            this.rdbTraslados = new System.Windows.Forms.RadioButton();
            this.rdbSalidas = new System.Windows.Forms.RadioButton();
            this.rdbEntradas = new System.Windows.Forms.RadioButton();
            this.btnBuscarMovimientos = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnAgregarMovmiento = new System.Windows.Forms.Button();
            this.btnEditarMovimiento = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.id_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_total_con_iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_total_sin_iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovimientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgMovimientos
            // 
            this.dtgMovimientos.AllowUserToAddRows = false;
            this.dtgMovimientos.AllowUserToDeleteRows = false;
            this.dtgMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_movimiento,
            this.tipo_movimiento,
            this.fecha,
            this.hora,
            this.descripcion,
            this.costo_total_con_iva,
            this.costo_total_sin_iva,
            this.usuario,
            this.id_proveedor,
            this.estado});
            this.dtgMovimientos.Location = new System.Drawing.Point(3, 154);
            this.dtgMovimientos.Name = "dtgMovimientos";
            this.dtgMovimientos.ReadOnly = true;
            this.dtgMovimientos.RowHeadersVisible = false;
            this.dtgMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMovimientos.Size = new System.Drawing.Size(870, 251);
            this.dtgMovimientos.TabIndex = 0;
            this.dtgMovimientos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellContentDoubleClick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rdbTodos);
            this.groupBox1.Controls.Add(this.rdbDescartes);
            this.groupBox1.Controls.Add(this.rdbTraslados);
            this.groupBox1.Controls.Add(this.rdbSalidas);
            this.groupBox1.Controls.Add(this.rdbEntradas);
            this.groupBox1.Controls.Add(this.btnBuscarMovimientos);
            this.groupBox1.Controls.Add(this.txtBuscarProducto);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Movimientos";
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(764, 74);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 7;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbDescartes
            // 
            this.rdbDescartes.AutoSize = true;
            this.rdbDescartes.Location = new System.Drawing.Point(578, 74);
            this.rdbDescartes.Name = "rdbDescartes";
            this.rdbDescartes.Size = new System.Drawing.Size(73, 17);
            this.rdbDescartes.TabIndex = 6;
            this.rdbDescartes.TabStop = true;
            this.rdbDescartes.Text = "Descartes";
            this.rdbDescartes.UseVisualStyleBackColor = true;
            // 
            // rdbTraslados
            // 
            this.rdbTraslados.AutoSize = true;
            this.rdbTraslados.Location = new System.Drawing.Point(408, 74);
            this.rdbTraslados.Name = "rdbTraslados";
            this.rdbTraslados.Size = new System.Drawing.Size(71, 17);
            this.rdbTraslados.TabIndex = 5;
            this.rdbTraslados.TabStop = true;
            this.rdbTraslados.Text = "Traslados";
            this.rdbTraslados.UseVisualStyleBackColor = true;
            // 
            // rdbSalidas
            // 
            this.rdbSalidas.AutoSize = true;
            this.rdbSalidas.Location = new System.Drawing.Point(225, 74);
            this.rdbSalidas.Name = "rdbSalidas";
            this.rdbSalidas.Size = new System.Drawing.Size(59, 17);
            this.rdbSalidas.TabIndex = 4;
            this.rdbSalidas.TabStop = true;
            this.rdbSalidas.Text = "Salidas";
            this.rdbSalidas.UseVisualStyleBackColor = true;
            // 
            // rdbEntradas
            // 
            this.rdbEntradas.AutoSize = true;
            this.rdbEntradas.Location = new System.Drawing.Point(51, 74);
            this.rdbEntradas.Name = "rdbEntradas";
            this.rdbEntradas.Size = new System.Drawing.Size(67, 17);
            this.rdbEntradas.TabIndex = 3;
            this.rdbEntradas.TabStop = true;
            this.rdbEntradas.Text = "Entradas";
            this.rdbEntradas.UseVisualStyleBackColor = true;
            // 
            // btnBuscarMovimientos
            // 
            this.btnBuscarMovimientos.BackColor = System.Drawing.Color.White;
            this.btnBuscarMovimientos.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarMovimientos.Location = new System.Drawing.Point(488, 19);
            this.btnBuscarMovimientos.Name = "btnBuscarMovimientos";
            this.btnBuscarMovimientos.Size = new System.Drawing.Size(75, 33);
            this.btnBuscarMovimientos.TabIndex = 2;
            this.btnBuscarMovimientos.Text = "Buscar";
            this.btnBuscarMovimientos.UseVisualStyleBackColor = false;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.White;
            this.txtBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarProducto.Location = new System.Drawing.Point(369, 25);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarProducto.TabIndex = 1;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.White;
            this.lblProducto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Black;
            this.lblProducto.Location = new System.Drawing.Point(267, 30);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(82, 15);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Movimientos:";
            // 
            // btnAgregarMovmiento
            // 
            this.btnAgregarMovmiento.BackColor = System.Drawing.Color.White;
            this.btnAgregarMovmiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMovmiento.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarMovmiento.Location = new System.Drawing.Point(210, 421);
            this.btnAgregarMovmiento.Name = "btnAgregarMovmiento";
            this.btnAgregarMovmiento.Size = new System.Drawing.Size(108, 39);
            this.btnAgregarMovmiento.TabIndex = 2;
            this.btnAgregarMovmiento.Text = "Agregar Movimiento";
            this.btnAgregarMovmiento.UseVisualStyleBackColor = false;
            this.btnAgregarMovmiento.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEditarMovimiento
            // 
            this.btnEditarMovimiento.BackColor = System.Drawing.Color.White;
            this.btnEditarMovimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMovimiento.ForeColor = System.Drawing.Color.Black;
            this.btnEditarMovimiento.Location = new System.Drawing.Point(363, 421);
            this.btnEditarMovimiento.Name = "btnEditarMovimiento";
            this.btnEditarMovimiento.Size = new System.Drawing.Size(101, 39);
            this.btnEditarMovimiento.TabIndex = 3;
            this.btnEditarMovimiento.Text = "Editar Movimiento";
            this.btnEditarMovimiento.UseVisualStyleBackColor = false;
            this.btnEditarMovimiento.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarProducto.Location = new System.Drawing.Point(520, 421);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(107, 39);
            this.btnEliminarProducto.TabIndex = 4;
            this.btnEliminarProducto.Text = "Eliminar Movimiento";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // id_movimiento
            // 
            this.id_movimiento.DataPropertyName = "id_movimiento";
            this.id_movimiento.HeaderText = "Numero de Movimiento";
            this.id_movimiento.Name = "id_movimiento";
            this.id_movimiento.ReadOnly = true;
            this.id_movimiento.Width = 50;
            // 
            // tipo_movimiento
            // 
            this.tipo_movimiento.DataPropertyName = "tipo_movimiento";
            this.tipo_movimiento.HeaderText = "Tipo Movimiento";
            this.tipo_movimiento.Name = "tipo_movimiento";
            this.tipo_movimiento.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 60;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // costo_total_con_iva
            // 
            this.costo_total_con_iva.DataPropertyName = "costo_total_con_iva";
            this.costo_total_con_iva.HeaderText = "Costo Total con IVA";
            this.costo_total_con_iva.Name = "costo_total_con_iva";
            this.costo_total_con_iva.ReadOnly = true;
            this.costo_total_con_iva.Width = 75;
            // 
            // costo_total_sin_iva
            // 
            this.costo_total_sin_iva.DataPropertyName = "costo_total_sin_iva";
            this.costo_total_sin_iva.HeaderText = "Costo Total sin IVA";
            this.costo_total_sin_iva.Name = "costo_total_sin_iva";
            this.costo_total_sin_iva.ReadOnly = true;
            this.costo_total_sin_iva.Width = 130;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 75;
            // 
            // id_proveedor
            // 
            this.id_proveedor.DataPropertyName = "nombre";
            this.id_proveedor.HeaderText = "Proveedor";
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.ReadOnly = true;
            this.id_proveedor.Width = 75;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // FormMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 472);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnEditarMovimiento);
            this.Controls.Add(this.btnAgregarMovmiento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgMovimientos);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProducto_FormClosed);
            this.Load += new System.EventHandler(this.FormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovimientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMovimientos;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarMovimientos;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnAgregarMovmiento;
        private System.Windows.Forms.Button btnEditarMovimiento;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbDescartes;
        private System.Windows.Forms.RadioButton rdbTraslados;
        private System.Windows.Forms.RadioButton rdbSalidas;
        private System.Windows.Forms.RadioButton rdbEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_total_con_iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_total_sin_iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}