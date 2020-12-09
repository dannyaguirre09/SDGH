using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SysFloricola.Models.DAO
{
	public class HistoriaClinicaDAO
	{
		public PACIENTE Obtener_Datos_Paciente(int codigoPaciente)
		{
			PACIENTE objPaciente = new PACIENTE();
			using (SDHCEntities db = new SDHCEntities())
			{
				objPaciente = db.PACIENTE.Find(codigoPaciente);
				if(objPaciente != null)
				{
					if (objPaciente.PCTGENERO.Trim() == "1")
						objPaciente.PCTGENERO = "Femenino";
					else objPaciente.PCTGENERO = "Masculino";
				}
			}
			return objPaciente;
		}

		public decimal? Obtener_Numero_Historia_Clinica()
		{
			decimal? numeroHistoria = 0;
			using (SDHCEntities db = new SDHCEntities())
			{
				numeroHistoria = db.HISTORIA_CLINICA.Max(z => z.HSCNUMERO);
				if (numeroHistoria == null)
					numeroHistoria = 00000001;
				else
					numeroHistoria += 1;
			}
			return numeroHistoria;
		}

		public HISTORIA_CLINICA Obtener_Datos_Historia_Clinica(int codigoPaciente)
		{
			HISTORIA_CLINICA objHistoria = new HISTORIA_CLINICA();
			using (SDHCEntities db = new SDHCEntities())
			{
				objHistoria = db.HISTORIA_CLINICA.Include(x => x.PACIENTE).Where(x => x.PCTCODIGOI == codigoPaciente).FirstOrDefault();
				if (objHistoria == null)
				{
					objHistoria = new HISTORIA_CLINICA();
					objHistoria.PACIENTE = Obtener_Datos_Paciente(codigoPaciente);
					objHistoria.HSCFECHAAPERTURA = DateTime.Now;
					objHistoria.HSCHORA_APERTURA = DateTime.Now;
					objHistoria.HSCNUMERO = Obtener_Numero_Historia_Clinica();
					if(objHistoria.PACIENTE != null)
						objHistoria.PCTCODIGOI = objHistoria.PACIENTE.PCTCODIGOI;
				}
				else
				{
					if(objHistoria.PACIENTE.PCTGENERO.Trim() == "1")
						objHistoria.PACIENTE.PCTGENERO = "Femenino";
					else objHistoria.PACIENTE.PCTGENERO = "Masculino";
				}
					
			}
			return objHistoria;
		}

		public int obtener_Codigo_Historia_Clinica()
		{
			int respuesta = 0;
			using (SDHCEntities db = new SDHCEntities())
			{
				respuesta = db.HISTORIA_CLINICA.Max(x => x.HSCCODIGOI);
			}
			return respuesta;
		}

		public bool Crear_Historia_Clinica(HISTORIA_CLINICA objNuevo, bool nuevo)
		{
			bool respuesta = false;			
			if (nuevo)
			{
				using (var db = new SDHCEntities())
				{
					objNuevo.HSCFECHAAPERTURA = DateTime.Now;
					objNuevo.HSCHORA_APERTURA = DateTime.Now;
					int res = db.spInsert_HistoriaClinica_Actualizado(objNuevo.PCTCODIGOI,Convert.ToInt32(objNuevo.HSCNUMERO), 
																	  objNuevo.HSCFECHAAPERTURA, objNuevo.HSCHORA_APERTURA, 
																	  objNuevo.OBSERVACIONES);
					if(res>0)					
						respuesta = true;
				}
			}
			else
			{
				using (var db = new SDHCEntities())
				{
					int res = db.spUpdate_HistoriaClinica(objNuevo.HSCCODIGOI, objNuevo.OBSERVACIONES);
					if(res>0)
						respuesta = true;
				}
			}

			return respuesta;
		}
	}
}