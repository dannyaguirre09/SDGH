﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SDHCEntities : DbContext
    {
        public SDHCEntities()
            : base("name=SDHCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BANCO> BANCO { get; set; }
        public virtual DbSet<CLIENTEEXTERNO> CLIENTEEXTERNO { get; set; }
        public virtual DbSet<CONTROL> CONTROL { get; set; }
        public virtual DbSet<CUENTA_BANCO> CUENTA_BANCO { get; set; }
        public virtual DbSet<DESGLOSE_MEDICAMENTOS> DESGLOSE_MEDICAMENTOS { get; set; }
        public virtual DbSet<DETALLE_DESGLOSE_MEDICAMENTOS> DETALLE_DESGLOSE_MEDICAMENTOS { get; set; }
        public virtual DbSet<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }
        public virtual DbSet<DETALLE_LIQUIDACION> DETALLE_LIQUIDACION { get; set; }
        public virtual DbSet<DETALLE_ORDEN_CIRUGIA> DETALLE_ORDEN_CIRUGIA { get; set; }
        public virtual DbSet<DOCUMENTOS> DOCUMENTOS { get; set; }
        public virtual DbSet<EMPRESA_CONVENIO> EMPRESA_CONVENIO { get; set; }
        public virtual DbSet<ENFERMEDADES_ACTUALES> ENFERMEDADES_ACTUALES { get; set; }
        public virtual DbSet<ESPECIALISTA> ESPECIALISTA { get; set; }
        public virtual DbSet<FORMA_PAGO> FORMA_PAGO { get; set; }
        public virtual DbSet<IMPUESTOS> IMPUESTOS { get; set; }
        public virtual DbSet<INSUMOS_MEDICOS> INSUMOS_MEDICOS { get; set; }
        public virtual DbSet<LENTES> LENTES { get; set; }
        public virtual DbSet<LIQUIDACION_FACTURAS> LIQUIDACION_FACTURAS { get; set; }
        public virtual DbSet<MENUS> MENUS { get; set; }
        public virtual DbSet<MODULOS> MODULOS { get; set; }
        public virtual DbSet<MODULOS_PERFILES> MODULOS_PERFILES { get; set; }
        public virtual DbSet<NOTAS_POSTQUIRURGICAS> NOTAS_POSTQUIRURGICAS { get; set; }
        public virtual DbSet<OPERADOR> OPERADOR { get; set; }
        public virtual DbSet<ORDEN_CIRUGIA> ORDEN_CIRUGIA { get; set; }
        public virtual DbSet<PACIENTE> PACIENTE { get; set; }
        public virtual DbSet<PARAMETROS> PARAMETROS { get; set; }
        public virtual DbSet<PERFILES> PERFILES { get; set; }
        public virtual DbSet<PIE_DESGLOSE> PIE_DESGLOSE { get; set; }
        public virtual DbSet<PIE_FACTURA> PIE_FACTURA { get; set; }
        public virtual DbSet<PRESCRIPCIONES> PRESCRIPCIONES { get; set; }
        public virtual DbSet<PROGRAMA> PROGRAMA { get; set; }
        public virtual DbSet<PROVEEDORES> PROVEEDORES { get; set; }
        public virtual DbSet<SERVICIO_EMPRESA_CONVENIO> SERVICIO_EMPRESA_CONVENIO { get; set; }
        public virtual DbSet<SERVICIOS> SERVICIOS { get; set; }
        public virtual DbSet<TARJETA_CREDITO> TARJETA_CREDITO { get; set; }
        public virtual DbSet<TIPO_CIRUGIA> TIPO_CIRUGIA { get; set; }
        public virtual DbSet<TIPOESPECIALISTA> TIPOESPECIALISTA { get; set; }
        public virtual DbSet<TIPOS> TIPOS { get; set; }
        public virtual DbSet<TIPOS_EXAMENES_FISICOS> TIPOS_EXAMENES_FISICOS { get; set; }
        public virtual DbSet<UNIDADES> UNIDADES { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<USUARIOS_PERFILES> USUARIOS_PERFILES { get; set; }
        public virtual DbSet<ORDEN_ESPECIALISTA> ORDEN_ESPECIALISTA { get; set; }
        public virtual DbSet<SRIRetencionCompraDetalle> SRIRetencionCompraDetalle { get; set; }
        public virtual DbSet<SRIRetencionCompraEncab> SRIRetencionCompraEncab { get; set; }
        public virtual DbSet<TEMP_ORDENES> TEMP_ORDENES { get; set; }
        public virtual DbSet<HISTORIA_CLINICA> HISTORIA_CLINICA { get; set; }
        public virtual DbSet<CONSULTAS> CONSULTAS { get; set; }
        public virtual DbSet<LISTA_ANTECEDENTES> LISTA_ANTECEDENTES { get; set; }
        public virtual DbSet<TIPOS_ANTECEDENTES> TIPOS_ANTECEDENTES { get; set; }
        public virtual DbSet<HISTORIA_ANTECEDENTES> HISTORIA_ANTECEDENTES { get; set; }
        public virtual DbSet<HISTORIA_CLINICA_SIGNOS_VITALES> HISTORIA_CLINICA_SIGNOS_VITALES { get; set; }
        public virtual DbSet<SIGNOS_VITALES> SIGNOS_VITALES { get; set; }
        public virtual DbSet<FACTURA> FACTURA { get; set; }
        public virtual DbSet<FACTURA_RETENCION> FACTURA_RETENCION { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<EXAMENES_FISICOS> EXAMENES_FISICOS { get; set; }
        public virtual DbSet<DIAGNOSTICOS> DIAGNOSTICOS { get; set; }
        public virtual DbSet<INDICES_CIE_PRINCIPALES> INDICES_CIE_PRINCIPALES { get; set; }
        public virtual DbSet<INDICES_CIE_SECUNDARIOS> INDICES_CIE_SECUNDARIOS { get; set; }
    
        public virtual ObjectResult<spInsert_HistoriaClinica_Result> spInsert_HistoriaClinica(Nullable<int> pCTCODIGOI, Nullable<int> hSCNUMERO, Nullable<System.DateTime> hSCFECHAAPERTURA, Nullable<System.DateTime> hSCHORA_APERTURA, string oBSERVACIONES)
        {
            var pCTCODIGOIParameter = pCTCODIGOI.HasValue ?
                new ObjectParameter("PCTCODIGOI", pCTCODIGOI) :
                new ObjectParameter("PCTCODIGOI", typeof(int));
    
            var hSCNUMEROParameter = hSCNUMERO.HasValue ?
                new ObjectParameter("HSCNUMERO", hSCNUMERO) :
                new ObjectParameter("HSCNUMERO", typeof(int));
    
            var hSCFECHAAPERTURAParameter = hSCFECHAAPERTURA.HasValue ?
                new ObjectParameter("HSCFECHAAPERTURA", hSCFECHAAPERTURA) :
                new ObjectParameter("HSCFECHAAPERTURA", typeof(System.DateTime));
    
            var hSCHORA_APERTURAParameter = hSCHORA_APERTURA.HasValue ?
                new ObjectParameter("HSCHORA_APERTURA", hSCHORA_APERTURA) :
                new ObjectParameter("HSCHORA_APERTURA", typeof(System.DateTime));
    
            var oBSERVACIONESParameter = oBSERVACIONES != null ?
                new ObjectParameter("OBSERVACIONES", oBSERVACIONES) :
                new ObjectParameter("OBSERVACIONES", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spInsert_HistoriaClinica_Result>("spInsert_HistoriaClinica", pCTCODIGOIParameter, hSCNUMEROParameter, hSCFECHAAPERTURAParameter, hSCHORA_APERTURAParameter, oBSERVACIONESParameter);
        }
    
        public virtual int spInsert_HistoriaClinica_Actualizado(Nullable<int> pCTCODIGOI, Nullable<int> hSCNUMERO, Nullable<System.DateTime> hSCFECHAAPERTURA, Nullable<System.DateTime> hSCHORA_APERTURA, string oBSERVACIONES)
        {
            var pCTCODIGOIParameter = pCTCODIGOI.HasValue ?
                new ObjectParameter("PCTCODIGOI", pCTCODIGOI) :
                new ObjectParameter("PCTCODIGOI", typeof(int));
    
            var hSCNUMEROParameter = hSCNUMERO.HasValue ?
                new ObjectParameter("HSCNUMERO", hSCNUMERO) :
                new ObjectParameter("HSCNUMERO", typeof(int));
    
            var hSCFECHAAPERTURAParameter = hSCFECHAAPERTURA.HasValue ?
                new ObjectParameter("HSCFECHAAPERTURA", hSCFECHAAPERTURA) :
                new ObjectParameter("HSCFECHAAPERTURA", typeof(System.DateTime));
    
            var hSCHORA_APERTURAParameter = hSCHORA_APERTURA.HasValue ?
                new ObjectParameter("HSCHORA_APERTURA", hSCHORA_APERTURA) :
                new ObjectParameter("HSCHORA_APERTURA", typeof(System.DateTime));
    
            var oBSERVACIONESParameter = oBSERVACIONES != null ?
                new ObjectParameter("OBSERVACIONES", oBSERVACIONES) :
                new ObjectParameter("OBSERVACIONES", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsert_HistoriaClinica_Actualizado", pCTCODIGOIParameter, hSCNUMEROParameter, hSCFECHAAPERTURAParameter, hSCHORA_APERTURAParameter, oBSERVACIONESParameter);
        }
    
        public virtual int spUpdate_HistoriaClinica(Nullable<int> hSCCODIGOI, string oBSERVACIONES)
        {
            var hSCCODIGOIParameter = hSCCODIGOI.HasValue ?
                new ObjectParameter("HSCCODIGOI", hSCCODIGOI) :
                new ObjectParameter("HSCCODIGOI", typeof(int));
    
            var oBSERVACIONESParameter = oBSERVACIONES != null ?
                new ObjectParameter("OBSERVACIONES", oBSERVACIONES) :
                new ObjectParameter("OBSERVACIONES", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdate_HistoriaClinica", hSCCODIGOIParameter, oBSERVACIONESParameter);
        }
    
        public virtual int spInsert_HistoriaAntecedentes(Nullable<int> hSCCODIGOI, Nullable<int> lSACODIGOI, Nullable<bool> hANRESPUESTA, string hANOBSERVACION)
        {
            var hSCCODIGOIParameter = hSCCODIGOI.HasValue ?
                new ObjectParameter("HSCCODIGOI", hSCCODIGOI) :
                new ObjectParameter("HSCCODIGOI", typeof(int));
    
            var lSACODIGOIParameter = lSACODIGOI.HasValue ?
                new ObjectParameter("LSACODIGOI", lSACODIGOI) :
                new ObjectParameter("LSACODIGOI", typeof(int));
    
            var hANRESPUESTAParameter = hANRESPUESTA.HasValue ?
                new ObjectParameter("HANRESPUESTA", hANRESPUESTA) :
                new ObjectParameter("HANRESPUESTA", typeof(bool));
    
            var hANOBSERVACIONParameter = hANOBSERVACION != null ?
                new ObjectParameter("HANOBSERVACION", hANOBSERVACION) :
                new ObjectParameter("HANOBSERVACION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsert_HistoriaAntecedentes", hSCCODIGOIParameter, lSACODIGOIParameter, hANRESPUESTAParameter, hANOBSERVACIONParameter);
        }
    
        public virtual ObjectResult<spSelect_Historia_antecedentes_Result> spSelect_Historia_antecedentes(Nullable<int> lSACODIGOI, Nullable<int> hSCCODIGOI)
        {
            var lSACODIGOIParameter = lSACODIGOI.HasValue ?
                new ObjectParameter("LSACODIGOI", lSACODIGOI) :
                new ObjectParameter("LSACODIGOI", typeof(int));
    
            var hSCCODIGOIParameter = hSCCODIGOI.HasValue ?
                new ObjectParameter("HSCCODIGOI", hSCCODIGOI) :
                new ObjectParameter("HSCCODIGOI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_Historia_antecedentes_Result>("spSelect_Historia_antecedentes", lSACODIGOIParameter, hSCCODIGOIParameter);
        }
    
        public virtual ObjectResult<spSelect_HistoriaSignosVitales_Result> spSelect_HistoriaSignosVitales(Nullable<int> hSCCODIGOI)
        {
            var hSCCODIGOIParameter = hSCCODIGOI.HasValue ?
                new ObjectParameter("HSCCODIGOI", hSCCODIGOI) :
                new ObjectParameter("HSCCODIGOI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_HistoriaSignosVitales_Result>("spSelect_HistoriaSignosVitales", hSCCODIGOIParameter);
        }
    
        public virtual int spInsert_SignosVitales(Nullable<int> hsvcodigoi, Nullable<int> sgvcodigoi, Nullable<int> hsccodigoi, string hsvvalores)
        {
            var hsvcodigoiParameter = hsvcodigoi.HasValue ?
                new ObjectParameter("hsvcodigoi", hsvcodigoi) :
                new ObjectParameter("hsvcodigoi", typeof(int));
    
            var sgvcodigoiParameter = sgvcodigoi.HasValue ?
                new ObjectParameter("sgvcodigoi", sgvcodigoi) :
                new ObjectParameter("sgvcodigoi", typeof(int));
    
            var hsccodigoiParameter = hsccodigoi.HasValue ?
                new ObjectParameter("hsccodigoi", hsccodigoi) :
                new ObjectParameter("hsccodigoi", typeof(int));
    
            var hsvvaloresParameter = hsvvalores != null ?
                new ObjectParameter("hsvvalores", hsvvalores) :
                new ObjectParameter("hsvvalores", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsert_SignosVitales", hsvcodigoiParameter, sgvcodigoiParameter, hsccodigoiParameter, hsvvaloresParameter);
        }
    
        public virtual ObjectResult<PA_Inicio_Usuarios_Web_Result> PA_Inicio_Usuarios_Web(string uSRLOGIN, string uSRPASSWORD)
        {
            var uSRLOGINParameter = uSRLOGIN != null ?
                new ObjectParameter("USRLOGIN", uSRLOGIN) :
                new ObjectParameter("USRLOGIN", typeof(string));
    
            var uSRPASSWORDParameter = uSRPASSWORD != null ?
                new ObjectParameter("USRPASSWORD", uSRPASSWORD) :
                new ObjectParameter("USRPASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_Inicio_Usuarios_Web_Result>("PA_Inicio_Usuarios_Web", uSRLOGINParameter, uSRPASSWORDParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int spInsert_ExamenFisico(Nullable<int> eXFCODIGOI, Nullable<int> tPFCODIGOI, Nullable<int> hSCCODIGOI, string descripcion)
        {
            var eXFCODIGOIParameter = eXFCODIGOI.HasValue ?
                new ObjectParameter("EXFCODIGOI", eXFCODIGOI) :
                new ObjectParameter("EXFCODIGOI", typeof(int));
    
            var tPFCODIGOIParameter = tPFCODIGOI.HasValue ?
                new ObjectParameter("TPFCODIGOI", tPFCODIGOI) :
                new ObjectParameter("TPFCODIGOI", typeof(int));
    
            var hSCCODIGOIParameter = hSCCODIGOI.HasValue ?
                new ObjectParameter("HSCCODIGOI", hSCCODIGOI) :
                new ObjectParameter("HSCCODIGOI", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsert_ExamenFisico", eXFCODIGOIParameter, tPFCODIGOIParameter, hSCCODIGOIParameter, descripcionParameter);
        }
    
        public virtual int spInsert_Diagnostico(Nullable<int> dGNCODIGOI, Nullable<int> hSCCODIGOI, Nullable<int> iNSCODIGOI, string dGNOBSERVACION, string dGNTIPO)
        {
            var dGNCODIGOIParameter = dGNCODIGOI.HasValue ?
                new ObjectParameter("DGNCODIGOI", dGNCODIGOI) :
                new ObjectParameter("DGNCODIGOI", typeof(int));
    
            var hSCCODIGOIParameter = hSCCODIGOI.HasValue ?
                new ObjectParameter("HSCCODIGOI", hSCCODIGOI) :
                new ObjectParameter("HSCCODIGOI", typeof(int));
    
            var iNSCODIGOIParameter = iNSCODIGOI.HasValue ?
                new ObjectParameter("INSCODIGOI", iNSCODIGOI) :
                new ObjectParameter("INSCODIGOI", typeof(int));
    
            var dGNOBSERVACIONParameter = dGNOBSERVACION != null ?
                new ObjectParameter("DGNOBSERVACION", dGNOBSERVACION) :
                new ObjectParameter("DGNOBSERVACION", typeof(string));
    
            var dGNTIPOParameter = dGNTIPO != null ?
                new ObjectParameter("DGNTIPO", dGNTIPO) :
                new ObjectParameter("DGNTIPO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsert_Diagnostico", dGNCODIGOIParameter, hSCCODIGOIParameter, iNSCODIGOIParameter, dGNOBSERVACIONParameter, dGNTIPOParameter);
        }
    }
}
