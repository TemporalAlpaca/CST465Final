using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CST465_Final.Controllers
{
    [Authorize(Roles = "Admin")]
    // [Authorize]
    public class AdminController : Controller
    {
        private static RoleManager<IdentityRole> _roleManager;
        private static UserManager<IdentityUser> _userManager;
        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InsertRole(string RoleName)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Admin");
            }

            await AddRole(RoleName);
            return RedirectToAction("Index", "Admin");
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateUserRole(string RoleName, string Username)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Admin");
            }

            await GiveUserRole(RoleName, Username);
            return RedirectToAction("Index", "Admin");
        }

        private async Task AddRole(string RoleName)
        {
            var roleExists = await _roleManager.RoleExistsAsync(RoleName);
            if (!roleExists)
            {
                var role = new IdentityRole();
                role.Name = RoleName;
                await _roleManager.CreateAsync(role);
            }
        }

        private async Task GiveUserRole(string RoleName, string Username)
        {
            var roleExists = await _roleManager.RoleExistsAsync(RoleName);
            var user = _userManager.Users.Where(u => u.UserName == Username).FirstOrDefault();
            if (roleExists && user != null && this.User.IsInRole("Admin"))
            {
                await _userManager.AddToRoleAsync(user, RoleName);
            }
        }
    }
}
