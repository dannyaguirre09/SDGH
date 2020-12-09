using SysFloricola.Models.DAO;
using SysFloricola.Models;
using System;
using System.Net;
using System.Web.Mvc;

namespace SysFloricola.Controllers
{
    public class ConsultaController : Controller
    {
		private ConsultaDAO objDao = new ConsultaDAO();

        // GET: Consulta
        public ActionResult Consulta(string numEmp, string codHist)
        {
			if(string.IsNullOrEmpty(numEmp) || string.IsNullOrEmpty(codHist) )
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			ViewBag.listaMotivos = objDao.Obtener_Motivos(Convert.ToInt32(codHist), 1);
			ViewBag.listaEnfermedades = objDao.Obtener_Motivos(Convert.ToInt32(codHist), 2);
			ViewBag.numEmp = numEmp;
			ViewBag.codHist = codHist;
			return View();
        }

		public ActionResult CrearMotivoConsulta(string numEmp, string codHist, int id, int identificador)
		{
			CONSULTAS obj = new CONSULTAS();
			if (id != 0)
			{
				obj = objDao.Buscar_Consulta(id);
			}
			ViewBag.numEmp = numEmp;
			ViewBag.codHist = codHist;
			ViewBag.identificador = identificador;
			return View(obj);
		}

		[HttpPost]
		public ActionResult CrearMotivoConsulta(CONSULTAS obj, string numEmp, string codHist)
		{
			try
			{
				bool respuesta;
				obj.HSCCODIGOI = Convert.ToInt32(codHist);
				string mensaje = "Motivo creado correctamente";
				if (obj.CNSCODIGOI == 0)
					respuesta = objDao.Crear_Motivo_Consulta(obj, true);
				else
				{
					respuesta = objDao.Crear_Motivo_Consulta(obj, false);
					mensaje = "Motivo editado correctamente";
				}
				if (respuesta)
					Request.Flash("success", mensaje);
			}
			catch (Exception exc)
			{
				Request.Flash("danger", "Ha ocurrido un error: " + exc.Message);
			}

			return RedirectToAction("Consulta", "Consulta", new { numEmp = numEmp, codHist = codHist });
		}

		public ActionResult Confirmacion(string numEmp, string codHist, int id)
		{
			ViewBag.id = id;
			ViewBag.numEmp = numEmp;
			ViewBag.codHist = codHist;
			return View();
		}

		[HttpPost]
		public ActionResult EliminarMotivo(int id, string numEmp, string codHist)
		{
			try
			{
				bool respuesta = objDao.Eliminar_Consulta(id);
				if (respuesta)
					Request.Flash("success", "Registro eliminado correctamente");
			}
			catch (Exception exc)
			{
				Request.Flash("danger", "Ha ocurrido un error: " + exc.Message);
			}

			return RedirectToAction("Consulta", "Consulta", new { numEmp = numEmp, codHist = codHist });
		}

	}
}