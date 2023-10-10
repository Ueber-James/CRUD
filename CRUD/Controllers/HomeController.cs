using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UsandoViews.Models;
using System.Linq;
using System.Xml;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar(int? id)
        {
            var usuario = new Usuario();

            if (id.HasValue && Usuario.Listagem.Any(u => u.Id == id))
            {
               
                    usuario = Usuario.Listagem.Single(u => u.Id == id);
                    return View(usuario);
                
            }

            return View();
        }



    }
}