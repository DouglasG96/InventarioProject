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

namespace Sistema_Inventario
{
    public partial class FormProveedor : MetroForm
    {
        public FormProveedor()
        {
            InitializeComponent();
        }

        private void CargarProveedores()
        {
            dtgProveedores.AutoGenerateColumns = false;
            dtgProveedores.DataSource = ProveedorBL.CargarProveedores();
        }
        private void FormProveedor_Load(object sender, EventArgs e)
        {
            CargarProveedores();

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (txtBuscarProveedor.Text != "")
            {
                dtgProveedores.DataSource = ProveedorBL.BuscarProveedor(txtBuscarProveedor.Text);
            }
            else
                CargarProveedores();
        }

        private void FormProveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarProveedores();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FormCrearProveedor frmcrearproveedor= new FormCrearProveedor();
            frmcrearproveedor.FormClosed += new FormClosedEventHandler(frmcrearproveedor_FormClosed);//para actualizar datos al cerrar formulario
            frmcrearproveedor.ShowDialog();
        }

        private void frmcrearproveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            //actualizoal cerrar formulario
            CargarProveedores();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    DataGridViewRow row = dtgProveedores.CurrentRow;
                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    ProveedorBL.EliminarProveedor(id);
                    MessageBox.Show("Se Elimino el Proveedor Con Numero ID: " + id, "Eliminar Registro");
                    CargarProveedores();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
