using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Green_Back_End.Models;
using Green_Back_End.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Green_Back_End.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _manager;
        private readonly SignInManager<AppUser> _signIn;

        public AccountController(UserManager<AppUser> manager,SignInManager<AppUser> signIn)
        {
            _manager = manager;
            _signIn = signIn;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            AppUser user = new AppUser
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
                UserName = register.Username
            };

            IdentityResult result = await _manager.CreateAsync(user, register.Password);
            if (!result.Succeeded)
            {
                foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Login(LoginVM login)
        {
            AppUser user = await _manager.FindByNameAsync(login.Username);

            Microsoft.AspNetCore.Identity.SignInResult identityResult = await _signIn.PasswordSignInAsync(user, login.Password, false, false);

            if (!identityResult.Succeeded)
            {
                ModelState.AddModelError("", "Incorrect password or username");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signIn.SignOutAsync();

            return RedirectToAction("Index","Home");
        }

        public async Task<IActionResult> Edit()
        {
            AppUser user = await _manager.FindByNameAsync(User.Identity.Name);

            EditVM edit = new EditVM
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.UserName,
                Email = user.Email
               
            };


            return View(edit);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(EditVM user)
        {
            AppUser existed = await _manager.FindByNameAsync(User.Identity.Name);

            EditVM editUser = new EditVM
            {
                FirstName = existed.FirstName,
                LastName = existed.LastName,
                Username = existed.UserName
            };

            if (!ModelState.IsValid) return View(editUser);

            bool result = user.ConfirmPassword == null && user.NewPassword == null && user.CurrentPassword != null;

            if(user.Email == null || user.Email != existed.Email)
            {
                ModelState.AddModelError("", "Email mustn't changed");
                return View(editUser);
            }

            if (result)
            {
                existed.FirstName = user.FirstName;
                existed.LastName = user.LastName;
                existed.UserName = user.Username;
                await _manager.UpdateAsync(existed);

            }
            else
            {
                existed.FirstName = user.FirstName;
                existed.LastName = user.LastName;
                existed.UserName = user.Username;

                IdentityResult identityResult = await _manager.ChangePasswordAsync(existed, user.CurrentPassword, user.NewPassword);
                if (!identityResult.Succeeded)
                {
                    foreach(IdentityError error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(editUser);
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
