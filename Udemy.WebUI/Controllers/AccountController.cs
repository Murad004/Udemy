﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Udemy.Business.Abstract;
using Udemy.WebUI.Identity;
using Udemy.WebUI.Models;
using Udemy.WebUI.Service;

namespace Udemy.WebUI.Controllers
{
    public class AccountController : Controller
    {

        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IHttpContextAccessor httpContextAccessor;
        private IWebHostEnvironment webHost;

        private readonly IStorageService _storageService;
        private readonly IConfiguration _configuration;
        Uri coursephotouri = null;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHost, IStorageService storageService, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.httpContextAccessor = httpContextAccessor;
            this.webHost = webHost;
            _storageService = storageService;
            _configuration = configuration;
        }





        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.UserName);
            var role = await _userManager.GetRolesAsync(user);

            if (user == null)
            {
                ModelState.AddModelError("", "Hesap Yoxdu");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (result.Succeeded)
            {
                foreach (var roles in role)
                {
                    if (roles == "Admin")
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else if (roles == "User")
                    {
                        return RedirectToAction("Index", "User");
                    }
                }
            }

            ModelState.AddModelError("", "Username ve yaxud parol sehvdir");

            return View(model);
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model,IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (file != null)
            {

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                coursephotouri = await _storageService.UploadPhoto(file);
            }

            var user = new User()
            {
                
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email,
                ImageUrl=coursephotouri.ToString()
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                //var url = Url.Action("ConfirmEmail", "Account", new { UserId = user.Id, token = code });

                //await _emailSender.SendEmailAsync(model.Email, "Hesabi Dogrulayin", $" Linke tiklayin <a href='https://localhost:27357{url}'>Onayla</a>");

               await _userManager.AddToRoleAsync(user, "Users");

                return RedirectToAction("Login", "Account");


            }


            ModelState.AddModelError("", "Error");

            //TempData.Add("messages", "Registration can not successfully");
            return View(model);

        }


        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Login");
        }
    }
}
