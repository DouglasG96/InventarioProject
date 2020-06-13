using DevComponents.DotNetBar.Metro;
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
    public partial class FormEditarProveedor : MetroForm
    {
        private int idProveedor;
        public FormEditarProveedor(int id)
        {
            InitializeComponent();
            idProveedor = id;
        }

        private void FormEditarProveedor_Load(object sender, EventArgs e)
        {
            //cargo combox
            cbxTipoProveedor.DataSource = TipoProveedorBL.CargarTipoProveedoOpcional();
            cbxTipoProveedor.DisplayMember = "tipo_proveedor1";
            cbxTipoProveedor.ValueMember = "id_tipo_proveedor";


            //lleno datos
            proveedores proveedor = ProveedorBL.DetalleProveedor(idProveedor);
            txtNombreProveedor.Text = proveedor.nombre;
            txtCorreoProveedor.Text = proveedor.correo;
            txtDireccionProveedor.Text = proveedor.direccion;
            txtNitProveedor.Text = proveedor.nit;
            txtNrcProveedor.Text = proveedor.nrc;
            txtRazonProveedor.Text = proveedor.razon_social;
            cbxTipoProveedor.SelectedIndex = Convert.ToInt32(proveedor.id_tipo_proveedor);
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                proveedores proveedor = new proveedores();
                proveedor.id_proveedor = idProveedor;
                proveedor.nombre = txtNombreProveedor.Text;
                proveedor.direccion = txtDireccionProveedor.Text;
                proveedor.nit = txtNitProveedor.Text;
                proveedor.nrc = txtNrcProveedor.Text;
                proveedor.correo = txtCorreoProveedor.Text;
                proveedor.razon_social = txtRazonProveedor.Text;
                proveedor.id_tipo_proveedor = Convert.ToInt32(cbxTipoProveedor.SelectedValue);
                ProveedorBL.EditarProveedor(proveedor);
                MessageBox.Show("Proveedor Editado Correctamente", "Registro Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
