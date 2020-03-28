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
            Application.Exit();
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
        private void nuevaBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormTipoBodega tipobodega = new FormTipoBodega();
            tipobodega.FormClosed += new FormClosedEventHandler(frmProducto_FormClosed);
            tipobodega.MdiParent = this;
            tipobodega.Show();
            

        
        }

        private void registroSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSucursal frmsu = new FormSucursal();
            frmsu.FormClosed += new FormClosedEventHandler(frmProducto_FormClosed);
            frmsu.MdiParent = this;
            frmsu.Show();
        }
    }
}
