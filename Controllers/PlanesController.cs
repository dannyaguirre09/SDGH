using SysFloricola.Models.DAO;
using SysFloricola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SysFloricola.Filter;

namespace SysFloricola.Controllers
{
	[SecurityFilter] 
	public class PlanesController : Controller
    {
		private PlanesDAO objDAO = new PlanesDAO();

        // GET: Planes
        public ActionResult Index(string numEmp, string codHist)
        {
			if (string.IsNullOrEmpty(numEmp) || string.IsNullOrEmpty(codHist))
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			ViewBag.numEmp = numEmp;
			ViewBag.codHist = codHist;
			return View(objDAO.Lista_Prescripciones(Convert.ToInt32(codHist)));
        }

		public ActionResult CrearPrescripcion(int codHist, int numEmp, int id = 0)
		{
			PRESCRIPCIONES obj = new PRESCRIPCIONES();
			ViewBag.ESPCODIGOI = objDAO.Lista_Especialista(0);
			if (id != 0)
			{
				obj = objDAO.Buscar_Prescripcion(id);
				ViewBag.ESPCODIGOI = objDAO.Lista_Especialista(Convert.ToInt32(obj.ESPCODIGOI));
			}
			ViewBag.codHist = codHist;
			ViewBag.numEmp = numEmp;
			return View(obj);
		}

		[HttpPost]
		public ActionResult CrearPrescripcion(PRESCRIPCIONES obj, string codHist, string numEmp)
		{
			try
			{
				bool respuesta;
				string mensaje = "Prescripción creado correctamente";
				
				if (obj.PRSCODIGOI == 0)
				{
					obj.HSCCODIGOI = Convert.ToInt32(codHist);
					respuesta = objDAO.Crear_Prescripcion(obj, true);
				}					
				else
				{
					respuesta = objDAO.Crear_Prescripcion(obj, false);
					mensaje = "Prescripción editado correctamente";
				}
				if (respuesta)
					Request.Flash("success", mensaje);
			}
			catch (Exception exc)
			{
				Request.Flash("danger", "Ha ocurrido un error: " + exc.Message);
			}

			return RedirectToAction("Index", "Planes", new { numEmp=numEmp, codHist = codHist});
		}

		public ActionResult Confirmacion( int numEmp, int codHist, int id)
		{
			ViewBag.id = id;
			ViewBag.codHist = codHist;
			ViewBag.numEmp = numEmp;
			return View();
		}

		[HttpPost]
		public ActionResult EliminarPrescripcion(int id, string numEmp, string codHist)
		{
			try
			{
				bool respuesta = objDAO.Eliminar_Prescripcion(id);
				if (respuesta)
					Request.Flash("success", "Prescripción eliminado correctamente");
			}
			catch (Exception exc)
			{
				Request.Flash("danger", "Ha ocurrido un error: " + exc.Message);
			}

			return RedirectToAction("Index", "Planes", new { numEmp = numEmp, codHist = codHist });
		}

	}
}