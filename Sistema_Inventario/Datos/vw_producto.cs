//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_producto
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fecha_creacioon { get; set; }
        public Nullable<System.TimeSpan> hora_creacion { get; set; }
        public Nullable<int> dias { get; set; }
        public string categoria { get; set; }
        public string proveedor { get; set; }
    }
}