using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysFloricola.Models.DAO
{
	public class DiagnosticoDAO
	{
		public SelectList Lista_Indices_Principales()
		{
			SDHCEntities db = new SDHCEntities();
			return new SelectList(db.INDICES_CIE_PRINCIPALES, "ICPCODIGOI", "ICPDESCRIPCION");
		}

		public List<IndiceSecundario> Lista_Indices_Secundarios(int id)
		{
			List<INDICES_CIE_SECUNDARIOS> listaIndices = new List<INDICES_CIE_SECUNDARIOS>();
			List<IndiceSecundario> lista = new List<IndiceSecundario>();
			using (SDHCEntities db = new SDHCEntities())
			{
				listaIndices = db.INDICES_CIE_SECUNDARIOS.Where(x => x.ICPCODIGOI == id).ToList();
				foreach (var item in listaIndices)
				{
					IndiceSecundario obj = new IndiceSecundario();
					obj.ICPCODIGOI = item.ICPCODIGOI;
					obj.INSCODIGOI = item.INSCODIGOI;
					obj.INSDESCRIPCION = item.INSDESCRIPCION;
					obj.INSESTADO = item.INSESTADO;
					obj.INSIDCIE = item.INSIDCIE;
					lista.Add(obj);
				}
			}
			return lista;
		}

		public Diagnostico Obtener_Diagnostico(int idIndice, int codHist)
		{
			DIAGNOSTICOS obj = new DIAGNOSTICOS();
			Diagnostico objDiagnostico = new Diagnostico();
			using (SDHCEntities db = new SDHCEntities())
			{
				obj = db.DIAGNOSTICOS.Where(x => x.INSCODIGOI == idIndice && x.HSCCODIGOI == codHist).FirstOrDefault();
				if(obj != null)
				{
					objDiagnostico.DGNCODIGOI = obj.DGNCODIGOI;
					objDiagnostico.DGNFECHA = obj.DGNFECHA;
					objDiagnostico.DGNOBSERVACION = obj.DGNOBSERVACION;
					objDiagnostico.DGNTIPO = obj.DGNTIPO;
					objDiagnostico.HSCCODIGOI = obj.HSCCODIGOI;
					objDiagnostico.INSCODIGOI = obj.INSCODIGOI;
				}
				
			}
			return objDiagnostico;
		}

		public bool Insertar_Diagnostico(int DGNCODIGOI, int HSCCODIGOI, int INSCODIGOI, string DGNOBSERVACION, string DGNTIPO)
		{
			bool respuesta = false;
			using (SDHCEntities db = new SDHCEntities())
			{
				var res = db.spInsert_Diagnostico(DGNCODIGOI, HSCCODIGOI, INSCODIGOI, DGNOBSERVACION, DGNTIPO);
				respuesta = true;
			}
			return respuesta;
		}

	}

	public class IndiceSecundario
	{
		public int INSCODIGOI { get; set; }
		public Nullable<int> ICPCODIGOI { get; set; }
		public string INSDESCRIPCION { get; set; }
		public string INSIDCIE { get; set; }
		public Nullable<bool> INSESTADO { get; set; }
	}

	public partial class Diagnostico
	{
		public int DGNCODIGOI { get; set; }
		public Nullable<int> HSCCODIGOI { get; set; }
		public Nullable<int> INSCODIGOI { get; set; }
		public Nullable<System.DateTime> DGNFECHA { get; set; }
		public string DGNOBSERVACION { get; set; }
		public string DGNTIPO { get; set; }

	}
}