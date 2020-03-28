
using Entidades;
using Logica;
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
    public partial class FormCrearMovimiento : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormCrearMovimiento()
        {
            InitializeComponent();
        }

        private void FormCrearProducto_Load(object sender, EventArgs e)
        {
            //cargo combox

            cbxTipoMovimiento.DataSource = TipoMovimientoBL.cargarTipoMovimiento();
            cbxTipoMovimiento.DisplayMember = "tipo_movimiento1";
            cbxTipoMovimiento.ValueMember = "id_tipo_movimiento";

            cbxProveedor.DataSource = ProveedorBL.CargarProveedoresOpcional();
            cbxProveedor.DisplayMember = "nombre";
            cbxProveedor.ValueMember = "id_proveedor";

            cbxProducto.DataSource = ProductoBL.cargarProductosAll();
            cbxProducto.DisplayMember = "nombre";
            cbxProducto.ValueMember = "id_producto";

            cbxBodega.DataSource = BodegasBL.cargarBodegas();
            cbxBodega.DisplayMember = "nombre_bodega";
            cbxBodega.ValueMember = "id_bodega";
        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            /*
            productos producto = new productos();
            producto.nombre = txtNombreProducto.Text;
            producto.codigo = txtCodigoProducto.Text;
            producto.descripcion = txtDescripcionMovimiento.Text;
            producto.id_vigencia_promedio = Convert.ToInt32(cbxVigencia.SelectedValue);
            producto.id_sub_clasificacion = Convert.ToInt32(cbxSubCategoria.SelectedValue);
            producto.id_proveedor = Convert.ToInt32(cbxProveedor.SelectedValue);
            producto.fecha_creacion = DateTime.Now.Date;
            producto.hora_creacion = DateTime.Now.TimeOfDay;
            ProductoBL.CrearProducto(producto);
            MessageBox.Show("Producto Agregado Correctamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            */
        }

        private void cbxTipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
