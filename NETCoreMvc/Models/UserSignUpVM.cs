using System.ComponentModel.DataAnnotations;

namespace NETCoreMvc.Models
{
    public class UserSignUpVM
    {
        [Display(Name="Name")]
        [Required(ErrorMessage="Please Enter your Name")]
        public string Name { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please Enter your Username")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter your Password")]
        public string Password { get; set; }

        [Display(Name = "ConfirmPassword")]
        [Compare("Password",ErrorMessage ="Passwords are not same")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please Enter your Email")]
        public string Email { get; set; }
    }
}
