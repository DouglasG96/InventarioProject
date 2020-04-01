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
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnAgregarMovimiento = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.rdbEntradas = new System.Windows.Forms.RadioButton();
            this.rdbSalidas = new System.Windows.Forms.RadioButton();
            this.rdbTraslados = new System.Windows.Forms.RadioButton();
            this.rdbDescartes = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.id_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_total_con_iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Id_Proveedor,
            this.usuario,
            this.nombre,
            this.estado});
            this.dtgMovimientos.Location = new System.Drawing.Point(3, 141);
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
            this.groupBox1.Controls.Add(this.btnBuscarProducto);
            this.groupBox1.Controls.Add(this.txtBuscarProducto);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(126, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Movimientos";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Location = new System.Drawing.Point(393, 19);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 33);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.White;
            this.txtBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarProducto.Location = new System.Drawing.Point(274, 22);
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
            this.lblProducto.Location = new System.Drawing.Point(206, 27);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(62, 15);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto:";
            // 
            // btnAgregarMovimiento
            // 
            this.btnAgregarMovimiento.BackColor = System.Drawing.Color.White;
            this.btnAgregarMovimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMovimiento.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarMovimiento.Location = new System.Drawing.Point(274, 421);
            this.btnAgregarMovimiento.Name = "btnAgregarMovimiento";
            this.btnAgregarMovimiento.Size = new System.Drawing.Size(108, 39);
            this.btnAgregarMovimiento.TabIndex = 2;
            this.btnAgregarMovimiento.Text = "Agregar Movimiento";
            this.btnAgregarMovimiento.UseVisualStyleBackColor = false;
            this.btnAgregarMovimiento.Click += new System.EventHandler(this.btnAgregarMovimiento_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.BackColor = System.Drawing.Color.White;
            this.btnEditarProducto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnEditarProducto.Location = new System.Drawing.Point(443, 421);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(101, 39);
            this.btnEditarProducto.TabIndex = 3;
            this.btnEditarProducto.Text = "Editar Movimiento";
            this.btnEditarProducto.UseVisualStyleBackColor = false;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // rdbEntradas
            // 
            this.rdbEntradas.AutoSize = true;
            this.rdbEntradas.Location = new System.Drawing.Point(25, 73);
            this.rdbEntradas.Name = "rdbEntradas";
            this.rdbEntradas.Size = new System.Drawing.Size(67, 17);
            this.rdbEntradas.TabIndex = 3;
            this.rdbEntradas.TabStop = true;
            this.rdbEntradas.Text = "Entradas";
            this.rdbEntradas.UseVisualStyleBackColor = true;
            // 
            // rdbSalidas
            // 
            this.rdbSalidas.AutoSize = true;
            this.rdbSalidas.Location = new System.Drawing.Point(148, 73);
            this.rdbSalidas.Name = "rdbSalidas";
            this.rdbSalidas.Size = new System.Drawing.Size(59, 17);
            this.rdbSalidas.TabIndex = 4;
            this.rdbSalidas.TabStop = true;
            this.rdbSalidas.Text = "Salidas";
            this.rdbSalidas.UseVisualStyleBackColor = true;
            // 
            // rdbTraslados
            // 
            this.rdbTraslados.AutoSize = true;
            this.rdbTraslados.Location = new System.Drawing.Point(274, 73);
            this.rdbTraslados.Name = "rdbTraslados";
            this.rdbTraslados.Size = new System.Drawing.Size(71, 17);
            this.rdbTraslados.TabIndex = 5;
            this.rdbTraslados.TabStop = true;
            this.rdbTraslados.Text = "Traslados";
            this.rdbTraslados.UseVisualStyleBackColor = true;
            // 
            // rdbDescartes
            // 
            this.rdbDescartes.AutoSize = true;
            this.rdbDescartes.Location = new System.Drawing.Point(393, 73);
            this.rdbDescartes.Name = "rdbDescartes";
            this.rdbDescartes.Size = new System.Drawing.Size(73, 17);
            this.rdbDescartes.TabIndex = 6;
            this.rdbDescartes.TabStop = true;
            this.rdbDescartes.Text = "Descartes";
            this.rdbDescartes.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(531, 73);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 7;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
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
            this.tipo_movimiento.HeaderText = "Tipo de Movimiento";
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
            // Id_Proveedor
            // 
            this.Id_Proveedor.DataPropertyName = "costo_total_sin_iva";
            this.Id_Proveedor.HeaderText = "Costo Total sin IVA";
            this.Id_Proveedor.Name = "Id_Proveedor";
            this.Id_Proveedor.ReadOnly = true;
            this.Id_Proveedor.Width = 130;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 75;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Proveedor";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 75;
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
            this.ClientSize = new System.Drawing.Size(877, 481);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.btnAgregarMovimiento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgMovimientos);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMovimientos_FormClosed);
            this.Load += new System.EventHandler(this.FormMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovimientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMovimientos;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnAgregarMovimiento;
        private System.Windows.Forms.Button btnEditarProducto;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}