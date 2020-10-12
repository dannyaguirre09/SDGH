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
    
    public partial class BDFloricolaContext : DbContext
    {
        public BDFloricolaContext()
            : base("name=BDFloricolaContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BLOQUES> BLOQUES { get; set; }
        public virtual DbSet<CAUSAS> CAUSAS { get; set; }
        public virtual DbSet<EMPLEADOS> EMPLEADOS { get; set; }
        public virtual DbSet<FINCAS> FINCAS { get; set; }
        public virtual DbSet<MODULOS> MODULOS { get; set; }
        public virtual DbSet<MODULOS_PERFILES> MODULOS_PERFILES { get; set; }
        public virtual DbSet<PAICES> PAICES { get; set; }
        public virtual DbSet<PERFILES> PERFILES { get; set; }
        public virtual DbSet<PREENVIOS> PREENVIOS { get; set; }
        public virtual DbSet<TIPO_CAUSAS> TIPO_CAUSAS { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<USUARIOS_PERFILES> USUARIOS_PERFILES { get; set; }
        public virtual DbSet<VARIEDADES> VARIEDADES { get; set; }
        public virtual DbSet<EMPRESAS> EMPRESAS { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<CONTROLES_FLOR_NACIONAL> CONTROLES_FLOR_NACIONAL { get; set; }
        public virtual DbSet<TIPOS_FLORES> TIPOS_FLORES { get; set; }
        public virtual DbSet<ESTADOS> ESTADOS { get; set; }
        public virtual DbSet<BLOQUES_VARIEDADES> BLOQUES_VARIEDADES { get; set; }
        public virtual DbSet<INGRESO_PRODUCCION> INGRESO_PRODUCCION { get; set; }
        public virtual DbSet<CONTROL_PRODUCCION> CONTROL_PRODUCCION { get; set; }
        public virtual DbSet<DETALLE_FLOR_CLASIFICADA> DETALLE_FLOR_CLASIFICADA { get; set; }
        public virtual DbSet<DETALLES_PREENVIOS> DETALLES_PREENVIOS { get; set; }
        public virtual DbSet<PROCESO_CLASIFICACION> PROCESO_CLASIFICACION { get; set; }
        public virtual DbSet<TAMANO_TALLOS> TAMANO_TALLOS { get; set; }
        public virtual DbSet<UNIDADES> UNIDADES { get; set; }
        public virtual DbSet<UNIDADES_TAMANIO_TIPO> UNIDADES_TAMANIO_TIPO { get; set; }
        public virtual DbSet<CONCILIACION> CONCILIACION { get; set; }
    
        public virtual ObjectResult<spSelect_Bloque_variedades_Result> spSelect_Bloque_variedades(Nullable<int> blqCodigoI)
        {
            var blqCodigoIParameter = blqCodigoI.HasValue ?
                new ObjectParameter("blqCodigoI", blqCodigoI) :
                new ObjectParameter("blqCodigoI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_Bloque_variedades_Result>("spSelect_Bloque_variedades", blqCodigoIParameter);
        }
    
        public virtual ObjectResult<spSelect_Bloque_numeroCama_Result> spSelect_Bloque_numeroCama(Nullable<int> blqCodigo)
        {
            var blqCodigoParameter = blqCodigo.HasValue ?
                new ObjectParameter("blqCodigo", blqCodigo) :
                new ObjectParameter("blqCodigo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_Bloque_numeroCama_Result>("spSelect_Bloque_numeroCama", blqCodigoParameter);
        }
    
        public virtual ObjectResult<spSelect_flor_numerotallos_Result> spSelect_flor_numerotallos(Nullable<int> tpfCodigoI)
        {
            var tpfCodigoIParameter = tpfCodigoI.HasValue ?
                new ObjectParameter("tpfCodigoI", tpfCodigoI) :
                new ObjectParameter("tpfCodigoI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_flor_numerotallos_Result>("spSelect_flor_numerotallos", tpfCodigoIParameter);
        }
    
        public virtual ObjectResult<spSelect_tallos_unidad_Result> spSelect_tallos_unidad(Nullable<int> tpfCodigoI, Nullable<int> undCodigoI)
        {
            var tpfCodigoIParameter = tpfCodigoI.HasValue ?
                new ObjectParameter("tpfCodigoI", tpfCodigoI) :
                new ObjectParameter("tpfCodigoI", typeof(int));
    
            var undCodigoIParameter = undCodigoI.HasValue ?
                new ObjectParameter("undCodigoI", undCodigoI) :
                new ObjectParameter("undCodigoI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_tallos_unidad_Result>("spSelect_tallos_unidad", tpfCodigoIParameter, undCodigoIParameter);
        }
    
        public virtual ObjectResult<spSelect_tallos_unidad_tam_Result> spSelect_tallos_unidad_tam(Nullable<int> tpfCodigoI, Nullable<int> undCodigoI)
        {
            var tpfCodigoIParameter = tpfCodigoI.HasValue ?
                new ObjectParameter("tpfCodigoI", tpfCodigoI) :
                new ObjectParameter("tpfCodigoI", typeof(int));
    
            var undCodigoIParameter = undCodigoI.HasValue ?
                new ObjectParameter("undCodigoI", undCodigoI) :
                new ObjectParameter("undCodigoI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_tallos_unidad_tam_Result>("spSelect_tallos_unidad_tam", tpfCodigoIParameter, undCodigoIParameter);
        }
    
        public virtual int spInsert_detalle_flor_clasificada(Nullable<int> tMTCODIGOI, Nullable<int> uNDCODIGOI, Nullable<int> tPFCODIGOI, Nullable<int> vRDCODIGOI, Nullable<int> dTECANTIDAD, Nullable<System.DateTime> fecha)
        {
            var tMTCODIGOIParameter = tMTCODIGOI.HasValue ?
                new ObjectParameter("TMTCODIGOI", tMTCODIGOI) :
                new ObjectParameter("TMTCODIGOI", typeof(int));
    
            var uNDCODIGOIParameter = uNDCODIGOI.HasValue ?
                new ObjectParameter("UNDCODIGOI", uNDCODIGOI) :
                new ObjectParameter("UNDCODIGOI", typeof(int));
    
            var tPFCODIGOIParameter = tPFCODIGOI.HasValue ?
                new ObjectParameter("TPFCODIGOI", tPFCODIGOI) :
                new ObjectParameter("TPFCODIGOI", typeof(int));
    
            var vRDCODIGOIParameter = vRDCODIGOI.HasValue ?
                new ObjectParameter("VRDCODIGOI", vRDCODIGOI) :
                new ObjectParameter("VRDCODIGOI", typeof(int));
    
            var dTECANTIDADParameter = dTECANTIDAD.HasValue ?
                new ObjectParameter("DTECANTIDAD", dTECANTIDAD) :
                new ObjectParameter("DTECANTIDAD", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsert_detalle_flor_clasificada", tMTCODIGOIParameter, uNDCODIGOIParameter, tPFCODIGOIParameter, vRDCODIGOIParameter, dTECANTIDADParameter, fechaParameter);
        }
    
        public virtual ObjectResult<spVerificar_detalle_flor_Result> spVerificar_detalle_flor(Nullable<int> tPFCODIGOI, Nullable<int> uNDCODIGOI, Nullable<System.DateTime> fecha)
        {
            var tPFCODIGOIParameter = tPFCODIGOI.HasValue ?
                new ObjectParameter("TPFCODIGOI", tPFCODIGOI) :
                new ObjectParameter("TPFCODIGOI", typeof(int));
    
            var uNDCODIGOIParameter = uNDCODIGOI.HasValue ?
                new ObjectParameter("UNDCODIGOI", uNDCODIGOI) :
                new ObjectParameter("UNDCODIGOI", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spVerificar_detalle_flor_Result>("spVerificar_detalle_flor", tPFCODIGOIParameter, uNDCODIGOIParameter, fechaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spVerificar_proceso_diario(Nullable<System.DateTime> fecha, Nullable<int> tPFCODIGOI, Nullable<int> uNDCODIGOI)
        {
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var tPFCODIGOIParameter = tPFCODIGOI.HasValue ?
                new ObjectParameter("TPFCODIGOI", tPFCODIGOI) :
                new ObjectParameter("TPFCODIGOI", typeof(int));
    
            var uNDCODIGOIParameter = uNDCODIGOI.HasValue ?
                new ObjectParameter("UNDCODIGOI", uNDCODIGOI) :
                new ObjectParameter("UNDCODIGOI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spVerificar_proceso_diario", fechaParameter, tPFCODIGOIParameter, uNDCODIGOIParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spVerificar_proceso(Nullable<System.DateTime> fecha, Nullable<int> identificador)
        {
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var identificadorParameter = identificador.HasValue ?
                new ObjectParameter("identificador", identificador) :
                new ObjectParameter("identificador", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spVerificar_proceso", fechaParameter, identificadorParameter);
        }
    
        public virtual int spUpdate_detalle_flor_clasificada(Nullable<int> dTECODIGOI, Nullable<int> tMTCODIGOI, Nullable<int> uNDCODIGOI, Nullable<int> tPFCODIGOI, Nullable<int> vRDCODIGOI, Nullable<int> dTECANTIDAD, Nullable<System.DateTime> fecha)
        {
            var dTECODIGOIParameter = dTECODIGOI.HasValue ?
                new ObjectParameter("DTECODIGOI", dTECODIGOI) :
                new ObjectParameter("DTECODIGOI", typeof(int));
    
            var tMTCODIGOIParameter = tMTCODIGOI.HasValue ?
                new ObjectParameter("TMTCODIGOI", tMTCODIGOI) :
                new ObjectParameter("TMTCODIGOI", typeof(int));
    
            var uNDCODIGOIParameter = uNDCODIGOI.HasValue ?
                new ObjectParameter("UNDCODIGOI", uNDCODIGOI) :
                new ObjectParameter("UNDCODIGOI", typeof(int));
    
            var tPFCODIGOIParameter = tPFCODIGOI.HasValue ?
                new ObjectParameter("TPFCODIGOI", tPFCODIGOI) :
                new ObjectParameter("TPFCODIGOI", typeof(int));
    
            var vRDCODIGOIParameter = vRDCODIGOI.HasValue ?
                new ObjectParameter("VRDCODIGOI", vRDCODIGOI) :
                new ObjectParameter("VRDCODIGOI", typeof(int));
    
            var dTECANTIDADParameter = dTECANTIDAD.HasValue ?
                new ObjectParameter("DTECANTIDAD", dTECANTIDAD) :
                new ObjectParameter("DTECANTIDAD", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdate_detalle_flor_clasificada", dTECODIGOIParameter, tMTCODIGOIParameter, uNDCODIGOIParameter, tPFCODIGOIParameter, vRDCODIGOIParameter, dTECANTIDADParameter, fechaParameter);
        }
    
        public virtual int spInsert_control_flor_nacional(Nullable<int> tPCCODIGOI, Nullable<int> vRDCODIGOI, Nullable<int> cFNCANTIDAD, string cFNOBSERVACION, Nullable<System.DateTime> fecha)
        {
            var tPCCODIGOIParameter = tPCCODIGOI.HasValue ?
                new ObjectParameter("TPCCODIGOI", tPCCODIGOI) :
                new ObjectParameter("TPCCODIGOI", typeof(int));
    
            var vRDCODIGOIParameter = vRDCODIGOI.HasValue ?
                new ObjectParameter("VRDCODIGOI", vRDCODIGOI) :
                new ObjectParameter("VRDCODIGOI", typeof(int));
    
            var cFNCANTIDADParameter = cFNCANTIDAD.HasValue ?
                new ObjectParameter("CFNCANTIDAD", cFNCANTIDAD) :
                new ObjectParameter("CFNCANTIDAD", typeof(int));
    
            var cFNOBSERVACIONParameter = cFNOBSERVACION != null ?
                new ObjectParameter("CFNOBSERVACION", cFNOBSERVACION) :
                new ObjectParameter("CFNOBSERVACION", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsert_control_flor_nacional", tPCCODIGOIParameter, vRDCODIGOIParameter, cFNCANTIDADParameter, cFNOBSERVACIONParameter, fechaParameter);
        }
    
        public virtual ObjectResult<spVerificar_control_flor_nacional_Result> spVerificar_control_flor_nacional(Nullable<System.DateTime> fecha, Nullable<int> cAUCODIGOI)
        {
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var cAUCODIGOIParameter = cAUCODIGOI.HasValue ?
                new ObjectParameter("CAUCODIGOI", cAUCODIGOI) :
                new ObjectParameter("CAUCODIGOI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spVerificar_control_flor_nacional_Result>("spVerificar_control_flor_nacional", fechaParameter, cAUCODIGOIParameter);
        }
    
        public virtual int spUpdate_control_flor_nacional(Nullable<int> cFNCODIGOI, Nullable<int> tPCCODIGOI, Nullable<int> vRDCODIGOI, Nullable<int> cFNCANTIDAD, Nullable<System.DateTime> fecha)
        {
            var cFNCODIGOIParameter = cFNCODIGOI.HasValue ?
                new ObjectParameter("CFNCODIGOI", cFNCODIGOI) :
                new ObjectParameter("CFNCODIGOI", typeof(int));
    
            var tPCCODIGOIParameter = tPCCODIGOI.HasValue ?
                new ObjectParameter("TPCCODIGOI", tPCCODIGOI) :
                new ObjectParameter("TPCCODIGOI", typeof(int));
    
            var vRDCODIGOIParameter = vRDCODIGOI.HasValue ?
                new ObjectParameter("VRDCODIGOI", vRDCODIGOI) :
                new ObjectParameter("VRDCODIGOI", typeof(int));
    
            var cFNCANTIDADParameter = cFNCANTIDAD.HasValue ?
                new ObjectParameter("CFNCANTIDAD", cFNCANTIDAD) :
                new ObjectParameter("CFNCANTIDAD", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdate_control_flor_nacional", cFNCODIGOIParameter, tPCCODIGOIParameter, vRDCODIGOIParameter, cFNCANTIDADParameter, fechaParameter);
        }
    
        public virtual ObjectResult<spSelect_Items_Preenvio_Result> spSelect_Items_Preenvio(Nullable<int> tPFCODIGOI, Nullable<int> vRDCODIGOI, Nullable<int> tMTCODIGOI, Nullable<int> uNDCODIGOI)
        {
            var tPFCODIGOIParameter = tPFCODIGOI.HasValue ?
                new ObjectParameter("TPFCODIGOI", tPFCODIGOI) :
                new ObjectParameter("TPFCODIGOI", typeof(int));
    
            var vRDCODIGOIParameter = vRDCODIGOI.HasValue ?
                new ObjectParameter("VRDCODIGOI", vRDCODIGOI) :
                new ObjectParameter("VRDCODIGOI", typeof(int));
    
            var tMTCODIGOIParameter = tMTCODIGOI.HasValue ?
                new ObjectParameter("TMTCODIGOI", tMTCODIGOI) :
                new ObjectParameter("TMTCODIGOI", typeof(int));
    
            var uNDCODIGOIParameter = uNDCODIGOI.HasValue ?
                new ObjectParameter("UNDCODIGOI", uNDCODIGOI) :
                new ObjectParameter("UNDCODIGOI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_Items_Preenvio_Result>("spSelect_Items_Preenvio", tPFCODIGOIParameter, vRDCODIGOIParameter, tMTCODIGOIParameter, uNDCODIGOIParameter);
        }
    
        public virtual int spInsert_Detalle_preenvio(Nullable<int> dTECODIGOI, Nullable<int> dTPCANTIDAD)
        {
            var dTECODIGOIParameter = dTECODIGOI.HasValue ?
                new ObjectParameter("DTECODIGOI", dTECODIGOI) :
                new ObjectParameter("DTECODIGOI", typeof(int));
    
            var dTPCANTIDADParameter = dTPCANTIDAD.HasValue ?
                new ObjectParameter("DTPCANTIDAD", dTPCANTIDAD) :
                new ObjectParameter("DTPCANTIDAD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsert_Detalle_preenvio", dTECODIGOIParameter, dTPCANTIDADParameter);
        }
    
        public virtual ObjectResult<spSelect_preenvio_Result> spSelect_preenvio(Nullable<int> pRECODIGOI)
        {
            var pRECODIGOIParameter = pRECODIGOI.HasValue ?
                new ObjectParameter("PRECODIGOI", pRECODIGOI) :
                new ObjectParameter("PRECODIGOI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_preenvio_Result>("spSelect_preenvio", pRECODIGOIParameter);
        }
    
        public virtual ObjectResult<spSelect_preenvio_id_Result> spSelect_preenvio_id(Nullable<int> pRECODIGOI)
        {
            var pRECODIGOIParameter = pRECODIGOI.HasValue ?
                new ObjectParameter("PRECODIGOI", pRECODIGOI) :
                new ObjectParameter("PRECODIGOI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_preenvio_id_Result>("spSelect_preenvio_id", pRECODIGOIParameter);
        }
    
        public virtual ObjectResult<spSelect_detalle_items_Result> spSelect_detalle_items(Nullable<int> pRECODIGOI, Nullable<int> preestado)
        {
            var pRECODIGOIParameter = pRECODIGOI.HasValue ?
                new ObjectParameter("PRECODIGOI", pRECODIGOI) :
                new ObjectParameter("PRECODIGOI", typeof(int));
    
            var preestadoParameter = preestado.HasValue ?
                new ObjectParameter("preestado", preestado) :
                new ObjectParameter("preestado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_detalle_items_Result>("spSelect_detalle_items", pRECODIGOIParameter, preestadoParameter);
        }
    
        public virtual ObjectResult<spSelect_detalle_items_editar_Result> spSelect_detalle_items_editar(Nullable<int> pRECODIGOI)
        {
            var pRECODIGOIParameter = pRECODIGOI.HasValue ?
                new ObjectParameter("PRECODIGOI", pRECODIGOI) :
                new ObjectParameter("PRECODIGOI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_detalle_items_editar_Result>("spSelect_detalle_items_editar", pRECODIGOIParameter);
        }
    
        public virtual ObjectResult<spSelect_listado_items_Result> spSelect_listado_items(Nullable<int> pRECODIGOI)
        {
            var pRECODIGOIParameter = pRECODIGOI.HasValue ?
                new ObjectParameter("PRECODIGOI", pRECODIGOI) :
                new ObjectParameter("PRECODIGOI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_listado_items_Result>("spSelect_listado_items", pRECODIGOIParameter);
        }
    
        public virtual int spUpdate_Preenvio(Nullable<int> pRECODIGOI, Nullable<int> cLNCODIGO, Nullable<System.DateTime> pREFECHA, Nullable<int> pRENUMERO, string pREAWB, string pREHAWB, Nullable<int> pRENUMPIEZAS, string pREIDCAJAS)
        {
            var pRECODIGOIParameter = pRECODIGOI.HasValue ?
                new ObjectParameter("PRECODIGOI", pRECODIGOI) :
                new ObjectParameter("PRECODIGOI", typeof(int));
    
            var cLNCODIGOParameter = cLNCODIGO.HasValue ?
                new ObjectParameter("CLNCODIGO", cLNCODIGO) :
                new ObjectParameter("CLNCODIGO", typeof(int));
    
            var pREFECHAParameter = pREFECHA.HasValue ?
                new ObjectParameter("PREFECHA", pREFECHA) :
                new ObjectParameter("PREFECHA", typeof(System.DateTime));
    
            var pRENUMEROParameter = pRENUMERO.HasValue ?
                new ObjectParameter("PRENUMERO", pRENUMERO) :
                new ObjectParameter("PRENUMERO", typeof(int));
    
            var pREAWBParameter = pREAWB != null ?
                new ObjectParameter("PREAWB", pREAWB) :
                new ObjectParameter("PREAWB", typeof(string));
    
            var pREHAWBParameter = pREHAWB != null ?
                new ObjectParameter("PREHAWB", pREHAWB) :
                new ObjectParameter("PREHAWB", typeof(string));
    
            var pRENUMPIEZASParameter = pRENUMPIEZAS.HasValue ?
                new ObjectParameter("PRENUMPIEZAS", pRENUMPIEZAS) :
                new ObjectParameter("PRENUMPIEZAS", typeof(int));
    
            var pREIDCAJASParameter = pREIDCAJAS != null ?
                new ObjectParameter("PREIDCAJAS", pREIDCAJAS) :
                new ObjectParameter("PREIDCAJAS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdate_Preenvio", pRECODIGOIParameter, cLNCODIGOParameter, pREFECHAParameter, pRENUMEROParameter, pREAWBParameter, pREHAWBParameter, pRENUMPIEZASParameter, pREIDCAJASParameter);
        }
    
        public virtual int spActualizar_Stock(Nullable<int> dTECODIGOI, Nullable<int> dTPCODIGOI, Nullable<int> dTECANTIDAD)
        {
            var dTECODIGOIParameter = dTECODIGOI.HasValue ?
                new ObjectParameter("DTECODIGOI", dTECODIGOI) :
                new ObjectParameter("DTECODIGOI", typeof(int));
    
            var dTPCODIGOIParameter = dTPCODIGOI.HasValue ?
                new ObjectParameter("DTPCODIGOI", dTPCODIGOI) :
                new ObjectParameter("DTPCODIGOI", typeof(int));
    
            var dTECANTIDADParameter = dTECANTIDAD.HasValue ?
                new ObjectParameter("DTECANTIDAD", dTECANTIDAD) :
                new ObjectParameter("DTECANTIDAD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spActualizar_Stock", dTECODIGOIParameter, dTPCODIGOIParameter, dTECANTIDADParameter);
        }
    
        public virtual int spInsert_Editado_Detalle_preenvio(Nullable<int> dTECODIGOI, Nullable<int> dTPCANTIDAD, Nullable<int> pRECODIGO)
        {
            var dTECODIGOIParameter = dTECODIGOI.HasValue ?
                new ObjectParameter("DTECODIGOI", dTECODIGOI) :
                new ObjectParameter("DTECODIGOI", typeof(int));
    
            var dTPCANTIDADParameter = dTPCANTIDAD.HasValue ?
                new ObjectParameter("DTPCANTIDAD", dTPCANTIDAD) :
                new ObjectParameter("DTPCANTIDAD", typeof(int));
    
            var pRECODIGOParameter = pRECODIGO.HasValue ?
                new ObjectParameter("PRECODIGO", pRECODIGO) :
                new ObjectParameter("PRECODIGO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsert_Editado_Detalle_preenvio", dTECODIGOIParameter, dTPCANTIDADParameter, pRECODIGOParameter);
        }
    
        public virtual ObjectResult<spSelect_conciliaciones_Result> spSelect_conciliaciones()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_conciliaciones_Result>("spSelect_conciliaciones");
        }
    
        public virtual ObjectResult<spSelect_preenvios_conciliacion_Result> spSelect_preenvios_conciliacion()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_preenvios_conciliacion_Result>("spSelect_preenvios_conciliacion");
        }
    
        public virtual int spDelete_Conciliacion(Nullable<int> cNCCODIGOI)
        {
            var cNCCODIGOIParameter = cNCCODIGOI.HasValue ?
                new ObjectParameter("CNCCODIGOI", cNCCODIGOI) :
                new ObjectParameter("CNCCODIGOI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDelete_Conciliacion", cNCCODIGOIParameter);
        }
    
        public virtual ObjectResult<spSelect_usuario_Result> spSelect_usuario(string uSRLOGIN, string uSRPASSWORD)
        {
            var uSRLOGINParameter = uSRLOGIN != null ?
                new ObjectParameter("USRLOGIN", uSRLOGIN) :
                new ObjectParameter("USRLOGIN", typeof(string));
    
            var uSRPASSWORDParameter = uSRPASSWORD != null ?
                new ObjectParameter("USRPASSWORD", uSRPASSWORD) :
                new ObjectParameter("USRPASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_usuario_Result>("spSelect_usuario", uSRLOGINParameter, uSRPASSWORDParameter);
        }
    
        public virtual ObjectResult<spSelect_usuario1_Result> spSelect_usuario1(string uSRLOGIN, string uSRPASSWORD)
        {
            var uSRLOGINParameter = uSRLOGIN != null ?
                new ObjectParameter("USRLOGIN", uSRLOGIN) :
                new ObjectParameter("USRLOGIN", typeof(string));
    
            var uSRPASSWORDParameter = uSRPASSWORD != null ?
                new ObjectParameter("USRPASSWORD", uSRPASSWORD) :
                new ObjectParameter("USRPASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_usuario1_Result>("spSelect_usuario1", uSRLOGINParameter, uSRPASSWORDParameter);
        }
    
        public virtual int spActualizar_Password(Nullable<int> uSRCODIGOI, string uSRPASSWORD)
        {
            var uSRCODIGOIParameter = uSRCODIGOI.HasValue ?
                new ObjectParameter("USRCODIGOI", uSRCODIGOI) :
                new ObjectParameter("USRCODIGOI", typeof(int));
    
            var uSRPASSWORDParameter = uSRPASSWORD != null ?
                new ObjectParameter("USRPASSWORD", uSRPASSWORD) :
                new ObjectParameter("USRPASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spActualizar_Password", uSRCODIGOIParameter, uSRPASSWORDParameter);
        }
    }
}
