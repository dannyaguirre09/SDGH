using SysFloricola.Models.DAO;
using SysFloricola.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using SysFloricola.Filter;

namespace SysFloricola.Controllers
{
	[SecurityFilter] 
	public class SignosVitalesController : Controller
    {
		private SignosVitalesDAO objDao = new SignosVitalesDAO();

        // GET: SignosVitales
        public ActionResult SignosVitales(string numEmp, string codHist)
        {
			if (string.IsNullOrEmpty(numEmp) || string.IsNullOrEmpty(codHist))
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			List<SignosVitales> listaSignosVitales = objDao.Obtener_Signos_Vitales(Convert.ToInt32(codHist));
			ViewBag.numEmp = numEmp;
			ViewBag.codHist = codHist;
			return View(listaSignosVitales);
        }
		

		[HttpPost]
		public ActionResult GuardarSignosVitales(List<SignosVitales> obj, string codHistoria, string numEmp)
		{
			try
			{
				bool respuesta = objDao.Guardar_Signos_Vitales(obj, codHistoria);
				if(respuesta)
					Request.Flash("success", "Registro Actualizado Correctamente");				
			}
			catch (Exception exc)
			{
				Request.Flash("danger", "Ha ocurrido un error: " + exc.Message);
			}

			return RedirectToAction("SignosVitales", "SignosVitales", new { numEmp = numEmp, codHist = codHistoria });
		}


	}
}