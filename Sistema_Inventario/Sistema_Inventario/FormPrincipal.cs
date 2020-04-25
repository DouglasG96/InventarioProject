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
        FormCategoria frmCategoria;
        FormUsuarios formUsuario;
        FormTipoBodega formTipoBodega;
        FormBodega formBodega;
        FormMovimientos formMovimientos;
        FormProveedor frmproveedor;
        FormSucursal frmsucursal;
        FormListaSucursales frmListaSucursales;
        LoginBL loginBL;
        int idUsuario;
        int idRol;
        String nombreUsuario = "";
        
        public FormPrincipal(int idUsuario, int idrol)
        {
            InitializeComponent();
            timer1.Enabled = true;
            this.idUsuario = idUsuario;
            this.idRol = idrol;


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
            //valido si no esta abierto el form para solo abrir 1
            if (frmProducto == null)
            {
                frmProducto = new FormProducto(idRol);
                frmProducto.FormClosed += new FormClosedEventHandler(frmProducto_FormClosed);
                frmProducto.MdiParent = this;
                frmProducto.Show();
            }
            //si esta activo solo lo muestro
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

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmProducto == null)
            {
                frmProducto = new FormProducto(idRol);
                frmProducto.FormClosed += new FormClosedEventHandler(frmProducto_FormClosed);
                frmProducto.MdiParent = this;
                frmProducto.Show();
            }
            else
                frmProducto.Activate();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //valido si no esta abierto el form para solo abrir 1
            if (frmCategoria == null)
            {
                frmCategoria = new FormCategoria();
                frmCategoria.FormClosed += new FormClosedEventHandler(frmCategoria_FormClosed);
                frmCategoria.MdiParent = this;
                frmCategoria.Show();
            }
            else
                frmCategoria.Activate();
        }

        private void frmCategoria_FormClosed(object sender, EventArgs e)
        {
            frmCategoria = null;
        }

        private void btnBodegas_Click(object sender, EventArgs e)
        {
            if (formBodega == null)
            {
                formBodega = new FormBodega();
                formBodega.MdiParent = this;
                formBodega.Show();
            }
            else
            {
                formBodega.Activate();
            }
        }
        private void formBodega_FormClosed(object sender, EventArgs e)
        {
            formBodega = null;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idRol == 1)
            {
                if (formUsuario == null)
                {
                    formUsuario = new FormUsuarios();
                    formUsuario.FormClosed += new FormClosedEventHandler(frmUsuarios_FormClosed);
                    formUsuario.MdiParent = this;
                    formUsuario.Show();
                }
                else
                {
                    formUsuario.Activate();
                }
            }
            else
            {
                MessageBox.Show("Usted no tiene permiso para ejecutar esta opción", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUsuarios_FormClosed(object sender, EventArgs e)
        {
            formUsuario = null;
        }

        private void tiposDeBodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formTipoBodega == null)
            {
                formTipoBodega = new FormTipoBodega();
                formTipoBodega.FormClosed += new FormClosedEventHandler(formTipoBodega_FormClosed);
                formTipoBodega.MdiParent = this;
                formTipoBodega.Show();
            }
            else
            {
                formTipoBodega.Activate();
            }
        }

        private void formTipoBodega_FormClosed(object sender, EventArgs e)
        {
            formTipoBodega = null;
        }

        private void historialMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formMovimientos == null)
            {
                formMovimientos = new FormMovimientos(nombreUsuario, idUsuario);
                formMovimientos.FormClosed += new FormClosedEventHandler(formMovimientos_FormClosed);
                formMovimientos.MdiParent = this;
                formMovimientos.Show();
            }
            else
            {
                formMovimientos.Activate();
            }
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            if (formMovimientos == null)
            {
                formMovimientos = new FormMovimientos(nombreUsuario, idUsuario);
                formMovimientos.FormClosed += new FormClosedEventHandler(formMovimientos_FormClosed);
                formMovimientos.MdiParent = this;
                formMovimientos.Show();
            }
            else
            {
                formMovimientos.Activate();
            }
        }

        private void formMovimientos_FormClosed(object sender, EventArgs e)
        {
            formMovimientos = null;
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //valido si no esta abierto el form para solo abrir 1
            if (frmproveedor == null)
            {
                frmproveedor = new FormProveedor();
                frmproveedor.FormClosed += new FormClosedEventHandler(frmproveedor_FormClosed);
                frmproveedor.MdiParent = this;
                frmproveedor.Show();
            }
            //si esta activo solo lo muestro
            else
                frmProducto.Activate();
        }
        private void frmproveedor_FormClosed(object sender, EventArgs e)
        {
            frmproveedor = null;
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idRol == 1)
            {
                //valido si no esta abierto el form para solo abrir 1
                if (frmsucursal == null)
                {
                    frmsucursal = new FormSucursal(idRol);
                    frmsucursal.FormClosed += new FormClosedEventHandler(frmsucursal_FormClosed);
                    frmsucursal.MdiParent = this;
                    frmsucursal.Show();
                }
                //si esta activo solo lo muestro
                else
                    frmsucursal.Activate();
            }
            else
            {
                MessageBox.Show("Usted no tiene permiso para registrar", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmsucursal_FormClosed(object sender, EventArgs e)
        {
            frmsucursal = null;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (idRol == 2)
            {
                mantenimientosToolStripMenuItem.Enabled = false;
            }
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            //aqui va el formulario de lista de sucursales
            if (frmListaSucursales == null)
            {
                frmListaSucursales = new FormListaSucursales(idRol);
                frmListaSucursales.FormClosed += new FormClosedEventHandler(frmListaSucursales_FormClosed);
                frmListaSucursales.MdiParent = this;
                frmListaSucursales.Show();
            }
            else
            {
                frmListaSucursales.Activate();
            }
        }
        private void frmListaSucursales_FormClosed(object sender, EventArgs e)
        {
            frmListaSucursales = null;
        }
    }
}
