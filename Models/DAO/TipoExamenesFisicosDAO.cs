using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SysFloricola.Models.DAO
{
	public class TipoExamenesFisicosDAO
	{
		public List<TIPOS_EXAMENES_FISICOS> Obtener_Tipo_Examenes_Fisicos()
		{
			using (var db = new SDHCEntities())
				return db.TIPOS_EXAMENES_FISICOS.ToList();
		}


		public bool Crear_Tipo_Examen_Fisico(TIPOS_EXAMENES_FISICOS objNuevo, bool nuevo)
		{
			bool respuesta = false;
			objNuevo.TPFESTADO = true;
			if (nuevo)
			{
				using (var db = new SDHCEntities())
				{
					db.TIPOS_EXAMENES_FISICOS.Add(objNuevo);
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

		public TIPOS_EXAMENES_FISICOS Buscar_Tipo_Examen_Fisico(int id)
		{
			using (var db = new SDHCEntities())
				return db.TIPOS_EXAMENES_FISICOS.Find(id);
		}

		public bool Eliminar_Tipo_Examen_Fisico(int id)
		{
			bool respuesta = false;
			using (var db = new SDHCEntities())
			{
				TIPOS_EXAMENES_FISICOS obj = db.TIPOS_EXAMENES_FISICOS.Find(id);
				db.TIPOS_EXAMENES_FISICOS.Remove(obj);
				db.SaveChanges();
				respuesta = true;
			}

			return respuesta;
		}
	}
}