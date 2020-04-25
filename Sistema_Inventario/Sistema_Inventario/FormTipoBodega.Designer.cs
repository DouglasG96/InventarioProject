namespace Sistema_Inventario
{
    partial class FormTipoBodega
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
            this.label3 = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.BtnGuardarTipoBodega = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.dtwtipobodega = new System.Windows.Forms.DataGridView();
            this.Id_tipo_Bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtxBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtwtipobodega)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de Bodega";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(39, 52);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(40, 17);
            this.Tipo.TabIndex = 1;
            this.Tipo.Text = "Tipo:";
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(101, 52);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(384, 22);
            this.TxtTipo.TabIndex = 2;
            // 
            // BtnGuardarTipoBodega
            // 
            this.BtnGuardarTipoBodega.Location = new System.Drawing.Point(101, 97);
            this.BtnGuardarTipoBodega.Name = "BtnGuardarTipoBodega";
            this.BtnGuardarTipoBodega.Size = new System.Drawing.Size(121, 28);
            this.BtnGuardarTipoBodega.TabIndex = 6;
            this.BtnGuardarTipoBodega.Text = "Guardar";
            this.BtnGuardarTipoBodega.UseVisualStyleBackColor = true;
            this.BtnGuardarTipoBodega.Click += new System.EventHandler(this.BtnGuardarTipoBodega_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(364, 97);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 28);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // dtwtipobodega
            // 
            this.dtwtipobodega.AllowUserToAddRows = false;
            this.dtwtipobodega.AllowUserToDeleteRows = false;
            this.dtwtipobodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwtipobodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_tipo_Bodega,
            this.Tipo_bodega});
            this.dtwtipobodega.Location = new System.Drawing.Point(101, 215);
            this.dtwtipobodega.Name = "dtwtipobodega";
            this.dtwtipobodega.ReadOnly = true;
            this.dtwtipobodega.RowTemplate.Height = 24;
            this.dtwtipobodega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtwtipobodega.Size = new System.Drawing.Size(384, 150);
            this.dtwtipobodega.TabIndex = 8;
            // 
            // Id_tipo_Bodega
            // 
            this.Id_tipo_Bodega.DataPropertyName = "id_tipo_bodega";
            this.Id_tipo_Bodega.HeaderText = "Id";
            this.Id_tipo_Bodega.Name = "Id_tipo_Bodega";
            this.Id_tipo_Bodega.ReadOnly = true;
            // 
            // Tipo_bodega
            // 
            this.Tipo_bodega.DataPropertyName = "tipo";
            this.Tipo_bodega.HeaderText = "Tipo bodega";
            this.Tipo_bodega.Name = "Tipo_bodega";
            this.Tipo_bodega.ReadOnly = true;
            // 
            // TxtxBuscar
            // 
            this.TxtxBuscar.Location = new System.Drawing.Point(101, 179);
            this.TxtxBuscar.Name = "TxtxBuscar";
            this.TxtxBuscar.Size = new System.Drawing.Size(384, 22);
            this.TxtxBuscar.TabIndex = 9;
            this.TxtxBuscar.TextChanged += new System.EventHandler(this.buscar_tipo_bodega);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Buscar:";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(410, 382);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(101, 382);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 12;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // FormTipoBodega
            // 
            this.ClientSize = new System.Drawing.Size(608, 415);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtxBuscar);
            this.Controls.Add(this.dtwtipobodega);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardarTipoBodega);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Name = "FormTipoBodega";
            this.Load += new System.EventHandler(this.FormTipoBodega_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtwtipobodega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Button BtnGuardarTipoBodega;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridView dtwtipobodega;
        private System.Windows.Forms.TextBox TxtxBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_tipo_Bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_bodega;
    }
}