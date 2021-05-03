using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyecto.Models;
using proyecto.Services;

namespace proyecto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly S3Service service;

        public HomeController(ILogger<HomeController> logger, S3Service service)
        {
            _logger = logger;
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            using (var memoryStream = new MemoryStream())
            {
                await service.uploadAsync(memoryStream, "Aloha", "tovarish");
            }

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
    }
}
