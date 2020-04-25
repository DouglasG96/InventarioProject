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

namespace Sistema_Inventario
{
    public partial class FormListaSucursales : DevComponents.DotNetBar.Metro.MetroForm
    {
        FormSucursal formsucursal;

        private int idRol = 0;
        public FormListaSucursales(int idrol)
        {
            InitializeComponent();
            this.idRol = idrol;
        }
        private void CargarSucursald()
        {
            dtgsucursal.AutoGenerateColumns = false;
            dtgsucursal.DataSource = SucursalBL.DetalleSucursales();
        }
        private void FormListaSucursales_Load(object sender, EventArgs e)
        {
            CargarSucursald();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (formsucursal == null)
            {
                formsucursal = new FormSucursal(idRol);
                formsucursal.FormClosed += new FormClosedEventHandler(frmeditarsucursales_FormClosed);//para actualizar datos al cerrar formulario
                formsucursal.ShowDialog();

            }
            else
            {
                formsucursal.Activate();
            }
        }

        private void frmeditarsucursales_FormClosed(object sender, FormClosedEventArgs e)
        {
            //actualizo sucursales al cerrar formulario
            CargarSucursald();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgsucursal.CurrentRow;
            int id = Convert.ToInt32(row.Cells["id_sucursal"].Value);

            FormEditarSucursal formeditarsucursal = new FormEditarSucursal(id);
            formeditarsucursal.FormClosed += new FormClosedEventHandler(frmeditarsucursales_FormClosed);//para actualizar datos al cerrar formulario
            formeditarsucursal.ShowDialog();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                DataGridViewRow row = dtgsucursal.CurrentRow;
                int id = Convert.ToInt32(row.Cells["id_sucursal"].Value);
                SucursalBL.EliminarSucursal(id);
                MessageBox.Show("Se Elimino la sucursal Con Numero ID: " + id, "Eliminar Registro");
                CargarSucursald();
            }
        }

        private void Buscar_Sucursal(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dtgsucursal.DataSource = SucursalBL.BuscarSucursal(txtBuscar.Text);
            }
            else
                CargarSucursald();
        }
    }
}
