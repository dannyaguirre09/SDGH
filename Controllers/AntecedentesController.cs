using SysFloricola.Filter;
using SysFloricola.Models;
using SysFloricola.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SysFloricola.Controllers
{
	[SecurityFilter]
    public class AntecedentesController : Controller
    {
		private AntecedentesDAO objDAO = new AntecedentesDAO();

        // GET: Antecedentes
        public ActionResult Antecedentes(string numEmp, string codHist)
        {
			if (string.IsNullOrEmpty(numEmp) || string.IsNullOrEmpty(codHist))
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			ViewBag.TPACODIGOI = objDAO.Lista_TipoAntecedentes();
			ViewBag.numEmp = numEmp;
			ViewBag.codHist = codHist;			
			return View();
        }

		public int suma()
		{
			return 0;
		}

		public JsonResult ListaAntecedentes(int idTipoAntecedente, int idHistoria)
		{
			List<Antecedentes> lista = new List<Antecedentes>();
			try
			{
				lista = objDAO.Lista_Antecedentes(idTipoAntecedente, idHistoria);
			}
			catch (Exception)
			{
				
			}
			return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
		}

		[HttpPost]
		public ActionResult CrearHistoriaAntecedentes(FormCollection form)
		{
			var codHist = form["codHist"].ToString();
			var numEmp = form["numEmp"].ToString();

			try
			{
				List<HISTORIA_ANTECEDENTES> listaHistoria = new List<HISTORIA_ANTECEDENTES>();
				int bandera = 0;

				foreach (var item in form)
				{
					HISTORIA_ANTECEDENTES obj = new HISTORIA_ANTECEDENTES();
					string identificador = item.ToString().Substring(0, 6);
					if (identificador.Trim() == "opcion")
					{
						string respuesta = form[bandera].ToString();
						if (respuesta.Trim() == "1")
						{
							obj.HANRESPUESTA = true;
							obj.HANOBSERVACION = form[bandera + 1].ToString();
						}
						else
						{
							obj.HANRESPUESTA = false;
							obj.HANOBSERVACION = "No Refiere";
						}

						obj.LSACODIGOI = Convert.ToInt32(item.ToString().Split('n')[1]);						
						obj.HSCCODIGOI = Convert.ToInt32(codHist);
						listaHistoria.Add(obj);
					}

					bandera++;
				}

				bool insertar = objDAO.Insertar_Historia_Antecedentes(listaHistoria);
				if (insertar)
					Request.Flash("success", "Registro Actualizado Correctamente");
			}
			catch (Exception exc)
			{
				Request.Flash("danger", "Ha ocurrido un error: " + exc.Message);
			}
			return RedirectToAction("Antecedentes", "Antecedentes" , new { numEmp = numEmp, codHist=codHist });
		}
    }
}