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
    public partial class FormEditarTipoBodega : DevComponents.DotNetBar.Metro.MetroForm
    {
        private int idTipoBodega;
        public FormEditarTipoBodega(int id)
        {
            InitializeComponent();
            idTipoBodega = id;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarTipoBodega_Load(object sender, EventArgs e)
        {
            //lenar datos
            tipo_bodega tb = TipoBodegasBL.ObtenerIdTipoBodega(idTipoBodega);
             TxtTipo.Text = tb.tipo;
        }

        private void BtnEditarTipoBodega_Click(object sender, EventArgs e)
        {
            if (TxtTipo.Text == "")
            {
                MessageBox.Show("Campo requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tipo_bodega tb = new tipo_bodega();
                tb.id_tipo_bodega = idTipoBodega;
                tb.tipo = TxtTipo.Text;
                tb.estado = 1;
                TipoBodegasBL.EditarTipoBodega(tb);

                MessageBox.Show("Tipo Bodega Editada Correctamente", "Registro Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
        }
    }
}
