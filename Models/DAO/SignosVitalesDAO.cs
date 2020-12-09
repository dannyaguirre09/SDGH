using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysFloricola.Models.DAO
{
	public class SignosVitalesDAO
	{
		public List<SignosVitales> Obtener_Signos_Vitales(int idHistoria)
		{
			List<SignosVitales> lista = new List<SignosVitales>();
			using (SDHCEntities db = new SDHCEntities())
			{
				List<spSelect_HistoriaSignosVitales_Result> registros = db.spSelect_HistoriaSignosVitales(idHistoria).ToList();
				foreach (var item in registros)
				{
					SignosVitales obj = new SignosVitales();
					obj.HSCCODIGOI = item.HSCCODIGOI;
					if(item.HSVCODIGOI == null)
						obj.HSVCODIGOI = 0;
					else obj.HSVCODIGOI = item.HSVCODIGOI;
					obj.HSVFECHA = item.HSVFECHA;
					obj.HSVVALORES = item.HSVVALORES;
					obj.SGVCODIGOI = item.SGVCODIGOI;
					obj.SGVDESCRIPCION = item.SGVDESCRIPCION;
					lista.Add(obj);
				}
			}
			return lista;
		}
		
		public bool Guardar_Signos_Vitales(List<SignosVitales> Lista, string codHistoria)
		{
			bool respuesta = false;
			using (SDHCEntities db = new SDHCEntities())
			{
				foreach (var obj in Lista)
				{
					var res = db.spInsert_SignosVitales(obj.HSVCODIGOI, obj.SGVCODIGOI, Convert.ToInt32(codHistoria), obj.HSVVALORES);
				}				
				respuesta = true;
			}
			return respuesta;
		}
	}

	public class SignosVitales
	{
		public Nullable<int> HSVCODIGOI { get; set; }
		public Nullable<int> HSCCODIGOI { get; set; }
		public Nullable<System.DateTime> HSVFECHA { get; set; }
		public string HSVVALORES { get; set; }
		public int SGVCODIGOI { get; set; }
		public string SGVDESCRIPCION { get; set; }
	}

}