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
    
    public partial class TIPOS_FLORES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPOS_FLORES()
        {
            this.DETALLE_FLOR_CLASIFICADA = new HashSet<DETALLE_FLOR_CLASIFICADA>();
            this.UNIDADES_TAMANIO_TIPO = new HashSet<UNIDADES_TAMANIO_TIPO>();
        }
    
        public int TPFCODIGOI { get; set; }
        public string TPFDESCRIPCION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_FLOR_CLASIFICADA> DETALLE_FLOR_CLASIFICADA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNIDADES_TAMANIO_TIPO> UNIDADES_TAMANIO_TIPO { get; set; }
    }
}
