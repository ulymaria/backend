using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _16_ProjetoMVC.Controllers.Exercicio
{
 
    public class ExercicioController : Controller
    {
        private readonly ILogger<ExercicioController> _logger;

        public ExercicioController(ILogger<ExercicioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index2()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}