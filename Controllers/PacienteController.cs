using SysFloricola.Filter;
using SysFloricola.Models;
using SysFloricola.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysFloricola.Controllers
{
	[SecurityFilter]
	public class PacienteController : Controller
    {
		private PacienteDAO objDAO = new PacienteDAO();

        // GET: Paciente
        public ActionResult Index()
        {
			List<PACIENTE> lista = new List<PACIENTE>();
            return View(lista);
        }

		[HttpPost]
		public ActionResult Index(int identificador, string descripcion)
		{
			List<PACIENTE> lista = objDAO.Buscar_Paciente(identificador, descripcion);
			return View(lista);
		}

		public ActionResult ListaPacientes()
		{
			List<PACIENTE> lista = objDAO.Obtener_Pacientes();
			return View(lista);
		}
	}
}