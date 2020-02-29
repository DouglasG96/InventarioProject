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
    public partial class FormCrearProducto : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormCrearProducto()
        {
            InitializeComponent();
        }

        private void FormCrearProducto_Load(object sender, EventArgs e)
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
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            ProductosDAL.CrearProducto(txtNombreProducto.Text, txtCodigoProducto.Text, txtDescripcionProducto.Text, Convert.ToInt32(cbxVigencia.SelectedValue), Convert.ToInt32(cbxCategoria.SelectedValue), Convert.ToInt32(cbxProveedor.SelectedValue));
            MessageBox.Show("Producto Agregado Correctamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
