//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalles_movimientos
    {
        public int id_detalle_movimiento { get; set; }
        public Nullable<System.DateTime> fecha_vencimiento { get; set; }
        public string lote { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<decimal> costo_unitario { get; set; }
        public Nullable<decimal> costo_unitario_promedio { get; set; }
        public Nullable<decimal> existencia_anterior { get; set; }
        public Nullable<decimal> existencia_total { get; set; }
        public Nullable<int> estado { get; set; }
        public Nullable<int> id_producto { get; set; }
        public Nullable<int> id_movimiento { get; set; }
        public Nullable<int> id_bodega { get; set; }
        public Nullable<int> id_bodega_traslado { get; set; }
    
        public virtual bodegas bodegas { get; set; }
        public virtual movimientos movimientos { get; set; }
        public virtual productos productos { get; set; }
    }
}
