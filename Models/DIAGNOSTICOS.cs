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
    
    public partial class DIAGNOSTICOS
    {
        public int DGNCODIGOI { get; set; }
        public Nullable<int> HSCCODIGOI { get; set; }
        public Nullable<int> INSCODIGOI { get; set; }
        public Nullable<System.DateTime> DGNFECHA { get; set; }
        public string DGNOBSERVACION { get; set; }
        public string DGNTIPO { get; set; }
    
        public virtual INDICES_CIE_SECUNDARIOS INDICES_CIE_SECUNDARIOS { get; set; }
        public virtual HISTORIA_CLINICA HISTORIA_CLINICA { get; set; }
    }
}