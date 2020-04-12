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
    public partial class FormCategoria : MetroForm
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void CargarCategorias()
        {
            dtgCategoria.AutoGenerateColumns = false;
            dtgCategoria.DataSource = CategoriaBL.CargarCategorias();
        }
        private void FormCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            FormCrearCategoria frmcrearcategoria = new FormCrearCategoria();
            frmcrearcategoria.FormClosed += new FormClosedEventHandler(frmcrearcategoria_FormClosed);//para actualizar datos al cerrar formulario
            frmcrearcategoria.ShowDialog();
        }

        private void frmcrearcategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            //actualizo categoria al cerrar formulario
            CargarCategorias();
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            if (txtBuscarCategoria.Text != "")
            {
                dtgCategoria.DataSource = CategoriaBL.BuscarCategoria(txtBuscarCategoria.Text);
            }
            else
                CargarCategorias();
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgCategoria.CurrentRow;
            int id = Convert.ToInt32(row.Cells["Id"].Value);

            FormEditarCategoria frmeditarcategoria = new FormEditarCategoria(id);
            frmeditarcategoria.FormClosed += new FormClosedEventHandler(frmeditarcategoria_FormClosed);//para actualizar datos al cerrar formulario
            frmeditarcategoria.ShowDialog();
        }

        private void frmeditarcategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarCategorias();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                DataGridViewRow row = dtgCategoria.CurrentRow;
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                CategoriaBL.EliminarCategoria(id);
                MessageBox.Show("Se Elimino la Categoria Con Numero ID: " + id, "Eliminar Registro");
                CargarCategorias();
            }
        }
    }
    
}
