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
    
    public partial class BLOQUES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BLOQUES()
        {
            this.BLOQUES_VARIEDADES = new HashSet<BLOQUES_VARIEDADES>();
            this.INGRESO_PRODUCCION = new HashSet<INGRESO_PRODUCCION>();
        }
    
        public int BLQCODIGOI { get; set; }
        public int FNCCODIGOI { get; set; }
        public int BLQIDENTIFIC { get; set; }
        public int BLQNUMCAMAS { get; set; }
    
        public virtual FINCAS FINCAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BLOQUES_VARIEDADES> BLOQUES_VARIEDADES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESO_PRODUCCION> INGRESO_PRODUCCION { get; set; }
    }
}