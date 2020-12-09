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
    
    public partial class HISTORIA_CLINICA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HISTORIA_CLINICA()
        {
            this.DIAGNOSTICOS = new HashSet<DIAGNOSTICOS>();
            this.DOCUMENTOS = new HashSet<DOCUMENTOS>();
            this.ENFERMEDADES_ACTUALES = new HashSet<ENFERMEDADES_ACTUALES>();
            this.NOTAS_POSTQUIRURGICAS = new HashSet<NOTAS_POSTQUIRURGICAS>();
            this.PRESCRIPCIONES = new HashSet<PRESCRIPCIONES>();
            this.CONSULTAS = new HashSet<CONSULTAS>();
            this.HISTORIA_ANTECEDENTES = new HashSet<HISTORIA_ANTECEDENTES>();
            this.HISTORIA_CLINICA_SIGNOS_VITALES = new HashSet<HISTORIA_CLINICA_SIGNOS_VITALES>();
            this.EXAMENES_FISICOS = new HashSet<EXAMENES_FISICOS>();
        }
    
        public int HSCCODIGOI { get; set; }
        public Nullable<int> PCTCODIGOI { get; set; }
        public Nullable<decimal> HSCNUMERO { get; set; }
        public Nullable<System.DateTime> HSCFECHAAPERTURA { get; set; }
        public Nullable<System.DateTime> HSCHORA_APERTURA { get; set; }
        public string OBSERVACIONES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIAGNOSTICOS> DIAGNOSTICOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENTOS> DOCUMENTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENFERMEDADES_ACTUALES> ENFERMEDADES_ACTUALES { get; set; }
        public virtual PACIENTE PACIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTAS_POSTQUIRURGICAS> NOTAS_POSTQUIRURGICAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESCRIPCIONES> PRESCRIPCIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONSULTAS> CONSULTAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORIA_ANTECEDENTES> HISTORIA_ANTECEDENTES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORIA_CLINICA_SIGNOS_VITALES> HISTORIA_CLINICA_SIGNOS_VITALES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXAMENES_FISICOS> EXAMENES_FISICOS { get; set; }
    }
}
