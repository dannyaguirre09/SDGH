using SysFloricola.Models;
using SysFloricola.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysFloricola.Controllers
{
    public class PacienteController : Controller
    {
		private PacienteDAO objDAO = new PacienteDAO();

        // GET: Paciente
        public ActionResult Index()
        {
			List<PACIENTE> lista = objDAO.Obtener_Pacientes();
            return View(lista);
        }
    }
}