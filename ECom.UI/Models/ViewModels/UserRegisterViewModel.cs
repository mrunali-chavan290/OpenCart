
//using System.ComponentModel.DataAnnotations;

//namespace ECom.UI.Models.ViewModels
//{
//    public class UserRegisterViewModel
//    {
//        [Required(ErrorMessage = "Username is required")]
//        public string Username { get; set; }

//        [Required(ErrorMessage = "Email is required")]
//        [EmailAddress(ErrorMessage = "Invalid Email Address")]
//        public string Email { get; set; }

//        [Required(ErrorMessage = "Password is required")]
//        [DataType(DataType.Password)]
//        public string Password { get; set; }
//    }
//}


using System.ComponentModel.DataAnnotations;

namespace ECom.UI.Models.ViewModels
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
