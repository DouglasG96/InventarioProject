using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Sistema_Inventario
{
    public partial class FormSucursal : Form
    {
        public FormSucursal()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sucursales nuevo = new sucursales();
            nuevo.sucursal = txtSucursal.Text;
            if (rdbactivo.Checked)
            {
                nuevo.estado = 1;
            }
            else {
                nuevo.estado = 2;
            }

            SucursalBL.CrearSucursal(nuevo);
            MessageBox.Show("Sucursal registrada Correctamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


        }
    }
}
