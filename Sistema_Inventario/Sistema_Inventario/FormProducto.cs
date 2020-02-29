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
  //public partial class FormProducto : Form
   public partial class FormProducto : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void CargarProductos()
        {
            dtgProductos.AutoGenerateColumns = false;
            dtgProductos.DataSource = ProductosDAL.CargarProductos();
        }

        private void FormProducto_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormCrearProducto frmcrearproducto = new FormCrearProducto();
            frmcrearproducto.FormClosed += new FormClosedEventHandler(frmcrearproducto_FormClosed);//para actualizar datos al cerrar formulario
            frmcrearproducto.ShowDialog();
        }

        private void frmcrearproducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            //actualizo productos al cerrar formulario
            CargarProductos();
        }

        //detecto doble click para detalle
        private void dtgProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtengo id seleccionado
            DataGridViewRow row = dtgProductos.CurrentRow;
            int id = Convert.ToInt32(row.Cells["Id"].Value);

            FormDetalleProducto frmdetalleproducto = new FormDetalleProducto(id);
            frmdetalleproducto.ShowDialog();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgProductos.CurrentRow;
            int id = Convert.ToInt32(row.Cells["Id"].Value);

            FormEditarProducto frmeditarproducto = new FormEditarProducto(id);
            frmeditarproducto.FormClosed += new FormClosedEventHandler(frmeditarproducto_FormClosed);//para actualizar datos al cerrar formulario
            frmeditarproducto.ShowDialog();
        }

        private void frmeditarproducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarProductos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                DataGridViewRow row = dtgProductos.CurrentRow;
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                ProductosDAL.EliminarProducto(id);
                MessageBox.Show("Se Elimino el Producto Con Numero ID: " + id, "Eliminar Registro");
                CargarProductos();
            }
        }
    }
}
