//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipo_bodega_bodegas
    {
        public int id_tipo_bodega_bodegas { get; set; }
        public Nullable<int> id_tipo_bodega { get; set; }
        public Nullable<int> id_bodega { get; set; }
        public Nullable<decimal> temperatura_promedio { get; set; }
        public Nullable<decimal> capacidad_maxima { get; set; }
        public Nullable<decimal> capacidad_actual { get; set; }
    
        public virtual bodegas bodegas { get; set; }
        public virtual tipo_bodega tipo_bodega { get; set; }
    }
}
