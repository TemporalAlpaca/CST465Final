using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using CST465_Final.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CST465_Final.Controllers
{
    [Authorize(Roles = "Admin")]
    public class LinkController : Controller
    {
        private ILinkRepository linkRepository;

        public LinkController(ILinkRepository linkRepo)
        {
            linkRepository = linkRepo;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(linkRepository.GetLinks());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="Admin")]
        public IActionResult Insert(LinkModel link)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", link);
            }
            linkRepository.Insert(link);
            return RedirectToAction("Index", "Link");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="Admin")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", id);
            }
            linkRepository.Delete(id);
            return RedirectToAction("Index", "Link");
        }
    }
}
