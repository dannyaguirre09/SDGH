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
    
    public partial class DETALLE_DESGLOSE_MEDICAMENTOS
    {
        public int DTDCODIGOI { get; set; }
        public Nullable<int> INMCODIGOI { get; set; }
        public Nullable<int> DSMCODIGOI { get; set; }
        public Nullable<int> DTDCANTIDAD { get; set; }
        public Nullable<decimal> DTDVALOR { get; set; }
    
        public virtual DESGLOSE_MEDICAMENTOS DESGLOSE_MEDICAMENTOS { get; set; }
        public virtual INSUMOS_MEDICOS INSUMOS_MEDICOS { get; set; }
    }
}
