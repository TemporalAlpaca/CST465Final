using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Repositories;
using CST465_Final.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CST465_Final.Controllers
{
    [Authorize]
    public class PirateController : Controller
    {
        // GET: /<controller>/
        private IPirateRepository pirateRepository;

        public PirateController(IPirateRepository pirateRepo, IMemoryCache cache)
        {
            pirateRepository = pirateRepo;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(pirateRepository.GetPirates());
        }

        [HttpGet]
        public IActionResult Create()
        {
            PirateModel pirate = new PirateModel();
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            pirate.name = configuration["DefaultPirateName"];
            return View(pirate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(PirateModel pirate)
        {
            if(!ModelState.IsValid)
            {
                return View("Create", pirate);
            }
            //Insert pirate yarrrr
            pirateRepository.Insert(pirate);
            return RedirectToAction("Index", "Pirate");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", id);
            }
            //Insert pirate yarrrr
            pirateRepository.Delete(id);
            return RedirectToAction("Index", "Pirate");
        }
    }
}
