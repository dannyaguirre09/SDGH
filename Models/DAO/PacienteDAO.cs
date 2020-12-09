using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysFloricola.Models.DAO
{
	public class PacienteDAO
	{
		public List<PACIENTE> Obtener_Pacientes()
		{
			List<PACIENTE> lista = new List<PACIENTE>();
			try
			{
				using (SDHCEntities db = new SDHCEntities())
					lista = db.PACIENTE.ToList();
			}
			catch (Exception)
			{
			}
			return lista;
		}
	}
}