//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppInventario.Models
{
    using System;
    
    public partial class sp_consulta_producto_Result
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public Nullable<System.TimeSpan> hora_creacion { get; set; }
        public Nullable<decimal> costo_unitario_con_iva { get; set; }
        public Nullable<int> dias { get; set; }
        public string nombre_clasificacion { get; set; }
        public string sub_clasificacion { get; set; }
        public string nombre_proveedor { get; set; }
        public string direccion { get; set; }
        public string nit { get; set; }
        public string nrc { get; set; }
        public string correo { get; set; }
        public string razon_social { get; set; }
        public string tipo_proveedor { get; set; }
    }
}
