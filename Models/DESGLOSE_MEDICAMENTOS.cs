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
    
    public partial class DESGLOSE_MEDICAMENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DESGLOSE_MEDICAMENTOS()
        {
            this.DETALLE_DESGLOSE_MEDICAMENTOS = new HashSet<DETALLE_DESGLOSE_MEDICAMENTOS>();
            this.PIE_DESGLOSE = new HashSet<PIE_DESGLOSE>();
        }
    
        public int DSMCODIGOI { get; set; }
        public Nullable<int> ORCCODIGOI { get; set; }
        public Nullable<System.DateTime> DSMFECHA { get; set; }
        public Nullable<int> DSMEDADPACIENTE { get; set; }
        public string DSMHABITACION { get; set; }
        public string DSMTIPOANESTESIA { get; set; }
        public Nullable<bool> DSMESTADO { get; set; }
    
        public virtual ORDEN_CIRUGIA ORDEN_CIRUGIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_DESGLOSE_MEDICAMENTOS> DETALLE_DESGLOSE_MEDICAMENTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PIE_DESGLOSE> PIE_DESGLOSE { get; set; }
    }
}
