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
    public partial class FormCrearCategoria : DevComponents.DotNetBar.Metro.MetroForm
    {

        #region Validaciones
        //metodo para validar los datos del alumno sean correctos
        public bool ValidacionesCategoria()
        {
            bool resul = true;

            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtNombreCategoria.Text))
            {
                errorProvider1.SetError(txtNombreCategoria, "El nombre es obligatorio");
                resul = false;
            }

            return resul;
        }
       
        #endregion

        public FormCrearCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            //compruebo las validaciones
            if (!ValidacionesCategoria())
                return;

            clasificacion categoria = new clasificacion();
            categoria.nombre_clasificacion = txtNombreCategoria.Text;
            CategoriaBL.CrearCategoria(categoria);
            MessageBox.Show("Categoria Agregada Correctamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
