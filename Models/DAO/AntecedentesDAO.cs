using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysFloricola.Models.DAO
{
	public class AntecedentesDAO
	{
		public SelectList Lista_TipoAntecedentes()
		{
			SDHCEntities db = new SDHCEntities();
			return new SelectList(db.TIPOS_ANTECEDENTES, "TPACODIGOI", "TPADESCRIPCION");
		}

		public List<Antecedentes> Lista_Antecedentes(int idTipoAntecedentes, int idHistoria)
		{
			SDHCEntities db = new SDHCEntities();
			List<Antecedentes> lista = new List<Antecedentes>();
			List<spSelect_Historia_antecedentes_Result> list = db.spSelect_Historia_antecedentes(idTipoAntecedentes, idHistoria).ToList();
			if(list.Count > 0)
			{
				foreach (var item in list)
				{
					Antecedentes obj = new Antecedentes();
					obj.HANCODIGOI = item.HANCODIGOI;
					obj.HSCCODIGOI = item.HSCCODIGOI;
					obj.HANRESPUESTA = item.HANRESPUESTA;
					obj.HANOBSERVACION = item.HANOBSERVACION ;
					obj.TPACODIGOI = item.TPACODIGOI;
					obj.LSADESCRIPCION = item.LSADESCRIPCION;
					obj.LSACODIGOI = item.LSACODIGOI;
					obj.LSACODCLINICO = item.LSACODCLINICO;
					obj.LSAESTADO = item.LSAESTADO;
					obj.Comentario = item.HANOBSERVACION + ";" + item.LSACODIGOI;
					if(Convert.ToBoolean(obj.HANRESPUESTA))
						obj.check = item.HANRESPUESTA + ";" + item.LSACODIGOI +";true";
					else
						obj.check = item.HANRESPUESTA + ";" + item.LSACODIGOI +";false";
					lista.Add(obj);
				}
			}
			else
			{
				List<LISTA_ANTECEDENTES> lista1 = db.LISTA_ANTECEDENTES.Where(x => x.TPACODIGOI == idTipoAntecedentes).ToList();
				foreach (var item in lista1)
				{
					Antecedentes obj = new Antecedentes();
					obj.LSADESCRIPCION = item.LSADESCRIPCION;
					obj.LSACODIGOI = item.LSACODIGOI;
					obj.LSACODCLINICO = item.LSACODCLINICO;
					obj.LSAESTADO = item.LSAESTADO;
					obj.Comentario = ";" + item.LSACODIGOI;
					obj.check = ";" + item.LSACODIGOI + ";null"; 
					lista.Add(obj);
				}
			}			
			
			return lista;
		}

		public bool Insertar_Historia_Antecedentes(List<HISTORIA_ANTECEDENTES> listaHistoria)
		{
			bool respuesta = false;
			using (SDHCEntities db = new SDHCEntities())
			{
				foreach (var item in listaHistoria)
				{
					var res = db.spInsert_HistoriaAntecedentes(item.HSCCODIGOI, item.LSACODIGOI, item.HANRESPUESTA, item.HANOBSERVACION);
				}
				respuesta = true;
			}
			return respuesta;
		}
			


	}

	public class Antecedentes
	{
		public int? HANCODIGOI { get; set; }
		public int? HSCCODIGOI { get; set; }
		public bool? HANRESPUESTA { get; set; }
		public string HANOBSERVACION { get; set; }
		public int? LSACODIGOI { get; set; }
		public Nullable<int> TPACODIGOI { get; set; }
		public Nullable<decimal> LSACODCLINICO { get; set; }
		public string LSADESCRIPCION { get; set; }
		public Nullable<bool> LSAESTADO { get; set; }
		public string Comentario { get; set; }
		public string check { get; set; }


	}	

}