using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CST465_Final.Models;
using CST465_Final.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CST465_Final.Controllers
{
    public class PirateAnimalController : Controller
    {
        private IPirateAnimalRepository pirateAnimalRepository;

        public PirateAnimalController(IPirateAnimalRepository pirateAnimalRepo)
        {
            pirateAnimalRepository = pirateAnimalRepo;
        }

        public IActionResult Index()
        {
            return View(pirateAnimalRepository.GetPirateAnimals());
        }

        public IActionResult Create()
        {
            return View();
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
    }
}
