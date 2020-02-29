using Datos;
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
    public partial class FormDetalleProducto : DevComponents.DotNetBar.Metro.MetroForm
    {
      
        private int idProducto;
        //capturo en constructor id del producto
        public FormDetalleProducto(int id)
        {
            InitializeComponent();
            idProducto = id;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetalleProducto_Load(object sender, EventArgs e)
        {
            vw_producto producto = ProductosDAL.DetalleProducto(idProducto);
            txtNombreProducto.Text = producto.nombre;
            txtDescripcionProducto.Text = producto.descripcion;
            txtCodigoProducto.Text = producto.codigo;
            txtProveedor.Text = producto.proveedor;
            txtVigencia.Text = producto.dias.ToString();
            txtCategoria.Text = producto.categoria;
            txtFechaCreacion.Text = string.Format("{0:dd/MM/yyyy}", producto.fecha_creacioon);
            txtHoraCreacion.Text = producto.hora_creacion.ToString();
        }
    }
}
