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
    
    public partial class FACTURA_RETENCION
    {
        public int FRTCODIGOI { get; set; }
        public long FCTCODIGOI { get; set; }
        public int IMPCODIGOI { get; set; }
        public string FRTNUMERO { get; set; }
        public double FRTBASE_IMPONIBLE { get; set; }
        public double FRTVALOR_RETENIDO { get; set; }
        public Nullable<System.DateTime> FRTFECHA { get; set; }
    
        public virtual FACTURA FACTURA { get; set; }
        public virtual IMPUESTOS IMPUESTOS { get; set; }
    }
}