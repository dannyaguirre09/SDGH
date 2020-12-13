using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SysFloricola.Models.DAO
{
	public class PlanesDAO
	{
		public List<PRESCRIPCIONES> Lista_Prescripciones(int codHis)
		{
			using (SDHCEntities db = new SDHCEntities())
			{
				return db.PRESCRIPCIONES.Where(x => x.HSCCODIGOI == codHis).ToList();
			}
		}

		public bool Crear_Prescripcion (PRESCRIPCIONES objNuevo, bool nuevo)
		{
			bool respuesta = false;
			if (nuevo)
			{
				using (var db = new SDHCEntities())
				{
					objNuevo.PRSFECHA = DateTime.Now;
					db.PRESCRIPCIONES.Add(objNuevo);
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

		public PRESCRIPCIONES Buscar_Prescripcion(int id)
		{
			using (var db = new SDHCEntities())
				return db.PRESCRIPCIONES.Find(id);
		}

		public bool Eliminar_Prescripcion(int id)
		{
			bool respuesta = false;
			using (var db = new SDHCEntities())
			{
				PRESCRIPCIONES obj = db.PRESCRIPCIONES.Find(id);
				db.PRESCRIPCIONES.Remove(obj);
				db.SaveChanges();
				respuesta = true;
			}
			return respuesta;
		}
	}
}