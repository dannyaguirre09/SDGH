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
    public class ExamenFisicoController : Controller
    {
		private ExamenFisicoDAO objDao = new ExamenFisicoDAO();

        // GET: ExamenFisico
        public ActionResult ExamenFisico(string numEmp, string codHist)
        {
			if (string.IsNullOrEmpty(numEmp) || string.IsNullOrEmpty(codHist))
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			ViewBag.numEmp = numEmp;
			ViewBag.codHist = codHist;
			ViewBag.TPFCODIGOI = objDao.Lista_Tipo_Examen_Fisico();
			return View();
        }

		public JsonResult ObtenerExamenFisico(int TPFCODIGOI, int HSCCODIGOI)
		{
			bool estado = false;
			string mensaje = "OK";
			EXAMENES_FISICOS obj = new EXAMENES_FISICOS();
			Examen_Fisico objExamen = new Examen_Fisico();
			try
			{
				obj = objDao.Obtener_Examen_Fisico(TPFCODIGOI, HSCCODIGOI);
				if (obj != null)
				{
					objExamen.EXFCODIGOI = obj.EXFCODIGOI;
					objExamen.EXFDESCRIPCION = obj.EXFDESCRIPCION;
					objExamen.EXFFECHA = obj.EXFFECHA;
					objExamen.HSCCODIGOI = obj.HSCCODIGOI;
					objExamen.TPFCODIGOI = obj.TPFCODIGOI;
				} else
				{
					objExamen.EXFCODIGOI = 0;
					objExamen.EXFDESCRIPCION = "";
					objExamen.EXFFECHA = DateTime.Now;
					objExamen.HSCCODIGOI = 0;
					objExamen.TPFCODIGOI = 0;
				}
				estado = true;
			}
			catch (Exception ex) 
			{
				mensaje = ex.Message;
			}
			return Json(new { estado = estado, obj = objExamen, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
		}

		[HttpPost]
		public JsonResult InsertarExamenFisico(int EXFCODIGOI, int TPFCODIGOI,int HSCCODIGOI, string EXFDESCRIPCION)
		{
			bool estado = false;
			string mensaje = "OK";			
			try
			{
				EXAMENES_FISICOS obj = new EXAMENES_FISICOS {
					EXFCODIGOI = EXFCODIGOI,
					TPFCODIGOI = TPFCODIGOI,
					HSCCODIGOI = HSCCODIGOI,
					EXFDESCRIPCION = EXFDESCRIPCION
				};
				estado = objDao.Insertar_Examen_Fisico(obj);		
			}
			catch (Exception ex)
			{
				mensaje = ex.Message;
			}
			return Json(new { estado = estado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
		}

	}
}