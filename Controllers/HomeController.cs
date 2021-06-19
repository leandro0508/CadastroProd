using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastroProd.Models;

namespace CadastroProd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var produto = new Produto(); // aqui criamos o projeto
            return View(produto); // Retornamos para a view dados
        }
        [HttpPost]
        public ActionResult Index(Produto produto)
        {
            if (ModelState.IsValid) // Validamos o estado
            {
                return View("Resultado", produto);
            }
            return View(produto);
        }
        public ActionResult Resultado(Produto produto)
        {
            return View(produto);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}