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
    
    public partial class PROCESO_CLASIFICACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROCESO_CLASIFICACION()
        {
            this.CONTROLES_FLOR_NACIONAL = new HashSet<CONTROLES_FLOR_NACIONAL>();
            this.DETALLE_FLOR_CLASIFICADA = new HashSet<DETALLE_FLOR_CLASIFICADA>();
        }
    
        public int PRCCODIGOI { get; set; }
        public string PRCOBSERVACION { get; set; }
        public System.DateTime PRCFECHA { get; set; }
        public Nullable<bool> PRCESTADO { get; set; }
        public int PCRIDENTIFICADOR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTROLES_FLOR_NACIONAL> CONTROLES_FLOR_NACIONAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_FLOR_CLASIFICADA> DETALLE_FLOR_CLASIFICADA { get; set; }
    }
}
