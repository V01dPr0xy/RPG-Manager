using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RPG_Manager.Areas.RPGArea.Models;
using RPG_Manager.Areas.RPGArea.Models.Authorizational_Classes;
using RPG_Manager.Controllers;

namespace RPG_Manager.Areas.RPGArea.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class AuthorizationAccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthorizationAccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnURL = null)
        {
            ViewData["ReturnUrl"] = returnURL;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel lvm, string returnURL = null)
        {
            ViewData["ReturnUrl"] = returnURL;
            if (ModelState.IsValid)
            {
                var usurper = new ApplicationUser { UserName = lvm.LoginString, Email = lvm.LoginString };
                var result = await _userManager.CreateAsync(usurper, lvm.Password);
                if (result.Succeeded)
                {
                    Console.WriteLine("Is user logged in? " + User);
                    await _signInManager.SignInAsync(usurper, isPersistent: false);
                    if (Url.IsLocalUrl(returnURL))
                        return Redirect(returnURL);
                    else
                        return RedirectToAction(nameof(HomeController.Index), "Home");
                }
                else
                    foreach (var err in result.Errors)
                        ModelState.AddModelError(string.Empty, err.Description);
            }
            return View(lvm);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnURL = null)
        {
            //Log out any users currently logged in
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);


            ViewData["ReturnUrl"] = returnURL;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel lvm, string returnURL = null)
        {
            ViewData["ReturnUrl"] = returnURL;
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(lvm.LoginString, lvm.Password, lvm.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    if (Url.IsLocalUrl(returnURL))
                        return Redirect(returnURL);
                    else
                        return RedirectToAction(nameof(HomeController.Index), "Home");
                }
                //if (SignInResult.IsLockedOut)
            }
            else
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            return View(lvm);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}