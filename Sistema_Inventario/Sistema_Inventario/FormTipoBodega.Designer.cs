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
            this.label4 = new System.Windows.Forms.Label();
            this.rdbactivo = new System.Windows.Forms.RadioButton();
            this.rdbinactivo = new System.Windows.Forms.RadioButton();
            this.BtnGuardarTipoBodega = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de Bodega";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(98, 90);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(40, 17);
            this.Tipo.TabIndex = 1;
            this.Tipo.Text = "Tipo:";
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(206, 90);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(384, 22);
            this.TxtTipo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // rdbactivo
            // 
            this.rdbactivo.AutoSize = true;
            this.rdbactivo.Checked = true;
            this.rdbactivo.Location = new System.Drawing.Point(206, 158);
            this.rdbactivo.Name = "rdbactivo";
            this.rdbactivo.Size = new System.Drawing.Size(67, 21);
            this.rdbactivo.TabIndex = 1;
            this.rdbactivo.TabStop = true;
            this.rdbactivo.Text = "Activo";
            this.rdbactivo.UseVisualStyleBackColor = true;
            // 
            // rdbinactivo
            // 
            this.rdbinactivo.AutoSize = true;
            this.rdbinactivo.Location = new System.Drawing.Point(365, 158);
            this.rdbinactivo.Name = "rdbinactivo";
            this.rdbinactivo.Size = new System.Drawing.Size(77, 21);
            this.rdbinactivo.TabIndex = 2;
            this.rdbinactivo.Text = "Inactivo";
            this.rdbinactivo.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarTipoBodega
            // 
            this.BtnGuardarTipoBodega.Location = new System.Drawing.Point(206, 237);
            this.BtnGuardarTipoBodega.Name = "BtnGuardarTipoBodega";
            this.BtnGuardarTipoBodega.Size = new System.Drawing.Size(121, 28);
            this.BtnGuardarTipoBodega.TabIndex = 6;
            this.BtnGuardarTipoBodega.Text = "Guardar";
            this.BtnGuardarTipoBodega.UseVisualStyleBackColor = true;
            this.BtnGuardarTipoBodega.Click += new System.EventHandler(this.BtnGuardarTipoBodega_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(388, 237);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 28);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FormTipoBodega
            // 
            this.ClientSize = new System.Drawing.Size(653, 354);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardarTipoBodega);
            this.Controls.Add(this.rdbinactivo);
            this.Controls.Add(this.rdbactivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.label3);
            this.Name = "FormTipoBodega";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbactivo;
        private System.Windows.Forms.RadioButton rdbinactivo;
        private System.Windows.Forms.Button BtnGuardarTipoBodega;
        private System.Windows.Forms.Button BtnCancelar;
    }
}