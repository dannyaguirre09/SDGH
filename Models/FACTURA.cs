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
    
    public partial class FACTURA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACTURA()
        {
            this.DETALLE_FACTURA = new HashSet<DETALLE_FACTURA>();
            this.FACTURA_RETENCION = new HashSet<FACTURA_RETENCION>();
            this.PIE_FACTURA = new HashSet<PIE_FACTURA>();
        }
    
        public long FCTCODIGOI { get; set; }
        public int ORCCODIGOI { get; set; }
        public int CLECODIGOI { get; set; }
        public string CODOPER { get; set; }
        public System.DateTime FCTFECHA { get; set; }
        public string FCTIDENTC { get; set; }
        public string FCTNOMBREC { get; set; }
        public string FCTDIRECCC { get; set; }
        public string FCTTELEFOC { get; set; }
        public short FCTESTADOC { get; set; }
        public string FCTNUMFACT { get; set; }
        public string FCTIDCLIENTE { get; set; }
        public string FCTOBSERVC { get; set; }
        public string FCTMAILC { get; set; }
        public Nullable<decimal> FCTNUMSEC { get; set; }
        public string FCTNOMPACIENTE { get; set; }
        public Nullable<bool> FCTAPLICADORET { get; set; }
        public Nullable<bool> FCTLIQUIDADO { get; set; }
    
        public virtual CLIENTEEXTERNO CLIENTEEXTERNO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }
        public virtual OPERADOR OPERADOR { get; set; }
        public virtual ORDEN_CIRUGIA ORDEN_CIRUGIA { get; set; }
        public virtual ORDEN_CIRUGIA ORDEN_CIRUGIA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA_RETENCION> FACTURA_RETENCION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PIE_FACTURA> PIE_FACTURA { get; set; }
    }
}
