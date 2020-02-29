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
    public partial class FormPrincipal : DevComponents.DotNetBar.Metro.MetroForm
    {
        FormProducto frmProducto;
        public FormPrincipal()
        {
            InitializeComponent();
            timer1.Enabled = true;
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
    }
}
