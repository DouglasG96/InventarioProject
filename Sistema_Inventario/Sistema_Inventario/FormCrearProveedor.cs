using DevComponents.DotNetBar.Metro;
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
using Logica;
using Entidades;

namespace Sistema_Inventario
{
    public partial class FormCrearProveedor : MetroForm
    {
        public FormCrearProveedor()
        {
            InitializeComponent();
        }

        private void FormCrearProveedor_Load(object sender, EventArgs e)
        {
            //cargo combox
            cbxTipoProveedor.DataSource = TipoProveedorBL.CargarTipoProveedoOpcional();
            cbxTipoProveedor.DisplayMember = "tipo_proveedor1";
            cbxTipoProveedor.ValueMember = "id_tipo_proveedor";
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                proveedores proveedor = new proveedores();
                proveedor.nombre = txtNombreProveedor.Text;
                proveedor.direccion = txtDireccionProveedor.Text;
                proveedor.nit = txtNitProveedor.Text;
                proveedor.nrc = txtNrcProveedor.Text;
                proveedor.correo = txtCorreoProveedor.Text;
                proveedor.razon_social = txtRazonProveedor.Text;
                proveedor.id_tipo_proveedor = Convert.ToInt32(cbxTipoProveedor.SelectedValue);
                ProveedorBL.CrearProveedor(proveedor);
                MessageBox.Show("Proveedor Agregado Correctamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: "+error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
