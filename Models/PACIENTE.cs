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
    
    public partial class PACIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PACIENTE()
        {
            this.ORDEN_CIRUGIA = new HashSet<ORDEN_CIRUGIA>();
            this.HISTORIA_CLINICA = new HashSet<HISTORIA_CLINICA>();
        }
    
        public int PCTCODIGOI { get; set; }
        public string PCTCEDULAC { get; set; }
        public string PCTAPELLIDOP { get; set; }
        public string PCTAPELLIDOM { get; set; }
        public string PCTNOMBREC { get; set; }
        public System.DateTime PCTFECHAN { get; set; }
        public string PCTGENERO { get; set; }
        public string PCTTIPOS { get; set; }
        public string PCTDIRECCC { get; set; }
        public string PCTTELEFONOC { get; set; }
        public string PCTTELEFONCEL { get; set; }
        public string PCTCONTACTO { get; set; }
        public string PCTTELCONTACTO { get; set; }
        public string PCTMAILC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEN_CIRUGIA> ORDEN_CIRUGIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORIA_CLINICA> HISTORIA_CLINICA { get; set; }
    }
}