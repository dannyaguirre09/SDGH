using SysFloricola.Models.DAO;
using SysFloricola.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static SysFloricola.Models.DAO.LoginDAO;

namespace SysFloricola.Controllers
{
    public class LoginController : Controller
    {
		private Encriptacion encriptar = new Encriptacion();
		private LoginDAO objDal = new LoginDAO();

		// GET: Login
		public ActionResult Index()
        {
            return View();
        }
		
		[HttpPost]
		public ActionResult Index(string usuario, string password)
		{
			try
			{
				string passwordCodificado = encriptar.Encriptar(password);
				Usuario user = objDal.Obtener_Usuario(usuario, passwordCodificado);
				if (!string.IsNullOrEmpty(user.Username))
				{
					Session["Nombre"] = user.ApellidoP + " " + user.Nombres;
					Session["Usuario"] = user.Username;
					Session["CodigoUsuario"] = user.CodigoUsuario;
					if (Convert.ToBoolean(user.Estado))
						return RedirectToAction("Index", "Home");
					else
						return RedirectToAction("CambiarPassword", "Home");
				}
				else
					Request.Flash("danger", "Usuario o Contraseña Incorrectos");
			}
			catch (Exception ex)
			{
				Request.Flash("danger", ex.Message);
			}
			return View();
		}

		public ActionResult Logout()
		{
			Session.Contents.Remove("Usuario");
			Session.Contents.Remove("Nombre");
			return RedirectToAction("Index", "Login");
		}
	}
}