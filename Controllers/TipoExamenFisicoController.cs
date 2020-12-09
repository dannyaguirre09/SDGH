using SysFloricola.Models.DAO;
using SysFloricola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysFloricola.Controllers
{
    public class TipoExamenFisicoController : Controller
    {
		private TipoExamenesFisicosDAO objDAO = new TipoExamenesFisicosDAO();

		// GET: TipoExamenFisico
		public ActionResult Index()
        {
			var lista = objDAO.Obtener_Tipo_Examenes_Fisicos();
			return View(lista);
		}

		public ActionResult CrearTipoExamenFisico(int id = 0)
		{
			TIPOS_EXAMENES_FISICOS obj = new TIPOS_EXAMENES_FISICOS();
			if (id != 0)
			{
				obj = objDAO.Buscar_Tipo_Examen_Fisico(id);
			}

			return View(obj);
		}

		[HttpPost]
		public ActionResult CrearTipoExamenFisico(TIPOS_EXAMENES_FISICOS obj)
		{
			try
			{
				bool respuesta;
				string mensaje = "Tipo de examen creado correctamente";
				if (obj.TPFCODIGOI == 0)
					respuesta = objDAO.Crear_Tipo_Examen_Fisico(obj, true);
				else
				{
					respuesta = objDAO.Crear_Tipo_Examen_Fisico(obj, false);
					mensaje = "Tipo de examen editado correctamente";
				}
				if (respuesta)
					Request.Flash("success", mensaje);
			}
			catch (Exception exc)
			{
				Request.Flash("danger", "Ha ocurrido un error: " + exc.Message);
			}

			return RedirectToAction("Index", "TipoExamenFisico");
		}

		public ActionResult Confirmacion(int id)
		{
			ViewBag.id = id;
			return View();
		}

		[HttpPost]
		public ActionResult EliminarTipoExamenFisico(int id)
		{
			try
			{
				bool respuesta = objDAO.Eliminar_Tipo_Examen_Fisico(id);
				if (respuesta)
					Request.Flash("success", "Tipo de examen eliminado correctamente");
			}
			catch (Exception exc)
			{
				Request.Flash("danger", "Ha ocurrido un error: " + exc.Message);
			}

			return RedirectToAction("Index", "TipoExamenFisico");
		}
	}
}