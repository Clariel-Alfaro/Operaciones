using Microsoft.AspNetCore.Mvc;
using Practica01.Models;
using System.Diagnostics;

namespace Practica01.Controllers
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
            return View();
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
       // Metodo importante sin una accion no tenemos vista y a la inversa igual
        
        
        
        public IActionResult suma(Double DatoN1, Double DatoN2)
        {
            if(DatoN1 > 10 || DatoN2 > 10) {
                return View("NoMayores");
            }
            Double resultado = DatoN1 + DatoN2;
            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.VariableAEnviar = resultado;
            return View();
        }
        
        public IActionResult NoMayores()
        {
            return View();
        }
        
        public IActionResult division (Double DatoN1, Double DatoN2)
        {
            if (DatoN1 > 10 || DatoN2 > 10)
            {
                return View("NoMayores");
            }
            Double resultado = DatoN1 / DatoN2;

            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.VariableAEnviar = resultado;
            return View();
        }

        public IActionResult multiplicacion(Double DatoN1, Double DatoN2)

        {
            if (DatoN1 > 10 || DatoN2 > 10)
            {
                return View("NoMayores");
            }
            Double resultado = DatoN1 * DatoN2;

            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.VariableAEnviar = resultado;

            return View();           
        }
        public IActionResult resta(Double DatoN1, Double DatoN2)
        {
            if (DatoN1 > 10 || DatoN2 > 10)
            {
                return View("NoMayores");
            }
            Double resultado = DatoN1 - DatoN2;

            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.VariableAEnviar = resultado;

            return View();
        }
       


    }
    
    
}