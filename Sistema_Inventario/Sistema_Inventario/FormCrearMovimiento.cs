
using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario
{
    public partial class FormCrearMovimiento : DevComponents.DotNetBar.Metro.MetroForm
    {
        double costoTotalConIva = 0.0000;
        double costoTotalSinIva = 0.0000;
        double costoUnitarioConIva = 0.0000;
        double costoUnitarioSinIva = 0.0000;
        double cantidadMovimiento = 0;
        int numeroMovimiento = 0;
        int idUsuario = 0;
        String idProducto = "";
        String nombreUsuario = "";
        String nombreMovimiento = "";
        String nombreProducto = "";
        String tipoMovimiento = "";

        public FormCrearMovimiento(String nombreUsuario, int numeroMovimiento, int idUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.numeroMovimiento = numeroMovimiento;
            this.idUsuario = idUsuario;
        }

        private void FormCrearMovimiento_Load(object sender, EventArgs e)
        {
            //cargo combox
            cargarComboBox();
            //Cargo Datos de sesion
            cargarDatosSesion(nombreUsuario, idUsuario, numeroMovimiento);

            //Oculto idUsuario
            txtIdUsuario.Visible = false;

            //Oculto selector de proveedores
            cmbProveedor.Visible = false;
            lblProveedor.Visible = false;
        }

        private void btnCancelarMovimiento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarDetalleMovimiento_Click(object sender, EventArgs e)
        {
            /*
            productos producto = new productos();
            producto.nombre = txtNumeroMovimiento.Text;
            producto.codigo = txtDescripcion.Text;
            producto.descripcion = txtDescripcionProducto.Text;
            producto.id_vigencia_promedio = Convert.ToInt32(cbxVigencia.SelectedValue);
            producto.id_sub_clasificacion = Convert.ToInt32(cbxSubCategoria.SelectedValue);
            producto.id_proveedor = Convert.ToInt32(cbxProveedor.SelectedValue);
            producto.fecha_creacion = DateTime.Now.Date;
            producto.hora_creacion = DateTime.Now.TimeOfDay;
            ProductoBL.CrearProducto(producto);
            MessageBox.Show("Producto Agregado Correctamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            */
        }

        private void cargarComboBox()
        {
            cmbTipoMovimiento.DataSource = TipoMovimientoBL.CargarTipoMovimientoSelector();
            cmbTipoMovimiento.DisplayMember = "tipo_movimiento";
            cmbTipoMovimiento.ValueMember = "id_tipo_movimiento";

            cmbProducto.DataSource = ProductoBL.cargarProductosSelector();
            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "id_producto";

            cmbBodega.DataSource = BodegasBL.CargarBodegasSelector();
            cmbBodega.DisplayMember = "nombre_bodega";
            cmbBodega.ValueMember = "id_bodega";
        }

        private void cargarDatosSesion(String nombreUsuario, int idUsuario, int numeroMovimiento)
        {
            txtUsuario.Text = nombreUsuario.Trim();
            txtIdUsuario.Text = Convert.ToString(idUsuario);
            txtNumeroMovimiento.Text = Convert.ToString(numeroMovimiento);
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void cargarComboBoxProveedores()
        {
            cmbProveedor.DataSource = ProveedorBL.CargarProveedoresOpcional();
            cmbProveedor.DisplayMember = "nombre";
            cmbProveedor.ValueMember = "id_proveedor";
            cmbProveedor.Visible = true;
            lblProveedor.Visible = true;
        }

        private void btnCrearMovimiento_Click(object sender, EventArgs e)
        {

        }

        private void validarSeleccionTipoMovimiento(object sender, EventArgs e)
        {
            tipoMovimiento = cmbTipoMovimiento.SelectedValue.ToString();
            nombreMovimiento = cmbTipoMovimiento.GetItemText(this.cmbTipoMovimiento.SelectedItem).ToString();
            if (tipoMovimiento == "1")
            {
                cargarComboBoxProveedores();
                txtDescripcion.Text = nombreMovimiento;
            }
            else if (tipoMovimiento == "0")
            {
                MessageBox.Show("Debe elegir un tipo de movimiento", "Error al seleccionar tipo de movimiento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbTipoMovimiento.Focus();
                txtDescripcion.Text = "";
            }
            else
            {
                txtDescripcion.Text = nombreMovimiento;
                cmbProveedor.Visible = false;
                lblProveedor.Visible = false;
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreProducto = cmbProducto.GetItemText(this.cmbProducto.SelectedItem).ToString();
            cargarDescripcion(nombreProducto);

            idProducto = cmbProducto.SelectedValue.ToString();
            cargarCostoUnitario(idProducto);
        }

        protected void cargarDescripcion(String nombreProducto)
        {
            if (nombreMovimiento != "")
            {
                txtDescripcion.Text = "";
                txtDescripcion.Text = nombreMovimiento + " de " + nombreProducto;
            }
        }

        protected void cargarCostoUnitario(String idProducto)
        {
            String costoUnitario = MovimientosBL.consultarCostoUnitario(idProducto);
            txtCostoUnitario.Text = costoUnitario;
        }

        private void calcularTotales(object sender, EventArgs e)
        {
            cantidadMovimiento = Convert.ToDouble(nudCantidad.Value);
            costoUnitarioConIva = Convert.ToDouble(txtCostoUnitario.Text.Trim());
            costoTotalConIva = MovimientosBL.calcularCostoTotalConIva(costoUnitarioConIva, cantidadMovimiento);
            costoTotalSinIva = costoTotalConIva / 1.13;
            txtVentaTotalSinIva.Text = costoTotalSinIva.ToString();
            txtVentaTotalConIva.Text = costoTotalConIva.ToString();
        }
    }
}
