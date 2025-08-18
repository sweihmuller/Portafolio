using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(2).ToList();
            var modelo = new HomeIndexViewModel() { proyectos = proyectos };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    titulo = "Girar el dado",
                    descripcion ="Aplicación en Flutter donde el usuario aprieta el dado y aparece una de las caras del dado",
                    link = "https://github.com/sweihmuller/Roll-dice",
                    imagenURL = "imagenes/girarDado.png"
                },
                new Proyecto
                {
                    titulo = "Quiz",
                    descripcion ="Aplicación en Flutter donde el usuario responde unas preguntas con opción múltiple.",
                    link = "https://github.com/sweihmuller/quiz_app",
                    imagenURL = "imagenes/quiz.png"
                },
                new Proyecto
                {
                    titulo = "Gestión de gastos",
                    descripcion ="Aplicación en Flutter con estructura inicial para seguimiento de gastos personales",
                    link = "https://github.com/sweihmuller/Expense-Tracker",
                    imagenURL = "imagenes/gestionGastos.png"
                },
                new Proyecto
                {
                    titulo = "Receta de comida",
                    descripcion ="Aplicación en Flutter que muestra la recetas de distintas comidas, mostrarlas según condiciones y elegir tus favoritas.",
                    link = "https://github.com/sweihmuller/Expense-Tracker",
                    imagenURL = "imagenes/recetaComidas.png"
                },
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
