using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos _repositorioProyectos;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos) 
        {
            _logger = logger;
            _repositorioProyectos = repositorioProyectos; 
            
        }

        public IActionResult Index()
        {
            var proyectos = _repositorioProyectos.ObtenerProyectos().Take(2).ToList();
            return View(proyectos);
        }



        public IActionResult Proyectos()
        {
            var proyectos = _repositorioProyectos.ObtenerProyectos().ToList();
            return View(proyectos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
