
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
    public partial class FormCrearProducto : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormCrearProducto()
        {
            InitializeComponent();
        }

        private void FormCrearProducto_Load(object sender, EventArgs e)
        {
            //cargo combox
            cbxProveedor.DataSource = ProveedorBL.CargarProveedoresOpcional();
            cbxProveedor.DisplayMember = "nombre";
            cbxProveedor.ValueMember = "id_proveedor";

            cbxCategoria.DataSource = CategoriaBL.CargarCategoriasOpcional();
            cbxCategoria.DisplayMember = "nombre_clasificacion";
            cbxCategoria.ValueMember = "id_clasificacion";

            cbxSubCategoria.DataSource = SubCategoriaBL.CargarSubCategoriasOpcional();
            cbxSubCategoria.DisplayMember = "sub_clasificacion";
            cbxSubCategoria.ValueMember = "id_sub_clasificacion";

            cbxVigencia.DataSource = VigenciaBL.CargarVigencias();
            cbxVigencia.DisplayMember = "dias";
            cbxVigencia.ValueMember = "id_vigencia_promedio";
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            productos producto = new productos();
            producto.nombre = txtNombreProducto.Text;
            producto.codigo = txtCodigoProducto.Text;
            producto.descripcion = txtDescripcionProducto.Text;
            producto.id_vigencia_promedio = Convert.ToInt32(cbxVigencia.SelectedValue);
            producto.id_sub_clasificacion = Convert.ToInt32(cbxSubCategoria.SelectedValue);
            producto.id_proveedor = Convert.ToInt32(cbxProveedor.SelectedValue);
            producto.fecha_creacion = DateTime.Now.Date;
            producto.hora_creacion = DateTime.Now.TimeOfDay;
            ProductoBL.CrearProducto(producto);
            MessageBox.Show("Producto Agregado Correctamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
