using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CST465_Final.Models;
using CST465_Final.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CST465_Final.Controllers
{
    [Authorize]
    public class PirateAnimalController : Controller
    {
        private IPirateAnimalRepository pirateAnimalRepository;

        public PirateAnimalController(IPirateAnimalRepository pirateAnimalRepo)
        {
            pirateAnimalRepository = pirateAnimalRepo;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(pirateAnimalRepository.GetPirateAnimals());
        }

        [HttpGet]
        public IActionResult Create()
        {
            PirateAnimalModel pirateAnimal = new PirateAnimalModel();
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            pirateAnimal.name = configuration["DefaultPirateAnimalName"];
            pirateAnimal.animalType = configuration["DefaultAnimalSpecies"];
            return View(pirateAnimal);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(PirateAnimalModel pirateAnimal)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", pirateAnimal);
            }
            //Insert pirate yarrrr
            pirateAnimalRepository.Insert(pirateAnimal);
            return RedirectToAction("Index", "PirateAnimal");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", id);
            }
            pirateAnimalRepository.Delete(id);
            return RedirectToAction("Index", "PirateAnimal");
        }
    }
}
