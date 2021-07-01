using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Usuario;
using Entity.Models;

namespace Web.Controllers
{
    public class UsuarioController : Controller
    {
        readonly UsuarioBll _bll = new UsuarioBll();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Novo()
        {
            return View();
        }

        public ActionResult Editar()
        {
            return View();
        }

        public JsonResult RetornarUsuarios()
        {
            var listaUsuarios = _bll.RetornarTodos();
            return Json(listaUsuarios, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Salvar(Usuario usuario)
        {
            try
            {
                if (usuario.Id > 0)
                {
                    _bll.Editar(usuario);
                }
                else
                {
                    _bll.Salvar(usuario);
                }
                
                return Json(new {retorno = true,mensagem = "Usuário salvo com sucesso!"}, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { retorno = false, mensagem = "Erro !"+ex.Message }, JsonRequestBehavior.AllowGet);

            }
           
        }

        public JsonResult RetornaUsuario(int id)
        {
            try
            {
                return Json(_bll.RetornarPorId(id), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { retorno = false, mensagem = "Erro !" + ex.Message }, JsonRequestBehavior.AllowGet);

            }

        }
    }
}