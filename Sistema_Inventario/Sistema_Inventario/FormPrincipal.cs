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
    public partial class FormPrincipal : DevComponents.DotNetBar.Metro.MetroForm
    {
        FormProducto frmProducto;
        FormMovimientos formMovimientos;
        LoginBL loginBL;
        int idUsuario;
        String nombreUsuario = "";
        
        public FormPrincipal(int idUsuario)
        {
            InitializeComponent();
            timer1.Enabled = true;
            this.idUsuario = idUsuario;

            loginBL = new LoginBL();
            consultarDatosUsuario(idUsuario);
        }

        //muestro fecha y hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }

        //cierro aplicacion principal al presionar x
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loginBL.cerrarSesion(this.idUsuario))
            {
                Application.Exit();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

            if (frmProducto == null)
            {
                frmProducto = new FormProducto();
                frmProducto.FormClosed += new FormClosedEventHandler(frmProducto_FormClosed);
                frmProducto.MdiParent = this;
                frmProducto.Show();
            }
            else
                frmProducto.Activate();
        }

        //metodo para permitir abrir solo una vez form producto
        private void frmProducto_FormClosed(object sender, EventArgs e)
        {
            frmProducto = null;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes frmreportes = new FormReportes();
            frmreportes.ShowDialog();
        }

        private void consultarDatosUsuario(int idUsuario)
        {
            nombreUsuario = loginBL.consultarDatosUsuario(this.idUsuario);
            mostrarDatosUsuario(nombreUsuario);
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(loginBL.cerrarSesion(this.idUsuario))
            {
                Application.Exit();
            }
        }

        private void mostrarDatosUsuario(String nombreUsuario)
        {
            lblNombreUsuario.Text = nombreUsuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            if (formMovimientos == null)
            {
                formMovimientos = new FormMovimientos();
                formMovimientos.FormClosed += new FormClosedEventHandler(frmProducto_FormClosed);
                formMovimientos.MdiParent = this;
                formMovimientos.Show();
            }
            else
            {
                formMovimientos.Activate();
            }
        }
    }
}
