using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCoreMvc.Models;

namespace NETCoreMvc.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager=userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Index(UserSignUpVM userSignUpVM)
        {
            if(ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    UserName=userSignUpVM.Username,
                    Email=userSignUpVM.Email,
                    Name=userSignUpVM.Name,
                   
                };
                var result= await _userManager.CreateAsync(user,userSignUpVM.Password);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index","Login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(userSignUpVM);
        }
    }
}
