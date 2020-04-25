
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
        decimal existenciaAnterior = 0;
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
        detalles_movimientos objDetallesMovimientos;
        productos datosProducto;
        String[] datosDetalle;
        
        /// <summary>
        /// Recibo datos precargados del movimiento
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="numeroMovimiento"></param>
        /// <param name="idUsuario"></param>
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
            cmbAuxiliar.Visible = false;
            lblAuxiliar.Visible = false;

            cmbProducto.Enabled = false;
            cmbBodega.Enabled = false;

            txtVentaTotalConIva.Text = "0.00";
            txtVentaTotalSinIva.Text = "0.00";

        }

        /// <summary>
        /// Seteo los textBox correspondientes con datos precargados
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="idUsuario"></param>
        /// <param name="numeroMovimiento"></param>
        private void cargarDatosSesion(String nombreUsuario, int idUsuario, int numeroMovimiento)
        {
            txtUsuario.Text = nombreUsuario.Trim();
            txtIdUsuario.Text = Convert.ToString(idUsuario);
            txtNumeroMovimiento.Text = Convert.ToString(numeroMovimiento);
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Cargo selector de tipos de movimientos
        /// </summary>
        private void cargarTipoMovimiento()
        {
            cmbTipoMovimiento.DataSource = TipoMovimientoBL.CargarTipoMovimientoSelector();
            cmbTipoMovimiento.DisplayMember = "tipo_movimiento";
            cmbTipoMovimiento.ValueMember = "id_tipo_movimiento";
        }

        /// <summary>
        /// Cargo selector de bodegas
        /// </summary>
        private void cargarBodegas()
        {
            cmbBodega.DataSource = BodegasBL.CargarBodegasSelector();
            cmbBodega.DisplayMember = "nombre_bodega";
            cmbBodega.ValueMember = "id_bodega";
        }

        /// <summary>
        /// Cargo selector de producto
        /// </summary>
        private void cargarProductos(String idBodega)
        {
            int idbod = Convert.ToInt32(idBodega);
            cmbProducto.DataSource = ProductoBL.cargarProductosSelector();
            //cmbProducto.DataSource = DetallesMovimientosBL.cargarProductosBodega(idbod);
            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "id_producto";
        }

        /// <summary>
        /// Recibo el tipo de movimiento seleccionado cargo el selector respectivo para ese movimiento
        /// </summary>
        /// <param name="banderaTipoMovimiento"></param>
        private void cargarComboBoxAuxiliar(int banderaTipoMovimiento)
        {
            //Cargo proveedores
            if (banderaTipoMovimiento == 1)
            {
                lblAuxiliar.Text = "Proveedores: ";
                cmbAuxiliar.DataSource = ProveedorBL.CargarProveedoresOpcional();
                cmbAuxiliar.DisplayMember = "nombre";
                cmbAuxiliar.ValueMember = "id_proveedor";
            }
            //Cargo bodega para trasladar producto
            else
            {
                lblAuxiliar.Text = "Bodega de cargo: ";
                cmbAuxiliar.DataSource = BodegasBL.CargarBodegasSelector();
                cmbAuxiliar.DisplayMember = "nombre_bodega";
                cmbAuxiliar.ValueMember = "id_bodega";
            }
            //Muestro selector y label
            cmbAuxiliar.Visible = true;
            lblAuxiliar.Visible = true;
        }

        private void validarSelectorAuxiliar(object sender, EventArgs e)
        {
            // Valido una sola vez el tipo de movimiento a realizar
            DialogResult dialogResult = MessageBox.Show(
                    "¿Estas seguro?, más adelante no se podrá elegir otra opción de este tipo",
                    "¡Alerta!",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
            );
            if (dialogResult == DialogResult.OK)
            {
                validacionSelector(cmbAuxiliar, false);
            }
        }

        private void validarSeleccionTipoMovimiento(object sender, EventArgs e)
        {
            // Valido una sola vez el tipo de movimiento a realizar
            DialogResult dialogResult = MessageBox.Show(
                    "¿Estas seguro?, mas adelante no se podrá elegir otro tipo de movimiento",
                    "¡Alerta!",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
            );
            if (dialogResult == DialogResult.OK)
            {
                tipoMovimiento = cmbTipoMovimiento.SelectedValue.ToString();
                nombreMovimiento = cmbTipoMovimiento.GetItemText(this.cmbTipoMovimiento.SelectedItem).ToString();
                // Entrada de producto
                if (tipoMovimiento == "1")
                {
                    cargarComboBoxAuxiliar(1);
                    txtDescripcion.Text = nombreMovimiento;
                    validacionSelector(cmbTipoMovimiento, false);
                    //Habilito selector de bodega
                    validacionSelector(cmbBodega, true);
                    //Cargo selector de bodegas
                    cargarBodegas();
                }
                //Traslado de producto
                else if(tipoMovimiento == "3")
                {
                    cargarComboBoxAuxiliar(3);
                    txtDescripcion.Text = nombreMovimiento;
                    validacionSelector(cmbTipoMovimiento, false);
                    //Habilito selector de bodega
                    validacionSelector(cmbBodega, true);
                    //Cargo selector de bodegas
                    cargarBodegas();
                    lblBodega.Text = "Bodega de descargo: ";
                }
                else if (tipoMovimiento == "0")
                {
                    MessageBox.Show("Debe elegir un tipo de movimiento", "Error al seleccionar tipo de movimiento",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    cmbTipoMovimiento.Focus();
                    cmbAuxiliar.SelectedValue = 0;
                    txtDescripcion.Text = "";
                    validacionSelector(cmbBodega, false);
                }
                else
                {
                    cmbAuxiliar.SelectedValue = 0;
                    txtDescripcion.Text = nombreMovimiento;
                    cmbAuxiliar.Visible = false;
                    lblAuxiliar.Visible = false;
                    validacionSelector(cmbTipoMovimiento, false);
                    //Habilito selector de bodega
                    validacionSelector(cmbBodega, true);
                    //Cargo selector de bodegas
                    cargarBodegas();
                }
            }
        }

        private void cmbBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            idBodega = cmbBodega.SelectedValue.ToString();
            nombreBodega = cmbBodega.GetItemText(this.cmbBodega.SelectedItem).ToString();

            //Valido que se haya seleccionado una bodega
            if (idBodega != "0")
            {                
                //Cargo datos respectivos de bodega seleccionada
                var datosBodega = BodegasBL.consultarDatosBodega(idBodega);
                txtCapacidadMaxima.Text = datosBodega.capacidad_maxima.ToString().Trim();
                txtCapacidadActual.Text = datosBodega.capacidad_actual.ToString().Trim();
                txtTemperaturaPromedio.Text = datosBodega.temperatura_promedio.ToString().Trim();
                validacionSelector(cmbProducto, true);
                //Ejecuto metodo para cargar productos
                cargarProductos(idBodega);
            }
            else
            {
                // Deshabilito selector de producto
                validacionSelector(cmbProducto, false);
                txtCapacidadMaxima.Text = "0";
                txtCapacidadActual.Text = "0";
                validacionNumeric(nudCantidad, false);
                nudCantidad.Value = 0;
            }
            //Debug.Write(datosBodega);
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProducto = cmbProducto.SelectedValue.ToString();
            if (idProducto == "0" )
            {
                MessageBox.Show(
                    "Debe Seleccionar un producto",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                validacionNumeric(nudCantidad, false);
            }
            else
            {
                nombreProducto = cmbProducto.GetItemText(this.cmbProducto.SelectedItem).ToString();
                cargarDescripcion(nombreProducto);
                cargarCostoUnitario(idProducto);
                validacionNumeric(nudCantidad, true);
            }
        }

        /// <summary>
        /// Seteo el textBox de descripcion con el tipo de movimiento y nombre de producto
        /// </summary>
        /// <param name="nombreProducto"></param>
        protected void cargarDescripcion(String nombreProducto)
        {
            if (nombreMovimiento != "")
            {
                txtDescripcion.Text = "";
                txtDescripcion.Text = nombreMovimiento + " de " + nombreProducto;
            }
        }

        /// <summary>
        /// Cargo costo unitario del producto seleccionado
        /// </summary>
        /// <param name="idProducto"></param>
        protected void cargarCostoUnitario(String idProducto)
        {
            datosProducto = ProductoBL.consultarDatosProducto(idProducto);
            existenciaAnterior = DetallesMovimientosBL.consultarExistenciaAnteriorProducto(idProducto);
            //existenciaProductoBodega = DetallesMovimientosBL.consultarExistenciaProducto(idProducto,idBodega);
            txtCostoUnitario.Text = datosProducto.costo_unitario_con_iva.ToString().Trim();
        }

        /// <summary>
        /// Calculo los respectivos totales del producto seleccionado en base a la cantidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcularTotales(object sender, EventArgs e)
        {
            try
            {
                cantidadMovimiento = Convert.ToDouble(nudCantidad.Value);
                cantidadCapacidadMaxima = Convert.ToDouble(txtCapacidadMaxima.Text);
                cantidadCapacidadActual = Convert.ToDouble(txtCapacidadActual.Text);
            }
            catch(Exception excepcion)
            {
                MessageBox.Show(
                    excepcion.Message,
                    "Error al Convertir Datos Para Calcular Totales",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            if(cantidadMovimiento > 0)
            {
                //Valida capacidad maxima de bodega
                excesoCapacidadMaxima = BodegasBL.calcularCapacidadMaxima(cantidadMovimiento, cantidadCapacidadMaxima, cantidadCapacidadActual);
                if (excesoCapacidadMaxima)
                {
                    MessageBox.Show(
                        "La cantidad seleccionada sobrepasa la cantidad maxima de la bodega seleccionada, reduzca la cantidad",
                        "Error al Cargar Cantidad",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    nudCantidad.Focus();
                    nudCantidad.Value = 0;
                }
                // Si el calculo no sobre pasa la cantidad maxima de la bodega se procede a mostrar el calculo realizado
                else
                {
                    // Validar que costo unitario no este vacío
                    if (txtCostoUnitario.Text.Trim() != "")
                    {
                        // Calcular costos unitarios
                        costoUnitarioConIva = Convert.ToDouble(txtCostoUnitario.Text.Trim());
                        costoUnitarioSinIva = (costoUnitarioConIva / 1.13);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Verificar costo unitario del producto",
                            "Error al Calcular los Totales",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                btnAgregarDetalleMovimiento.Enabled = true;
            }
            else
            {
                btnAgregarDetalleMovimiento.Enabled = false;
            }
        }
        /// <summary>
        /// Valida que selector habilitar o desabilitar segun parametros recibidos
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="habilitarSelector"></param>
        private void validacionSelector(ComboBox comboBox, bool habilitarSelector)
        {
            comboBox.Enabled = habilitarSelector;
        }

        /// <summary>
        /// Valida que TextBox habilitar o desabilitar segun parametros recibidos
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="habilitarTextBox"></param>
        private void validacionTextBox(TextBox textBox, bool habilitarTextBox)
        {
            textBox.Enabled = habilitarTextBox;
        }

        /// <summary>
        /// Valida que NumberUpDown habilita o desabilita segun parametros recibidos
        /// </summary>
        /// <param name="numericUpDown"></param>
        /// <param name="habilitarNumeric"></param>
        private void validacionNumeric(NumericUpDown numericUpDown, bool habilitarNumeric)
        {
            numericUpDown.Enabled = habilitarNumeric;
        }



        private void btnAgregarDetalleMovimiento_Click(object sender, EventArgs e)
        {
            try
            {
                double existenciaTotal = 0;
                //Aumento Contador de detalle
                contadorDetalle++;
                String contador = contadorDetalle.ToString();
                //Capturo nombre de producto
                var nombreProducto = datosProducto.nombre.ToString().Trim();

                //Calculo existencia total del producto
                if (tipoMovimiento == "1")
                {
                    existenciaTotal = (Convert.ToDouble(existenciaAnterior) + Convert.ToDouble(cantidadMovimiento));
                }
                else if(tipoMovimiento == "2")
                {
                    existenciaTotal = (Convert.ToDouble(existenciaAnterior) - Convert.ToDouble(cantidadMovimiento));
                }
                
                if (existenciaAnterior == 0)
                {
                    existenciaAnterior = Convert.ToDecimal(existenciaTotal);
                }
                Random random = new Random();
                // Recuerda que el segundo argumento es el límite
                // superior exclusivo
                // Entre 1 y 5
                int numeroMeses = random.Next(1, 5);

                //Calculo automáticamente fecha de vencimiento en base a fecha de creación del producto
                DateTime fechaRegistro = DateTime.Parse(datosProducto.fecha_creacion.ToString());
                var fechaVencimiento = fechaRegistro.AddMonths(numeroMeses);

                //Generamos aleatoriamente numero de lote con letras y números
                int longitud = 7;
                Guid miGuid = Guid.NewGuid();
                string lote = Convert.ToBase64String(miGuid.ToByteArray());
                lote = lote.Replace("=", "").Replace("+", "");

                //Genero arreglo para agregar a dataGridVie
                //dgvDetallesMovimientos.Rows.Add(datosDetalle);
                datosDetalle = new String[] {
                    //Contador de detalle
                    contador,
                    //id_movimiento
                    numeroMovimiento.ToString(),
                    // Nombre del producto
                    nombreProducto,
                    // id_producto
                    idProducto.ToString(),
                    // nombre de la bodeg
                    nombreBodega,
                    // id_bodega
                    idBodega.ToString(),
                    // fecha de vencimiento
                    fechaVencimiento.ToString(),
                    // numero de lote
                    lote.Substring(0, longitud),
                    // Cantidad de productos en detalle
                    cantidadMovimiento.ToString(),
                    // Costo unitario con IVA
                    costoUnitarioConIva.ToString(),
                    // Costo unitario sin IVA
                    costoUnitarioSinIva.ToString(),
                    // Existencia anterior del producto
                    existenciaAnterior.ToString(),
                    // Existencia total (actual) del producto
                    existenciaTotal.ToString(),
                    // Descripcion de estado
                    "Aprobado",
                    // estado
                    "1"
                };
                //Ejecuto Metodo para cargar detalle
                cargarDetallesMovimiento();
                //Habilito botón para eliminar detalle
                btnEliminarDetalle.Enabled = true;
                //Debug.Write(datosDetalle);
            }
            catch (Exception exepcion)
            {
                MessageBox.Show(
                    exepcion.Message, 
                    "Error al agregar detalle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }            
        }

        /// <summary>
        /// Carga detalles en dataGridView
        /// </summary>
        private void cargarDetallesMovimiento()
        {
            try
            {
                costoTotalConIva = Convert.ToDouble(txtVentaTotalConIva.Text.Trim());
                // Calcular costos totales
                costoTotalConIva = MovimientosBL.calcularCostoTotalConIva(costoUnitarioConIva, cantidadMovimiento, costoTotalConIva);
                costoTotalSinIva = (costoTotalConIva / 1.13);
                //Mostrar valores
                txtVentaTotalSinIva.Text = Convert.ToString(costoTotalSinIva);
                txtVentaTotalConIva.Text = Convert.ToString(costoTotalConIva);
                //Cargo arreglo en una fila del dataGridView
                dgvDetallesMovimientos.Rows.Add(datosDetalle);
                datosDetalle = new String[]{
                };
            }
            catch(Exception e)
            {
                MessageBox.Show(
                    e.Message, 
                    "Error al cargar los detalles",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
               );
            }
            // Limpio el formulario
            limpiarFormulario();
        }

        /// <summary>
        /// Limpia formulario
        /// </summary>
        private void limpiarFormulario()
        {
            cmbProducto.SelectedIndex = 0;
            cmbBodega.SelectedIndex = 0;
            txtCapacidadMaxima.Text = "0";
            txtCapacidadActual.Text = "0";
            txtCostoUnitario.Text = "0";
            txtDescripcion.Text = "";
            txtTemperaturaPromedio.Text = "0";
            validacionNumeric(nudCantidad, false);
            nudCantidad.Value = 0;
            btnAgregarDetalleMovimiento.Enabled = false;
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Seguro que quiere eliminar el detalle?", 
                "Eliminar detalle",
                MessageBoxButtons.YesNo
            );
            DataGridViewRow row = dgvDetallesMovimientos.CurrentRow;
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(row.Cells["id_detalle"].Value);
                //se valida si ya no hay detalles
                if(id == 0)
                {
                    MessageBox.Show(
                        "No se puede borrar este detalle", 
                        "Error borrar detalle",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    //Deshabilito botón para eliminar detalle
                    btnEliminarDetalle.Enabled = false;
                }
                else
                {
                    //Proceso de resta en la venta total
                    costoTotalConIva = Convert.ToDouble(txtVentaTotalConIva.Text.Trim());
                    double cantidadDetalle = Convert.ToDouble(row.Cells["cantidad"].Value);
                    double costoUnitarioDetalle = Convert.ToDouble(row.Cells["costo_unitario"].Value);
                    double costoTotalDetalle = (cantidadDetalle * costoUnitarioDetalle);
                    double costoDescontar = (costoTotalConIva - costoTotalDetalle);
                    double costoDescontarSinIVA = (costoDescontar / 1.13);
                    txtVentaTotalConIva.Text = Convert.ToString(costoDescontar);
                    txtVentaTotalSinIva.Text = Convert.ToString(costoDescontarSinIVA);
                    //Elimino fila seleccionada del dataGridView
                    dgvDetallesMovimientos.Rows.RemoveAt(dgvDetallesMovimientos.CurrentRow.Index);
                    MessageBox.Show(
                        "Se eliminó el detalle con numero: " + id,
                        "Eliminar Registro del Detalle",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );
                }
            }
        }
       
        private void btnCancelarMovimiento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearMovimiento_Click(object sender, EventArgs e)
        {
            //Crear Objeto de movimientos
            
            objMovimientos = new movimientos();
            objMovimientos.id_tipo_movimiento = Convert.ToInt32(tipoMovimiento);
            objMovimientos.fecha = Convert.ToDateTime(txtFecha.Text.Trim());
            objMovimientos.hora = DateTime.Now.TimeOfDay;
            objMovimientos.descripcion = nombreMovimiento.ToString();
            objMovimientos.costo_total_con_iva = Convert.ToDecimal(txtVentaTotalConIva.Text.Trim());
            objMovimientos.costo_total_sin_iva = Convert.ToDecimal(txtVentaTotalSinIva.Text.Trim());
            objMovimientos.id_usuario = Convert.ToInt32(txtIdUsuario.Text.Trim());
            objMovimientos.estado = 1;

            if(tipoMovimiento == "1")
            {
                objMovimientos.id_proveedor = Convert.ToInt32(cmbAuxiliar.SelectedValue.ToString());
            }

            var confirmacionMovimiento = MovimientosBL.crearMovimiento(objMovimientos);
            int idMovimiento = Convert.ToInt32(confirmacionMovimiento.id_movimiento);
            if(idMovimiento > 1)
            {
                bool detalleCreado = crearDetalleMovimiento(confirmacionMovimiento);

                if(detalleCreado)
                {
                    MessageBox.Show(
                        "Movimiento Generado correctamente",
                        "Movimiento Creado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Error al crear este movimiento ",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );
                }
            }
        }

        private bool crearDetalleMovimiento(movimientos objMovimientos)
        {
            bool bandera = false;
            decimal existenciaTotal = 0;
            decimal existenciaAnterior = 0;
            decimal cantidadMovimiento = 0;
            //Recorre las filas..
            foreach (DataGridViewRow fila in dgvDetallesMovimientos.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    try
                    {
                        //Crear Objeto de detalles_movimientos
                        objDetallesMovimientos = new detalles_movimientos();
                        cantidadMovimiento = Convert.ToDecimal(fila.Cells["cantidad"].Value.ToString());
                        existenciaTotal = Convert.ToDecimal(fila.Cells["existencia_total"].Value.ToString());
                        existenciaAnterior = (existenciaTotal - cantidadMovimiento);

                        objDetallesMovimientos.id_movimiento = Convert.ToInt32(objMovimientos.id_movimiento.ToString());
                        objDetallesMovimientos.id_producto = Convert.ToInt32(fila.Cells["id_producto"].Value.ToString());
                        objDetallesMovimientos.id_bodega = Convert.ToInt32(fila.Cells["id_bodega"].Value.ToString());
                        objDetallesMovimientos.fecha_vencimiento = Convert.ToDateTime(fila.Cells["fecha_vencimiento"].Value.ToString());
                        objDetallesMovimientos.lote = Convert.ToString(fila.Cells["lote"].Value.ToString());
                        objDetallesMovimientos.cantidad = cantidadMovimiento;
                        objDetallesMovimientos.costo_unitario = Convert.ToDecimal(fila.Cells["costo_unitario"].Value.ToString());
                        objDetallesMovimientos.costo_unitario_promedio = Convert.ToDecimal(fila.Cells["costo_unitario_promedio"].Value.ToString());
                        objDetallesMovimientos.existencia_anterior = existenciaAnterior;
                        objDetallesMovimientos.existencia_total = existenciaTotal;
                        objDetallesMovimientos.estado = Convert.ToInt32(fila.Cells["estado"].Value.ToString());

                        detalles_movimientos respuestaDetalle = MovimientosBL.crearDetalleMovimientos(objDetallesMovimientos, objMovimientos);
                        Debug.Write(respuestaDetalle);
                        if (respuestaDetalle == null)
                        {
                            bandera = false;
                        }
                        else
                        {
                            bandera = true;
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(
                            "Error al crear detalle de este movimiento " + error,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation
                        );
                        break;
                    }
                }
            }
            return bandera;
        }
    }
}
