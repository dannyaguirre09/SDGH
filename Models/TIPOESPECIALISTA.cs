//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysFloricola.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPOESPECIALISTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPOESPECIALISTA()
        {
            this.ORDEN_ESPECIALISTA = new HashSet<ORDEN_ESPECIALISTA>();
        }
    
        public int TPECODIGOI { get; set; }
        public string TPEDESCRIPC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEN_ESPECIALISTA> ORDEN_ESPECIALISTA { get; set; }
    }
}