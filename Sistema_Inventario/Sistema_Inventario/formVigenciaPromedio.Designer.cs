namespace CrudVigenciaPromedio
{
    partial class FmVigenciaPromedio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdVigenciaPromedio = new System.Windows.Forms.TextBox();
            this.btnConsultarVP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertarVP = new System.Windows.Forms.Button();
            this.btnModificarVP = new System.Windows.Forms.Button();
            this.btnEliminarVP = new System.Windows.Forms.Button();
            this.btnConsultarTodos = new System.Windows.Forms.Button();
            this.dtgVigenciaPromedio = new System.Windows.Forms.DataGridView();
            this.btnConsultarActivos = new System.Windows.Forms.Button();
            this.nudEstado = new System.Windows.Forms.NumericUpDown();
            this.id_vigencia_promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVigenciaPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD VIGENCIA PROMEDIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Vigencia Promedio";
            // 
            // txtIdVigenciaPromedio
            // 
            this.txtIdVigenciaPromedio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdVigenciaPromedio.Location = new System.Drawing.Point(19, 67);
            this.txtIdVigenciaPromedio.Name = "txtIdVigenciaPromedio";
            this.txtIdVigenciaPromedio.Size = new System.Drawing.Size(348, 20);
            this.txtIdVigenciaPromedio.TabIndex = 2;
            // 
            // btnConsultarVP
            // 
            this.btnConsultarVP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarVP.Location = new System.Drawing.Point(395, 67);
            this.btnConsultarVP.Name = "btnConsultarVP";
            this.btnConsultarVP.Size = new System.Drawing.Size(152, 23);
            this.btnConsultarVP.TabIndex = 3;
            this.btnConsultarVP.Text = "Consultar";
            this.btnConsultarVP.UseVisualStyleBackColor = true;
            this.btnConsultarVP.Click += new System.EventHandler(this.btnConsultarVP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dias";
            // 
            // txtDias
            // 
            this.txtDias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDias.Location = new System.Drawing.Point(19, 106);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(348, 20);
            this.txtDias.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            // 
            // btnInsertarVP
            // 
            this.btnInsertarVP.Location = new System.Drawing.Point(19, 170);
            this.btnInsertarVP.Name = "btnInsertarVP";
            this.btnInsertarVP.Size = new System.Drawing.Size(156, 23);
            this.btnInsertarVP.TabIndex = 8;
            this.btnInsertarVP.Text = "Insertar";
            this.btnInsertarVP.UseVisualStyleBackColor = true;
            this.btnInsertarVP.Click += new System.EventHandler(this.btnInsertarVP_Click);
            // 
            // btnModificarVP
            // 
            this.btnModificarVP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarVP.Location = new System.Drawing.Point(211, 171);
            this.btnModificarVP.Name = "btnModificarVP";
            this.btnModificarVP.Size = new System.Drawing.Size(162, 23);
            this.btnModificarVP.TabIndex = 9;
            this.btnModificarVP.Text = "Modificar";
            this.btnModificarVP.UseVisualStyleBackColor = true;
            this.btnModificarVP.Click += new System.EventHandler(this.btnModificarVP_Click);
            // 
            // btnEliminarVP
            // 
            this.btnEliminarVP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarVP.Location = new System.Drawing.Point(395, 170);
            this.btnEliminarVP.Name = "btnEliminarVP";
            this.btnEliminarVP.Size = new System.Drawing.Size(152, 23);
            this.btnEliminarVP.TabIndex = 10;
            this.btnEliminarVP.Text = "Eliminar";
            this.btnEliminarVP.UseVisualStyleBackColor = true;
            this.btnEliminarVP.Click += new System.EventHandler(this.btnEliminarVP_Click);
            // 
            // btnConsultarTodos
            // 
            this.btnConsultarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarTodos.Location = new System.Drawing.Point(395, 199);
            this.btnConsultarTodos.Name = "btnConsultarTodos";
            this.btnConsultarTodos.Size = new System.Drawing.Size(152, 23);
            this.btnConsultarTodos.TabIndex = 11;
            this.btnConsultarTodos.Text = "Consultar Todos";
            this.btnConsultarTodos.UseVisualStyleBackColor = true;
            this.btnConsultarTodos.Click += new System.EventHandler(this.btnConsultarTodos_Click);
            // 
            // dtgVigenciaPromedio
            // 
            this.dtgVigenciaPromedio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVigenciaPromedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVigenciaPromedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vigencia_promedio,
            this.dias,
            this.estado});
            this.dtgVigenciaPromedio.Location = new System.Drawing.Point(19, 228);
            this.dtgVigenciaPromedio.Name = "dtgVigenciaPromedio";
            this.dtgVigenciaPromedio.Size = new System.Drawing.Size(528, 203);
            this.dtgVigenciaPromedio.TabIndex = 12;
            // 
            // btnConsultarActivos
            // 
            this.btnConsultarActivos.Location = new System.Drawing.Point(19, 199);
            this.btnConsultarActivos.Name = "btnConsultarActivos";
            this.btnConsultarActivos.Size = new System.Drawing.Size(156, 23);
            this.btnConsultarActivos.TabIndex = 13;
            this.btnConsultarActivos.Text = "Consultar Activos";
            this.btnConsultarActivos.UseVisualStyleBackColor = true;
            this.btnConsultarActivos.Click += new System.EventHandler(this.btnConsultarActivos_Click);
            // 
            // nudEstado
            // 
            this.nudEstado.Location = new System.Drawing.Point(19, 146);
            this.nudEstado.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEstado.Name = "nudEstado";
            this.nudEstado.Size = new System.Drawing.Size(156, 20);
            this.nudEstado.TabIndex = 14;
            this.nudEstado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // id_vigencia_promedio
            // 
            this.id_vigencia_promedio.DataPropertyName = "id_vigencia_promedio";
            this.id_vigencia_promedio.HeaderText = "Vigencia Promedio";
            this.id_vigencia_promedio.Name = "id_vigencia_promedio";
            this.id_vigencia_promedio.ReadOnly = true;
            // 
            // dias
            // 
            this.dias.DataPropertyName = "dias";
            this.dias.HeaderText = "Dias";
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // btnEliminados
            // 
            this.btnEliminados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminados.Location = new System.Drawing.Point(211, 200);
            this.btnEliminados.Name = "btnEliminados";
            this.btnEliminados.Size = new System.Drawing.Size(162, 23);
            this.btnEliminados.TabIndex = 15;
            this.btnEliminados.Text = "Consultar Eliminados(Inactivos)";
            this.btnEliminados.UseVisualStyleBackColor = true;
            this.btnEliminados.Click += new System.EventHandler(this.btnEliminados_Click);
            // 
            // FmVigenciaPromedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 443);
            this.Controls.Add(this.btnEliminados);
            this.Controls.Add(this.nudEstado);
            this.Controls.Add(this.btnConsultarActivos);
            this.Controls.Add(this.dtgVigenciaPromedio);
            this.Controls.Add(this.btnConsultarTodos);
            this.Controls.Add(this.btnEliminarVP);
            this.Controls.Add(this.btnModificarVP);
            this.Controls.Add(this.btnInsertarVP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsultarVP);
            this.Controls.Add(this.txtIdVigenciaPromedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(575, 482);
            this.Name = "FmVigenciaPromedio";
            this.Text = "Vigencia Promedio";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVigenciaPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdVigenciaPromedio;
        private System.Windows.Forms.Button btnConsultarVP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertarVP;
        private System.Windows.Forms.Button btnModificarVP;
        private System.Windows.Forms.Button btnEliminarVP;
        private System.Windows.Forms.Button btnConsultarTodos;
        private System.Windows.Forms.DataGridView dtgVigenciaPromedio;
        private System.Windows.Forms.Button btnConsultarActivos;
        private System.Windows.Forms.NumericUpDown nudEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vigencia_promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btnEliminados;
    }
}

