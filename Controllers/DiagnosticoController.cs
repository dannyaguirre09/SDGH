using SysFloricola.Models.DAO;
using SysFloricola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SysFloricola.Controllers
{
    public class DiagnosticoController : Controller
    {
		private DiagnosticoDAO objDAO = new DiagnosticoDAO();

        // GET: Diagnostico
        public ActionResult Diagnostico(string numEmp, string codHist)
        {
			if (string.IsNullOrEmpty(numEmp) || string.IsNullOrEmpty(codHist))
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			ViewBag.ICPCODIGOI = objDAO.Lista_Indices_Principales();
			ViewBag.numEmp = numEmp;
			ViewBag.codHist = codHist;
			return View();
        }

		public JsonResult ObtenerListaIndicesSecundarios(int id)
		{
			bool estado = false;
			string mensaje = "OK";
			List<IndiceSecundario> lista = new List<IndiceSecundario>();
			try
			{
				lista = objDAO.Lista_Indices_Secundarios(id);
				estado = true;
			}
			catch (Exception ex)
			{
				mensaje = ex.Message;
			}
			return Json(new { estado = estado, lista = lista, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
		}

		public JsonResult ObtenerDiagnostico(int idIndice, int codHist)
		{
			bool estado = false;
			string mensaje = "OK";
			Diagnostico diagnostico = new Diagnostico();
			try
			{
				diagnostico = objDAO.Obtener_Diagnostico(idIndice, codHist);
				estado = true;
			}
			catch (Exception ex)
			{
				mensaje = ex.Message;
			}
			return Json(new { estado = estado, diagnostico = diagnostico, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
		}

		[HttpPost]
		public ActionResult Diagnostico(FormCollection form)
		{
		
			var codHist = form["codHist"].ToString();
			var numEmp = form["numEmp"].ToString();
			try
			{
				string dgnTipo = form["opciones"].ToString();
				string dgnComentario = form["comentario"].ToString();
				string INSCODIGOI = form["INSCODIGOI"].ToString();
				int DGNCODIGOI = Convert.ToInt32(form["DGNCODIGOI"].ToString());

				bool insertar = objDAO.Insertar_Diagnostico(DGNCODIGOI, Convert.ToInt32(codHist), Convert.ToInt32(INSCODIGOI), dgnComentario, dgnTipo);
				if (insertar)
					Request.Flash("success", "Registro Actualizado Correctamente");
			}
			catch (Exception exc)
			{
				Request.Flash("danger", "Ha ocurrido un error: " + exc.Message);
			}
			return RedirectToAction("Diagnostico", "Diagnostico", new { numEmp = numEmp, codHist = codHist }); 
		}



	}
}