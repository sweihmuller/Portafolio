using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
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
    }
}
