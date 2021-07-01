using System;
using System.Linq;
using System.Web.Mvc;
using Entity.Context;
using Entity.Models;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Logar(Usuario usuario)
        {
            try
            {
                var user = db.Usuario.FirstOrDefault(p => p.Login == usuario.Login && p.Senha == usuario.Senha);

                if (user == null)
                    return Json(new { retorno = false }, JsonRequestBehavior.AllowGet);
                Session["Usuario"] = user.Nome;
                return Json(new { retorno = true }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { retorno = false, mensagem = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        
    }
}