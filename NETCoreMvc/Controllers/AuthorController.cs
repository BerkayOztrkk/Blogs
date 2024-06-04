using BusinessLayer.Concretes;
using BusinessLayer.Validations;
using DataAccessLayer;
using DataAccessLayer.Concretes.Repositories;
using EntityLayer.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCoreMvc.Models;

namespace NETCoreMvc.Controllers
{
	[Authorize]
	public class AuthorController : Controller
	{
		AuthorManager authorManager=new AuthorManager(new AuthorRepository());
        private readonly UserManager<AppUser> _userManager;

        public AuthorController(UserManager<AppUser> userManager)
        {
            _userManager=userManager;
        }

        public IActionResult Index()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult Deneme()
		{
			return View();
		}
        [AllowAnonymous]
        public PartialViewResult PartialNavBar()
		{
			return PartialView();
		}
        [AllowAnonymous]
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
       
		[HttpGet]
        public async Task< IActionResult> EditProfile()
        {
           
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateVM userUpdateVM = new UserUpdateVM();
            userUpdateVM.name=values.Name;
            userUpdateVM.username=values.UserName;
            userUpdateVM.email=values.Email;
        
            return View(userUpdateVM);
        }
        
        [HttpPost]
        public async Task< IActionResult> EditProfile(UserUpdateVM userUpdateVM)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
           
           values.Name=userUpdateVM.name;
           values.UserName=userUpdateVM.username;
           values.Email=userUpdateVM.email;
            values.PasswordHash=_userManager.PasswordHasher.HashPassword(values, userUpdateVM.password);
            var result=await _userManager.UpdateAsync(values);
           
            
                return RedirectToAction("Index", "Dashboard");
          
       
               
            
               
        }
    }
}
