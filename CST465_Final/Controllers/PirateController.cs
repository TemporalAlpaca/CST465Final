using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Repositories;
using CST465_Final.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CST465_Final.Controllers
{
    public class PirateController : Controller
    {
        // GET: /<controller>/
        private IPirateRepository pirateRepository;

        public PirateController(IPirateRepository pirateRepo)
        {
            pirateRepository = pirateRepo;
        }

        public IActionResult Index()
        {
            return View(pirateRepository.GetPirates());
        }

        public IActionResult Create()
        {
            return View();
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
    }
}
