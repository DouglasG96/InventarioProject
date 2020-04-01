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

        private void FormTipoBodega_Load(object sender, EventArgs e)
        {

        }
     
        private void BtnGuardarTipoBodega_Click(object sender, EventArgs e)
        {
            tipo_bodega tipob = new tipo_bodega();
            tipob.tipo = TxtTipo.Text;
            if (rdbactivo.Checked)
            {
                tipob.estado = 1;
            }
            else
            {
                tipob.estado = 0;
            }

            TipoBodegasBL.CrearTipoBodega(tipob);
            MessageBox.Show("Tipo de Bodega registrada Correctamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
