using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Masp.Models;

namespace Masp.Controllers
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
            return RedirectToAction("Usuario");            
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

        public IActionResult Usuario(string masp)
        {
            if(!string.IsNullOrWhiteSpace(masp))
                return View(new Usuario().Obter(masp));

            return View(null);
        }

        public IActionResult ListarArmas(string masp_user)
        {
            if (!string.IsNullOrWhiteSpace(masp_user))
                return View(new Usuario().Obter(masp_user));

            return View(null);
        }

        public IActionResult ListarCursos(string masp_user)
        {
            if (!string.IsNullOrWhiteSpace(masp_user))
                return View(new Usuario().Obter(masp_user));

            return View(null);
        }
    }
}
