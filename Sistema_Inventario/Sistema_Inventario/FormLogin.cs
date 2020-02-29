
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario
{
    public partial class FormLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Trim().ToLower() == "admin" && txtContrasena.Text.Trim().ToLower() == "admin")
            {
                FormPrincipal form = new FormPrincipal();
                form.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Datos Inconrrectos", "Error de Inicio de Sesión ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
