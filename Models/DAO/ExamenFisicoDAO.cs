using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysFloricola.Models.DAO
{
	public class ExamenFisicoDAO
	{
		public SelectList Lista_Tipo_Examen_Fisico()
		{
			SDHCEntities db = new SDHCEntities();
			return new SelectList(db.TIPOS_EXAMENES_FISICOS, "TPFCODIGOI", "TPFDESCRIPCION");
		}

		public EXAMENES_FISICOS Obtener_Examen_Fisico(int TPFCODIGOI, int HSCCODIGOI)
		{
			EXAMENES_FISICOS obj = new EXAMENES_FISICOS();
			using (SDHCEntities db = new SDHCEntities())
			{
				obj = db.EXAMENES_FISICOS.Where(x => x.TPFCODIGOI == TPFCODIGOI && x.HSCCODIGOI == HSCCODIGOI).FirstOrDefault();
			}
			return obj;
		}

		public bool Insertar_Examen_Fisico (EXAMENES_FISICOS obj)
		{
			bool respuesta = false;
			using (SDHCEntities db = new SDHCEntities())
			{
				var res = db.spInsert_ExamenFisico(obj.EXFCODIGOI, obj.TPFCODIGOI, obj.HSCCODIGOI, obj.EXFDESCRIPCION);
				respuesta = true;
			}
			return respuesta;
		}
	}

	public class Examen_Fisico
	{
		 public int EXFCODIGOI { get; set; }
        public int TPFCODIGOI { get; set; }
        public Nullable<int> HSCCODIGOI { get; set; }
        public Nullable<System.DateTime> EXFFECHA { get; set; }
        public string EXFDESCRIPCION { get; set; }
	}
}