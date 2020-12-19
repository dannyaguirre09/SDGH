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

		public List<PACIENTE> Buscar_Paciente(int identificador, string descripcion)
		{
			List<PACIENTE> lista = new List<PACIENTE>();
			using (SDHCEntities db = new SDHCEntities())
			{
				List<spSelect_Paciente_Result> pacientes = db.spSelect_Paciente(descripcion, identificador).ToList();
				foreach (var item in pacientes)
				{
					PACIENTE obj = new PACIENTE();
					obj.PCTAPELLIDOM = item.PCTAPELLIDOM;
					obj.PCTAPELLIDOP = item.PCTAPELLIDOP;
					obj.PCTCEDULAC = item.PCTCEDULAC;
					obj.PCTCODIGOI = item.PCTCODIGOI;
					obj.PCTCONTACTO = item.PCTCONTACTO;
					obj.PCTDIRECCC = item.PCTDIRECCC;
					obj.PCTFECHAN = item.PCTFECHAN;
					obj.PCTGENERO = item.PCTGENERO;
					obj.PCTMAILC = item.PCTMAILC;
					obj.PCTNOMBREC = item.PCTNOMBREC;
					obj.PCTTELCONTACTO = item.PCTTELCONTACTO;
					obj.PCTTELEFONCEL = item.PCTTELEFONCEL;
					obj.PCTTELEFONOC = item.PCTTELEFONOC;
					lista.Add(obj);
				}
			}
			return lista;
		}
	}
}