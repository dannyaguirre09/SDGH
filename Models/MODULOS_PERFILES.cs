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
    
    public partial class MODULOS_PERFILES
    {
        public int MOPCODIGOI { get; set; }
        public int MODCODIGOI { get; set; }
        public int PERCODIGOI { get; set; }
    
        public virtual MODULOS MODULOS { get; set; }
        public virtual PERFILES PERFILES { get; set; }
    }
}
