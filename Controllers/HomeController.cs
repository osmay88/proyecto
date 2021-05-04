using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyecto.Data;
using proyecto.Dts;
using proyecto.Models;
using proyecto.Services;

namespace proyecto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly S3Service service;
        private readonly ImagesRepository imageRepo;

        public HomeController(ILogger<HomeController> logger, S3Service service, ImagesRepository imageRepo)
        {
            _logger = logger;
            this.service = service;
            this.imageRepo = imageRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UploadForm model)
        {
            using (var memoryStream = new MemoryStream())
            {
                await model.FormFile.CopyToAsync(memoryStream);
                var filename = await service.uploadAsync(memoryStream, model.FormFile.FileName);
                await this.imageRepo.addImage(filename, model.Description, model.Title, model.Tags);
                ViewBag.filename = filename;
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
