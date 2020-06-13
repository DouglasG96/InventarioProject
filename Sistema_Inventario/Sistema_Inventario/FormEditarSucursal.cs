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
    public partial class FormEditarSucursal : DevComponents.DotNetBar.Metro.MetroForm
    {
        private int idSucursal;
        public FormEditarSucursal(int id)
        {
            InitializeComponent();
            idSucursal = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEditarSucursal_Load(object sender, EventArgs e)
        {
            //lenar datos
            sucursales sucursales = SucursalBL.ObtenerIdSucursal(idSucursal);
            txtSucursal.Text = sucursales.sucursal;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtSucursal.Text == "")
            {
                MessageBox.Show("Campo requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sucursales sucursales = new sucursales();
                sucursales.id_sucursal = idSucursal;
                sucursales.sucursal = txtSucursal.Text;
                sucursales.estado = 1;
                SucursalBL.EditarSucursal(sucursales);

                MessageBox.Show("Sucursal Editada Correctamente", "Registro Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
