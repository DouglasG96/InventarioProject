
using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario
{
    public partial class FormMovimientos : DevComponents.DotNetBar.Metro.MetroForm
    {
        String nombreUsuario = "";
        int numeroMovimiento = 0;
        int idUsuario = 0;
        public FormMovimientos(String nombreUsuario, int idUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.idUsuario = idUsuario;
        }

        private void cargarMovimientos()
        {
            dtgMovimientos.AutoGenerateColumns = false;
            dtgMovimientos.DataSource = MovimientosBL.cargarMovimientos();
        }

        private void FormMovimientos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            cargarMovimientos();
            cargarFiltro();
            numeroMovimiento = consultarNumeroMovimientos();
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            FormCrearMovimiento frmCrearMovimiento = new FormCrearMovimiento(nombreUsuario, numeroMovimiento, idUsuario);
            //frmCrearMovimiento.MdiParent = this;
            frmCrearMovimiento.FormClosed += new FormClosedEventHandler(frmCrearMovimiento_FormClosed);//para actualizar datos al cerrar formulario
            frmCrearMovimiento.Show();
        }

        private void frmCrearMovimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            //actualizo productos al cerrar formulario
            cargarMovimientos();
        }

        //detecto doble click para detalle
        private void dtgProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtengo id seleccionado
            DataGridViewRow row = dtgMovimientos.CurrentRow;
            int id = Convert.ToInt32(row.Cells["Id"].Value);

            FormDetalleProducto frmdetalleproducto = new FormDetalleProducto(id);
            frmdetalleproducto.ShowDialog();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            /*
            DataGridViewRow row = dtgMovimientos.CurrentRow;
            int id = Convert.ToInt32(row.Cells["Id"].Value);

            FormEditarProducto frmeditarproducto = new FormEditarProducto(id);
            frmeditarproducto.FormClosed += new FormClosedEventHandler(frmeditarMovimiento_FormClosed);//para actualizar datos al cerrar formulario
            frmeditarproducto.ShowDialog();
            */
        }

        private void frmeditarMovimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargarMovimientos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            /*
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                DataGridViewRow row = dtgMovimientos.CurrentRow;
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                ProductoBL.EliminarProducto(id);
                MessageBox.Show("Se Elimino el Producto Con Numero ID: " + id, "Eliminar Registro");
                cargarMovimientos();
            }
            */
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text != "")
            {
                dtgMovimientos.DataSource = ProductoBL.BuscarProducto(txtBuscarProducto.Text);
            }
            else
            {
                cargarMovimientos();
            }
        }

        private void cargarFiltro()
        {
            cmbFiltro.DataSource = TipoMovimientoBL.CargarTipoMovimientoSelector();
            cmbFiltro.DisplayMember = "tipo_movimiento";
            cmbFiltro.ValueMember = "id_tipo_movimiento";
        }

        private int consultarNumeroMovimientos()
        {
            return MovimientosBL.consultarNumeroMovimientos();
        }
    }
}
