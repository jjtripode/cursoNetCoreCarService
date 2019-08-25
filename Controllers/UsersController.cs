using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarServiceFronted.Models;
using CursoNetCoreCarService.Entities;
using CursoNetCoreCarService.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarServiceFronted.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(
        UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();

            var usersViewModel = new UsersViewModel()
            {
                Users =
                 users.Select(u => new User()
                 {
                     IdentityUser = u,
                     Roles = _userManager.GetRolesAsync(u).Result.ToList()
                 }
                  ).ToArray(),

                AddNewUserViewModel = await GetAddNewUserViewModel()
            };

            return View(usersViewModel);
        }

        private async Task<AddNewUserViewModel> GetAddNewUserViewModel()
        {
            return new AddNewUserViewModel()
            {
                Roles = await _roleManager.Roles.Select(r => r.Name).ToListAsync()
            };
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUser(AddNewUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var newUser = new IdentityUser
            {
                UserName = model.UserName,
                Email = model.Email
            };

            IdentityResult result = await _userManager.CreateAsync(newUser, model.Password);

            if (result.Succeeded)
            {
                _userManager.AddToRoleAsync(newUser, model.Rol).Wait();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> EditUser(string userId)
        {
            var editUserViewModel = new EditUserViewModel()
            {
                User = await _userManager.Users.Where(u => u.Id == userId).FirstOrDefaultAsync(),
                Roles = await _roleManager.Roles.Select(r => r.Name).ToListAsync()
            };

            return PartialView("EditUserPartial", editUserViewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            var user = await _userManager.Users.Where(u => u.Id == model.UserId).FirstAsync();
           
             await  _userManager.RemoveFromRolesAsync(user, _roleManager.Roles.Select(r => r.Name));

            _userManager.AddToRoleAsync(user, model.Rol).Wait();

            return RedirectToAction("Index");
        }
    }
}
