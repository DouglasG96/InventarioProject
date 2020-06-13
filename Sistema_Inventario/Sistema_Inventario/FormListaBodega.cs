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

namespace Sistema_Inventario
{
    public partial class FormListaBodega : DevComponents.DotNetBar.Metro.MetroForm
    {

        FormBodega frmbodega;
        
        public FormListaBodega()
        {
            InitializeComponent();
        }

        private void CargarBodegasd()
        {
            dtwbodegas.AutoGenerateColumns = false;
            dtwbodegas.DataSource = BodegasBL.CargarBodegas();
        }

        private void FormListaBodega_Load(object sender, EventArgs e)
        {
            CargarBodegasd();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmbodega == null)
            {
                frmbodega = new FormBodega();
                frmbodega.FormClosed += new FormClosedEventHandler(frmeditarbodega_FormClosed);//para actualizar datos al cerrar formulario
                frmbodega.ShowDialog();
                
            }
            else
            {
                frmbodega.Activate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtwbodegas.CurrentRow;
            int id = Convert.ToInt32(row.Cells["id_bodega"].Value);

            FormEditarBodega frmeditarbodega = new FormEditarBodega(id);
            frmeditarbodega.FormClosed += new FormClosedEventHandler(frmeditarbodega_FormClosed);//para actualizar datos al cerrar formulario
            frmeditarbodega.ShowDialog();
        }

        private void frmeditarbodega_FormClosed(object sender, FormClosedEventArgs e)
        {
            //actualizo productos al cerrar formulario
            CargarBodegasd();
        }

        private void buscar_bodega(object sender, EventArgs e)
        {
            if (TxtBuscar.Text != "")
            {
              dtwbodegas.DataSource = BodegasBL.BuscarBodega(TxtBuscar.Text);
            }
            else
                CargarBodegasd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                DataGridViewRow row = dtwbodegas.CurrentRow;
                int id = Convert.ToInt32(row.Cells["id_bodega"].Value);
                BodegasBL.EliminarBodega(id);
                MessageBox.Show("Se Elimino la bodega Con Numero ID: " + id, "Eliminar Registro");
                CargarBodegasd();
            }
        }
    }
}

