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
    
    public partial class USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIOS()
        {
            this.USUARIOS_PERFILES = new HashSet<USUARIOS_PERFILES>();
        }
    
        public int USRCODIGOI { get; set; }
        public string USRCEDULAC { get; set; }
        public string USRAPELLIDOP { get; set; }
        public string USRAPELLIDOM { get; set; }
        public string USRNOMBREC { get; set; }
        public string USRLOGIN { get; set; }
        public string USRPASSWORD { get; set; }
        public bool USRESTADO { get; set; }
        public Nullable<bool> USRESTADOCAMBIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIOS_PERFILES> USUARIOS_PERFILES { get; set; }
    }
}
