using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using E_JOGOS.Models;

namespace E_JOGOS.Controllers
{
    public class EquipeController : Controller
    {

        Models.Equipe equipeModel = new Models.Equipe();

        public IActionResult Index()
        {
            ViewBag.equipe = equipeModel.ReadAll();
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form) { 
            Equipe nova_equipe = new Equipe();
            nova_equipe.Id = int.Parse(form["Id"]);
            nova_equipe.Nome = form["Nome"];
            nova_equipe.Imagem = form["Imagem"];

            equipeModel.Create(nova_equipe);
            ViewBag.equipe = equipeModel.ReadAll();

            //return View(nova_equipe);
            return LocalRedirect("~/Equipe");
        }
    }
}
