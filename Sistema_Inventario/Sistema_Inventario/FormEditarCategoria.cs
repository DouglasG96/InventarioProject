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
    public partial class FormEditarCategoria : DevComponents.DotNetBar.Metro.MetroForm
    {
        private int idCategoria;
        public FormEditarCategoria(int id)
        {
            InitializeComponent();
            idCategoria = id;
        }

        private void FormEditarCategoria_Load(object sender, EventArgs e)
        {
            //lleno datos
            clasificacion categoria = CategoriaBL.DetalleCategoria(idCategoria);
            txtNombreCategoria.Text = categoria.nombre_clasificacion;
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            clasificacion categoria = new clasificacion();
            categoria.id_clasificacion = idCategoria;
            categoria.nombre_clasificacion = txtNombreCategoria.Text;

            CategoriaBL.EditarCategoria(categoria);
            MessageBox.Show("Categoria Editada Correctamente", "Registro Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
