namespace Sistema_Inventario
{
    partial class FormPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBodegas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTraslados = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.menuMantenimientos = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasladoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesBodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuMantenimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1184, 106);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE INVENTARIO  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBodegas);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnTraslados);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 310);
            this.panel1.TabIndex = 2;
            // 
            // btnBodegas
            // 
            this.btnBodegas.BackColor = System.Drawing.Color.White;
            this.btnBodegas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBodegas.ForeColor = System.Drawing.Color.Black;
            this.btnBodegas.Location = new System.Drawing.Point(14, 238);
            this.btnBodegas.Name = "btnBodegas";
            this.btnBodegas.Size = new System.Drawing.Size(133, 39);
            this.btnBodegas.TabIndex = 3;
            this.btnBodegas.Text = "&Bodegas";
            this.btnBodegas.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(14, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Compras";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnTraslados
            // 
            this.btnTraslados.BackColor = System.Drawing.Color.White;
            this.btnTraslados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraslados.ForeColor = System.Drawing.Color.Black;
            this.btnTraslados.Location = new System.Drawing.Point(14, 98);
            this.btnTraslados.Name = "btnTraslados";
            this.btnTraslados.Size = new System.Drawing.Size(133, 39);
            this.btnTraslados.TabIndex = 1;
            this.btnTraslados.Text = "&Traslados";
            this.btnTraslados.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.White;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.Location = new System.Drawing.Point(14, 28);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(133, 39);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "&Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // menuMantenimientos
            // 
            this.menuMantenimientos.BackColor = System.Drawing.Color.White;
            this.menuMantenimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuMantenimientos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuMantenimientos.ForeColor = System.Drawing.Color.Black;
            this.menuMantenimientos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuMantenimientos.Location = new System.Drawing.Point(0, 0);
            this.menuMantenimientos.Name = "menuMantenimientos";
            this.menuMantenimientos.Size = new System.Drawing.Size(1184, 27);
            this.menuMantenimientos.TabIndex = 3;
            this.menuMantenimientos.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.bodegasToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // bodegasToolStripMenuItem
            // 
            this.bodegasToolStripMenuItem.Name = "bodegasToolStripMenuItem";
            this.bodegasToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.bodegasToolStripMenuItem.Text = "Bodegas";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem,
            this.trasladosToolStripMenuItem,
            this.trasladoDeProductosToolStripMenuItem,
            this.comprasToolStripMenuItem1});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.comprasToolStripMenuItem.Text = "Registro de Producto";
            // 
            // trasladosToolStripMenuItem
            // 
            this.trasladosToolStripMenuItem.Name = "trasladosToolStripMenuItem";
            this.trasladosToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.trasladosToolStripMenuItem.Text = "Descarga de Productos";
            // 
            // trasladoDeProductosToolStripMenuItem
            // 
            this.trasladoDeProductosToolStripMenuItem.Name = "trasladoDeProductosToolStripMenuItem";
            this.trasladoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.trasladoDeProductosToolStripMenuItem.Text = "Traslado de Productos";
            // 
            // comprasToolStripMenuItem1
            // 
            this.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
            this.comprasToolStripMenuItem1.Size = new System.Drawing.Size(219, 24);
            this.comprasToolStripMenuItem1.Text = "Compras";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesBodegasToolStripMenuItem,
            this.reportesProveedoresToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesBodegasToolStripMenuItem
            // 
            this.reportesBodegasToolStripMenuItem.Name = "reportesBodegasToolStripMenuItem";
            this.reportesBodegasToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.reportesBodegasToolStripMenuItem.Text = "Reportes Bodegas";
            // 
            // reportesProveedoresToolStripMenuItem
            // 
            this.reportesProveedoresToolStripMenuItem.Name = "reportesProveedoresToolStripMenuItem";
            this.reportesProveedoresToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.reportesProveedoresToolStripMenuItem.Text = "Reportes Proveedores";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(997, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(997, 108);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 15);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(1061, 81);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 15);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.White;
            this.lblHora.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(1061, 108);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(32, 15);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "hora";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuMantenimientos);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMantenimientos;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Inventario V1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.panel1.ResumeLayout(false);
            this.menuMantenimientos.ResumeLayout(false);
            this.menuMantenimientos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.MenuStrip menuMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasladosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasladoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesBodegasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesProveedoresToolStripMenuItem;
        private System.Windows.Forms.Button btnTraslados;
        private System.Windows.Forms.ToolStripMenuItem bodegasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.Button btnBodegas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem1;
    }
}

