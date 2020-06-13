namespace Sistema_Inventario
{
    partial class FormEditarTipoBodega
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditarTipoBodega = new System.Windows.Forms.Button();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(357, 178);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 28);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEditarTipoBodega
            // 
            this.BtnEditarTipoBodega.Location = new System.Drawing.Point(94, 178);
            this.BtnEditarTipoBodega.Name = "BtnEditarTipoBodega";
            this.BtnEditarTipoBodega.Size = new System.Drawing.Size(121, 28);
            this.BtnEditarTipoBodega.TabIndex = 9;
            this.BtnEditarTipoBodega.Text = "Guardar";
            this.BtnEditarTipoBodega.UseVisualStyleBackColor = true;
            this.BtnEditarTipoBodega.Click += new System.EventHandler(this.BtnEditarTipoBodega_Click);
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(94, 98);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(384, 22);
            this.TxtTipo.TabIndex = 8;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(12, 98);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(40, 17);
            this.Tipo.TabIndex = 12;
            this.Tipo.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo de Bodega";
            // 
            // FormEditarTipoBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 311);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEditarTipoBodega);
            this.Controls.Add(this.TxtTipo);
            this.Name = "FormEditarTipoBodega";
            this.Text = "Editar Tipo de Bodega";
            this.Load += new System.EventHandler(this.FormEditarTipoBodega_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEditarTipoBodega;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label label3;
    }
}