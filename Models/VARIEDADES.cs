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
    
    public partial class VARIEDADES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VARIEDADES()
        {
            this.CONTROLES_FLOR_NACIONAL = new HashSet<CONTROLES_FLOR_NACIONAL>();
            this.BLOQUES_VARIEDADES = new HashSet<BLOQUES_VARIEDADES>();
            this.INGRESO_PRODUCCION = new HashSet<INGRESO_PRODUCCION>();
            this.DETALLE_FLOR_CLASIFICADA = new HashSet<DETALLE_FLOR_CLASIFICADA>();
        }
    
        public int VRDCODIGOI { get; set; }
        public string VRDIDENTIFIC { get; set; }
        public string VRDNOMBREC { get; set; }
        public string VRDCOLOR { get; set; }
        public bool VRDESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTROLES_FLOR_NACIONAL> CONTROLES_FLOR_NACIONAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BLOQUES_VARIEDADES> BLOQUES_VARIEDADES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESO_PRODUCCION> INGRESO_PRODUCCION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_FLOR_CLASIFICADA> DETALLE_FLOR_CLASIFICADA { get; set; }
    }
}