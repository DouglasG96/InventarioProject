using Datos;
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
            cbxProveedor.DataSource = ProveedorDAL.CargarProveedoresOpcional();
            cbxProveedor.DisplayMember = "nombre";
            cbxProveedor.ValueMember = "id_proveedor";

            cbxCategoria.DataSource = CategoriaDAL.CargarCategoriasOpcional();
            cbxCategoria.DisplayMember = "nombre_clasificacion";
            cbxCategoria.ValueMember = "id_clasificacion";

            cbxSubCategoria.DataSource = SubCategoriaDAL.CargarSubCategoriasOpcional();
            cbxSubCategoria.DisplayMember = "sub_clasificacion";
            cbxSubCategoria.ValueMember = "id_sub_clasificacion";

            cbxVigencia.DataSource = VigenciaDAL.CargarVigencias();
            cbxVigencia.DisplayMember = "dias";
            cbxVigencia.ValueMember = "id_vigencia_promedio";

            //lleno datos
            productos producto = ProductosDAL.ObtenerIdProducto(idProducto);
            txtNombreProducto.Text = producto.nombre;
            txtDescripcionProducto.Text = producto.descripcion;
            txtCodigoProducto.Text = producto.codigo;
            cbxProveedor.SelectedIndex = Convert.ToInt32(producto.id_proveedor);
            cbxCategoria.SelectedIndex = Convert.ToInt32(producto.id_clasificacion);
            cbxSubCategoria.SelectedIndex = Convert.ToInt32(producto.id_sub_clasificacion);
            cbxVigencia.SelectedItem = Convert.ToInt32(producto.id_vigencia_promedio);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ProductosDAL.EditarProducto(idProducto,txtNombreProducto.Text, txtCodigoProducto.Text, txtDescripcionProducto.Text, Convert.ToInt32(cbxVigencia.SelectedValue), Convert.ToInt32(cbxCategoria.SelectedValue), Convert.ToInt32(cbxProveedor.SelectedValue));
            MessageBox.Show("Producto Editado Correctamente", "Registro Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
