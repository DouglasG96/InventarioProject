
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using System.Diagnostics;

namespace Sistema_Inventario
{
    public partial class FormLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        String usuario = "";
        String clave = "";
        LoginBL loginBL;
        int idUsuario;
        public FormLogin()
        {
            InitializeComponent();
            loginBL = new LoginBL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            usuario = txtUsuario.Text.Trim();
            clave = txtContrasena.Text.Trim();
            idUsuario = loginBL.validarCampos(usuario, clave);
            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (idUsuario == 0)
            {
                MessageBox.Show("Datos Inconrrectos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtContrasena.Clear();
                txtUsuario.Focus();
            }
            else if (idUsuario < 0)
            {
                MessageBox.Show("Error de conexión", "Error al conectar a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtContrasena.Clear();
                txtUsuario.Focus();
            }
            else
            {
                FormPrincipal form = new FormPrincipal(idUsuario);
                form.Show();
                this.Hide();
            }
        }
    }
}
