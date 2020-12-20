using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysFloricola.Models.DAO
{
	public class LoginDAO
	{
		public Usuario Obtener_Usuario(string user, string password)
		{
			Usuario usuario = new Usuario();
			using (SDHCEntities db = new SDHCEntities())
			{
				List<spSelect_usuario1_Result> usuarios = db.spSelect_usuario1(user, password).ToList();
				foreach (var item in usuarios)
				{
					usuario.ApellidoP = item.USRAPELLIDOP;
					usuario.ApellidoM = item.USRAPELLIDOM;
					usuario.Nombres = item.USRNOMBREC;
					usuario.Username = item.USRLOGIN;
					usuario.Estado = item.USRESTADOCAMBIO;
					usuario.CodigoUsuario = item.USRCODIGOI;
				}
			}
			return usuario;
		}

		public bool ActualizarContraseña(string nuevoPassword, int codigoUsuario)
		{
			bool respuesta = false;
			using (SDHCEntities db = new SDHCEntities())
			{
				int res = db.spActualizar_Password(codigoUsuario, nuevoPassword);
				respuesta = true;
			}
			return respuesta;
		}
		public class Usuario
		{
			public string ApellidoP { get; set; }
			public string ApellidoM { get; set; }
			public string Nombres { get; set; }
			public string Username { get; set; }
			public bool? Estado { get; set; }
			public int CodigoUsuario { get; set; }
		}
	}
}