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
    public partial class FormBodega : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormBodega()
        {
            InitializeComponent();
        }

        private void FormBodega_Load(object sender, EventArgs e)
        {
            //Cargar tipo de sucursales
            cbxsucursal.DisplayMember = "sucursal";
            cbxsucursal.ValueMember = "id_sucursal";
            cbxsucursal.DataSource = SucursalBL.CargarSucursales();


            //Cargar tipo de bodegas
            cbxbodega.DisplayMember = "tipo";
            cbxbodega.ValueMember = "id_tipo_bodega";
            cbxbodega.DataSource = TipoBodegasBL.CargarTipoBodega();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bodegas bdg = new bodegas();
            bdg.nombre_bodega = txtBodega.Text;
            bdg.id_sucursal = Int32.Parse(cbxsucursal.SelectedValue.ToString());
            bdg.id_tipo_bodega = Int32.Parse(cbxbodega.SelectedValue.ToString());
            if (rdbactivo.Checked)
            {
                bdg.estado = 1;
            }
            else
            {
                bdg.estado = 0;
            }

            BodegasBL.CrearBodega(bdg);
            MessageBox.Show("Bodega registrada Correctamente" , "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
