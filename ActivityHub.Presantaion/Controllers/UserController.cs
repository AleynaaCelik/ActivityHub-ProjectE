using ActivityHub.Application.DTOs;
using ActivityHub.Application.Interfaces;
using ActivityHub.Presantaion.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActivityHub.Presantaion.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: /User/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /User/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(CreateUserViewModel createUserViewModel)
        {
            if (ModelState.IsValid)
            {
                var createUserDto = new CreateUserDto
                {
                    FirstName = createUserViewModel.FirstName,
                    LastName = createUserViewModel.LastName,
                    Email = createUserViewModel.Email,
                    Password = createUserViewModel.Password
                };

                await _userService.AddUserAsync(createUserDto);
                return RedirectToAction(nameof(ActivityController.Create), "Activity");
            }
            return View(createUserViewModel);
        }
    }
}
