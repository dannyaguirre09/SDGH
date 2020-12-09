using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SysFloricola.Models.DAO
{
	public class ConsultaDAO
	{
		public List<CONSULTAS> Obtener_Motivos(int codHistoria, int identificador)
		{
			List<CONSULTAS> lista = new List<CONSULTAS>();
			
			using (SDHCEntities db = new SDHCEntities())
			{
				if(identificador ==1)
					lista = db.CONSULTAS.Where(x => x.HSCCODIGOI == codHistoria && x.CNSENFERMEDAD == null).ToList();
				else
					lista = db.CONSULTAS.Where(x => x.HSCCODIGOI == codHistoria && x.CNSMOTIVO == null).ToList();
			}
			return lista;
		}

		public bool Crear_Motivo_Consulta(CONSULTAS objNuevo, bool nuevo)
		{
			bool respuesta = false;
			objNuevo.CNSFECHA = DateTime.Now;
			if (nuevo)
			{
				using (var db = new SDHCEntities())
				{
					db.CONSULTAS.Add(objNuevo);
					db.SaveChanges();
					respuesta = true;
				}
			}
			else
			{
				using (var db = new SDHCEntities())
				{
					db.Entry(objNuevo).State = EntityState.Modified;
					db.SaveChanges();
					respuesta = true;
				}
			}

			return respuesta;
		}

		public CONSULTAS Buscar_Consulta(int id)
		{
			using (var db = new SDHCEntities())
				return db.CONSULTAS.Find(id);
		}

		public bool Eliminar_Consulta(int id)
		{
			bool respuesta = false;
			using (var db = new SDHCEntities())
			{
				CONSULTAS obj = db.CONSULTAS.Find(id);
				db.CONSULTAS.Remove(obj);
				db.SaveChanges();
				respuesta = true;
			}

			return respuesta;
		}

	}
}