using SysFloricola.Models.DAO;
using SysFloricola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace SysFloricola.Controllers
{
	public class HistoriaClinicaController : Controller
	{
		private HistoriaClinicaDAO objDAO = new HistoriaClinicaDAO();

		// GET: HistoriaClinica
		public ActionResult Filiacion(string numEmp)
		{
			if (string.IsNullOrEmpty(numEmp))
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			HISTORIA_CLINICA objHistoria = objDAO.Obtener_Datos_Historia_Clinica(Convert.ToInt32(numEmp));
			if (objHistoria.PACIENTE == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			return View(objHistoria);
		}

		public ActionResult CrearHistoriaClinica(HISTORIA_CLINICA objNuevo)
		{
			try
			{
				bool respuesta;
				int numeroHistoria = 0;
				string mensaje = "Historia Clínica Creada Correctamente";
				if (objNuevo.HSCCODIGOI == 0)
				{
					respuesta = objDAO.Crear_Historia_Clinica(objNuevo, true);
					numeroHistoria = objDAO.obtener_Codigo_Historia_Clinica();
				}
				else
				{
					respuesta = objDAO.Crear_Historia_Clinica(objNuevo, false);
					mensaje = "Historia Clínica Editada Correctamente";
					numeroHistoria = objNuevo.HSCCODIGOI;
				}
				if (respuesta)
				{
					Request.Flash("success", mensaje);
					return RedirectToAction("Consulta", "Consulta", new { numEmp = objNuevo.PCTCODIGOI, codHist=numeroHistoria });
				}
				else
					Request.Flash("danger", "No ha sido posible crear la historia clínica");
			}
			catch (Exception ex)
			{
				Request.Flash("danger", ex.Message);
			}
			return RedirectToAction("Filiacion", "HistoriaClinica", new { numEmp = objNuevo.PCTCODIGOI });
		}

	}
}