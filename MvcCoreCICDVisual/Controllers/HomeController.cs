using Microsoft.AspNetCore.Mvc;
using MvcCoreCICDVisual.Models;
using System.Diagnostics;

namespace MvcCoreCICDVisual.Controllers
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
            //CODIGO DE SERVIDOR Y CODIGO DE CLIENTE
            ViewData["SALUDO"] = "Mi App desde GitHub";
            Random random = new Random();
            List<int> numeros = new List<int>();
            for(int i=0; i < 10; i++)
            {
                int aleat = random.Next(1, 10);
                numeros.Add(aleat);
            }

            return View(numeros);
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
