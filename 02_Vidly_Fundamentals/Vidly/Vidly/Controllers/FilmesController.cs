using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class FilmesController : Controller
    {
        // GET: Filmes/Aleatorio
        public ActionResult Aleatorio()
        {
            var filme = new Filme()
            {
                Nome = "Shrek"
            };

            // Retorna a View tipada
            //return View(filme);

            // Retorna um texto simples
            //return Content("Hello World!");

            // Retorna um HTTP Code
            //return HttpNotFound();

            // Semelhante ao void
            //return new EmptyResult();

            // Retorna um redirecionamento com parâmetros na query string
            return RedirectToAction("Index", "Home", new { pagina = 1, filtro = "nome" });
        }
    }
}