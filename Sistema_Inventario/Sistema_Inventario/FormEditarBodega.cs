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
    public partial class FormEditarBodega : DevComponents.DotNetBar.Metro.MetroForm
    {
        private int idBodega;
        public FormEditarBodega(int id)
        {
            InitializeComponent();
            idBodega = id;
        }

        private void FormEditarBodega_Load(object sender, EventArgs e)
        {
            //lenar datos
            bodegas bodega = BodegasBL.ObtenerIdBodega(idBodega);
            txtBodega.Text = bodega.nombre_bodega;

            //Cargar tipo de sucursales
            cbxsucursal.DisplayMember = "sucursal";
            cbxsucursal.ValueMember = "id_sucursal";
            cbxsucursal.DataSource = SucursalBL.CargarSucursales();
            string idsucursal = bodega.id_sucursal.ToString();
            cbxsucursal.SelectedIndex = Int32.Parse(idsucursal)-1;

            //Cargar tipo de bodegas
            cbxtipo.DisplayMember = "tipo";
            cbxtipo.ValueMember = "id_tipo_bodega";
            cbxtipo.DataSource = TipoBodegasBL.CargarTipoBodega();
            string idtipo = bodega.id_tipo_bodega.ToString();
            cbxtipo.SelectedIndex = Int32.Parse(idtipo)-1;






        }

        private void button1_Click(object sender, EventArgs e)
        {
            bodegas bodega = new bodegas();
            bodega.id_bodega = idBodega;
            bodega.nombre_bodega = txtBodega.Text;
            bodega.id_sucursal = Int32.Parse(cbxsucursal.SelectedValue.ToString());
            bodega.id_tipo_bodega = Int32.Parse(cbxtipo.SelectedValue.ToString());

            BodegasBL.EditarBodega(bodega);
            MessageBox.Show("Bodega Editado Correctamente", "Registro Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
