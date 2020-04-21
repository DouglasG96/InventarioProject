
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
        double cantidadCapacidadMaxima = 0.0000;
        double cantidadCapacidadActual = 0.0000;
        int numeroMovimiento = 0;
        int idUsuario = 0;
        int contadorDetalle = 0;
        String idProducto = "";
        String idBodega = "";
        String nombreUsuario = "";
        String nombreMovimiento = "";
        String nombreProducto = "";
        String nombreBodega = "";
        String tipoMovimiento = "";
        bool excesoCapacidadMaxima = false;
        movimientos objMovimientos;
        detalles_movimientos objDetallesMovimientos, datosDetallesMovimientos;
        productos datosProducto;
        String[] datosDetalle;

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
            cargarTipoMovimiento();
            //Cargo Datos de sesion
            cargarDatosSesion(nombreUsuario, idUsuario, numeroMovimiento);

            //Oculto idUsuario
            txtIdUsuario.Visible = false;

            //Oculto selector de proveedores
            cmbProveedor.Visible = false;
            lblProveedor.Visible = false;

            cmbProducto.Enabled = false;
            cmbBodega.Enabled = false;
        }

        private void btnCancelarMovimiento_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cargarTipoMovimiento()
        {
            cmbTipoMovimiento.DataSource = TipoMovimientoBL.CargarTipoMovimientoSelector();
            cmbTipoMovimiento.DisplayMember = "tipo_movimiento";
            cmbTipoMovimiento.ValueMember = "id_tipo_movimiento";
        }

        private void cargarBodegas()
        {
            cmbBodega.DataSource = BodegasBL.CargarBodegasSelector();
            cmbBodega.DisplayMember = "nombre_bodega";
            cmbBodega.ValueMember = "id_bodega";
        }

        private void cargarProductos()
        {
            cmbProducto.DataSource = ProductoBL.cargarProductosSelector();
            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "id_producto";
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

        private void validarSeleccionTipoMovimiento(object sender, EventArgs e)
        {
            tipoMovimiento = cmbTipoMovimiento.SelectedValue.ToString();
            Debug.Write(tipoMovimiento);
            nombreMovimiento = cmbTipoMovimiento.GetItemText(this.cmbTipoMovimiento.SelectedItem).ToString();
            if (tipoMovimiento == "1")
            {
                cargarComboBoxProveedores();
                txtDescripcion.Text = nombreMovimiento;
                validacionSelector(cmbProducto,true);
                cargarProductos();
            }
            else if (tipoMovimiento == "0")
            {
                MessageBox.Show("Debe elegir un tipo de movimiento", "Error al seleccionar tipo de movimiento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbTipoMovimiento.Focus();
                cmbProveedor.SelectedValue = 0;
                txtDescripcion.Text = "";
                validacionSelector(cmbProducto,false);
            }
            else
            {
                cmbProveedor.SelectedValue = 0;
                txtDescripcion.Text = nombreMovimiento;
                cmbProveedor.Visible = false;
                lblProveedor.Visible = false;
                validacionSelector(cmbProducto, true);
                cargarProductos();
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreProducto = cmbProducto.GetItemText(this.cmbProducto.SelectedItem).ToString();
            cargarDescripcion(nombreProducto);

            idProducto = cmbProducto.SelectedValue.ToString();
            cargarCostoUnitario(idProducto);

            if(idProducto == "0" )
            {
                validacionSelector(cmbBodega, false);    
            }
            else
            {   
                validacionSelector(cmbBodega, true);
                cargarBodegas();
            }
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
            datosProducto = ProductoBL.consultarDatosProducto(idProducto);
            datosDetallesMovimientos = DetallesMovimientosBL.consultarDetallesMovimientosProducto(idProducto);
            txtCostoUnitario.Text = datosProducto.costo_unitario_con_iva.ToString().Trim();
        }

        private void calcularTotales(object sender, EventArgs e)
        {
            cantidadMovimiento = Convert.ToDouble(nudCantidad.Value);
            cantidadCapacidadMaxima = Convert.ToDouble(txtCapacidadMaxima.Text);
            cantidadCapacidadActual = Convert.ToDouble(txtCapacidadActual.Text);
            if(cantidadMovimiento > 0)
            {
                //Validar capacidad maxima de bodega
                excesoCapacidadMaxima = BodegasBL.calcularCapacidadMaxima(cantidadMovimiento, cantidadCapacidadMaxima, cantidadCapacidadActual);
                if (excesoCapacidadMaxima)
                {
                    MessageBox.Show("La cantidad seleccionada sobrepasa la cantidad maxima de la bodega seleccionada, reduzca la cantidad", "Error al cargar cantidad",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    nudCantidad.Focus();
                    nudCantidad.Value = 0;
                }
                else
                {
                    // Calcular costos totales
                    costoTotalConIva = MovimientosBL.calcularCostoTotalConIva(costoUnitarioConIva, cantidadMovimiento);
                    costoTotalSinIva = costoTotalConIva / 1.13;

                    // Calcular costos unitarios
                    costoUnitarioConIva = Convert.ToDouble(txtCostoUnitario.Text.Trim());
                    costoUnitarioSinIva = (costoUnitarioConIva / 1.13);

                    //Mostrar valores
                    txtVentaTotalSinIva.Text = costoTotalSinIva.ToString();
                    txtVentaTotalConIva.Text = costoTotalConIva.ToString();
                }
                btnAgregarDetalleMovimiento.Enabled = true;
            }
            else
            {
                btnAgregarDetalleMovimiento.Enabled = false;
            }
        }

        private void validacionSelector(ComboBox comboBox, bool habilitarSelector)
        {
            comboBox.Enabled = habilitarSelector;
        }

        private void validacionTextBox(TextBox textBox, bool habilitarTextBox)
        {
            textBox.Enabled = habilitarTextBox;
        }

        private void validacionNumeric(NumericUpDown numericUpDown, bool habilitarNumeric)
        {
            numericUpDown.Enabled = habilitarNumeric;
        }

        private void cmbBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            idBodega = cmbBodega.SelectedValue.ToString();
            nombreBodega = cmbBodega.GetItemText(this.cmbBodega.SelectedItem).ToString();
            if (idBodega != "0")
            {
                var datosBodega = BodegasBL.consultarDatosBodega(idBodega);
                txtCapacidadMaxima.Text = datosBodega.capacidad_maxima.ToString().Trim();
                txtCapacidadActual.Text = datosBodega.capacidad_actual.ToString().Trim();
                txtTemperaturaPromedio.Text = datosBodega.temperatura_promedio.ToString().Trim();
                validacionNumeric(nudCantidad, true);
            }
            else
            {
                txtCapacidadMaxima.Text = "0";
                txtCapacidadActual.Text = "0";
                validacionNumeric(nudCantidad, false);
                nudCantidad.Value = 0;
            }
            //Debug.Write(datosBodega);
        }

        private void btnAgregarDetalleMovimiento_Click(object sender, EventArgs e)
        {
            
                var nombreProducto = datosProducto.nombre.ToString().Trim();
                var existenciaAnterior = datosDetallesMovimientos.existencia_anterior.ToString().Trim();
                if(existenciaAnterior == "")
                {
                    existenciaAnterior = "0";
                }
                var existenciaTotal = Convert.ToInt32(existenciaAnterior) + cantidadMovimiento;

                DateTime fechaRegistro = DateTime.Parse(datosProducto.fecha_creacion.ToString());
                var fechaVencimiento = fechaRegistro.AddMonths(4);


                //Generamos aleatoriamente numero de lote
                int longitud = 7;
                Guid miGuid = Guid.NewGuid();
                string lote = Convert.ToBase64String(miGuid.ToByteArray());
                lote = lote.Replace("=", "").Replace("+", "");

                datosDetalle = new String[] {
                (contadorDetalle+1).ToString(),
                numeroMovimiento.ToString(),
                nombreProducto,
                nombreBodega,
                fechaVencimiento.ToString(),
                lote.Substring(0, longitud),
                cantidadMovimiento.ToString(),
                costoUnitarioConIva.ToString(),
                costoUnitarioSinIva.ToString(),
                existenciaAnterior,
                existenciaTotal.ToString(),
                "Pendiente"
                };

                cargarDetallesMovimiento();
            try
            {
            }
            catch(Exception exepcion)
            {
                Debug.Write(exepcion);
                /*
                MessageBox.Show(exepcion.Message, "Error al agregar detalle",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                */
            }
 
            /*
            objDetallesMovimientos = new detalles_movimientos();

            //Generamos fecha vencimiento
            DateTime fechaRegistro = DateTime.Parse(datosProducto.fecha_creacion.ToString());
            var fechaVencimiento = fechaRegistro.AddMonths(4)

            objDetallesMovimientos.fecha_vencimiento = fechaVencimiento;
            objDetallesMovimientos.lote = lote.Substring(0, longitud);
            objDetallesMovimientos.cantidad = 
            
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

        private void cargarDetallesMovimiento()
        {

            try
            {
                foreach(var indice in datosDetalle)
                {
                    dgvDetallesMovimientos.Rows.Add(indice);
                }
                
                //dgvDetallesMovimientos.DataSource = datosDetalle;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error al cargar los detalles",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnCrearMovimiento_Click(object sender, EventArgs e)
        {
            TimeSpan hora = new TimeSpan();
            objMovimientos = new movimientos();
            objMovimientos.id_tipo_movimiento = Convert.ToInt32(tipoMovimiento);
            objMovimientos.fecha = Convert.ToDateTime(txtFecha.Text.Trim());
            objMovimientos.hora = hora;
            objMovimientos.descripcion = txtDescripcion.Text.Trim();
            objMovimientos.costo_total_con_iva =
            objMovimientos.costo_total_sin_iva =
            objMovimientos.id_usuario = Convert.ToInt32(txtIdUsuario.Text.Trim());
            objMovimientos.estado = 0;
            objMovimientos.id_proveedor = Convert.ToInt32(cmbProveedor.SelectedValue.ToString());
        }

    }
}
