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

            return View(filme);
        }
    }
}