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
    using System.Collections.Generic;
    
    public partial class sub_clasificaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sub_clasificaciones()
        {
            this.productos = new HashSet<productos>();
        }
    
        public int id_sub_clasificacion { get; set; }
        public Nullable<int> id_clasificacion { get; set; }
        public string sub_clasificacion { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual clasificacion clasificacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productos> productos { get; set; }
    }
}
