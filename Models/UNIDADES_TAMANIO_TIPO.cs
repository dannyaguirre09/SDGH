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
    
    public partial class UNIDADES_TAMANIO_TIPO
    {
        public int UTTCODIGOI { get; set; }
        public int UNDCODIGOI { get; set; }
        public int TPFCODIGOI { get; set; }
        public int TMTCODIGOI { get; set; }
    
        public virtual TAMANO_TALLOS TAMANO_TALLOS { get; set; }
        public virtual TIPOS_FLORES TIPOS_FLORES { get; set; }
        public virtual UNIDADES UNIDADES { get; set; }
    }
}