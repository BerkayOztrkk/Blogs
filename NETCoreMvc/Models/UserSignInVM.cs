using System.ComponentModel.DataAnnotations;

namespace NETCoreMvc.Models
{
    public class UserSignInVM
    {
        [Required(ErrorMessage ="Please enter your username")]
        public string username { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string password { get; set; }
    }
}
