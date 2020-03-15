
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
    public partial class FormEditarProducto : DevComponents.DotNetBar.Metro.MetroForm
    {
        private int idProducto;
        public FormEditarProducto(int id)
        {
            InitializeComponent();
            idProducto = id;
        }

        private void FormEditarProducto_Load(object sender, EventArgs e)
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

            //lleno datos
            productos producto = ProductoBL.ObtenerIdProducto(idProducto);
            txtNombreProducto.Text = producto.nombre;
            txtDescripcionProducto.Text = producto.descripcion;
            txtCodigoProducto.Text = producto.codigo;
            cbxProveedor.SelectedIndex = Convert.ToInt32(producto.id_proveedor);
           // cbxCategoria.SelectedIndex = Convert.ToInt32(producto.id_clasificaciones);
            cbxSubCategoria.SelectedIndex = Convert.ToInt32(producto.id_sub_clasificacion);
            //cbxVigencia.SelectedIndex = Convert.ToInt32(producto.id_vigencia_promedio);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            productos producto = new productos();
            producto.nombre = txtNombreProducto.Text;
            producto.codigo = txtCodigoProducto.Text;
            producto.descripcion = txtDescripcionProducto.Text;
            producto.id_vigencia_promedio = Convert.ToInt32(cbxVigencia.SelectedValue);
            producto.id_sub_clasificacion = Convert.ToInt32(cbxSubCategoria.SelectedValue);
            producto.id_proveedor = Convert.ToInt32(cbxProveedor.SelectedValue);
            ProductoBL.EditarProducto(producto);
            MessageBox.Show("Producto Editado Correctamente", "Registro Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
