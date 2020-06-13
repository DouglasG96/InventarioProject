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
    public partial class FormTipoBodega : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormTipoBodega()
        {
            InitializeComponent();
        }

        private void CargarTipoBodegas()
        {

            dtwtipobodega.AutoGenerateColumns = false;
            dtwtipobodega.DataSource = TipoBodegasBL.CargarTipoBodega();
        }

        private void FormTipoBodega_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardarTipoBodega_Click(object sender, EventArgs e)
        {
            if (TxtTipo.Text == "")
            {
                MessageBox.Show("Campo requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                tipo_bodega tipob = new tipo_bodega();
                tipob.tipo = TxtTipo.Text;
                tipob.estado = 1;

                TipoBodegasBL.CrearTipoBodega(tipob);
                MessageBox.Show("Tipo de Bodega registrada Correctamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTipoBodegas();
                if (dtwtipobodega.RowCount > 0)
                {
                    btneditar.Enabled = true;
                    btneliminar.Enabled = true;
                }
                else
                {
                    btneditar.Enabled = false;
                    btneliminar.Enabled = false;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormTipoBodega_Load_1(object sender, EventArgs e)
        {

            CargarTipoBodegas();
            if (dtwtipobodega.RowCount > 0)
            {
                btneditar.Enabled = true;
                btneliminar.Enabled = true;
            }
            else
            {
                btneditar.Enabled = false;
                btneliminar.Enabled = false;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                DataGridViewRow row = dtwtipobodega.CurrentRow;

                int id = Convert.ToInt32(row.Cells["Id_tipo_Bodega"].Value);
                TipoBodegasBL.EliminarTipoBodega(id);
                MessageBox.Show("Se Elimino Tipo bodega Con Numero ID: " + id, "Eliminar Registro");
                CargarTipoBodegas();
                if (dtwtipobodega.RowCount > 0)
                {
                    btneditar.Enabled = true;
                    btneliminar.Enabled = true;
                }
                else
                {
                    btneditar.Enabled = false;
                    btneliminar.Enabled = false;
                }

            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtwtipobodega.CurrentRow;
            int id = Convert.ToInt32(row.Cells["Id_tipo_Bodega"].Value);

            FormEditarTipoBodega frmeditartipobodega = new FormEditarTipoBodega(id);
            frmeditartipobodega.FormClosed += new FormClosedEventHandler(frmeditartipobodega_FormClosed);//para actualizar datos al cerrar formulario
            frmeditartipobodega.ShowDialog();
        }

        private void frmeditartipobodega_FormClosed(object sender, FormClosedEventArgs e)
        {
            //actualizo sucursales al cerrar formulario
            CargarTipoBodegas();
        }

        private void buscar_tipo_bodega(object sender, EventArgs e)
        {
            if (TxtxBuscar.Text != "")
            {
                dtwtipobodega.DataSource = TipoBodegasBL.BuscarTipoBodega(TxtxBuscar.Text);
            }
            else
                CargarTipoBodegas();

        }
    }
}
