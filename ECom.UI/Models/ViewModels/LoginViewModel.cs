

//using System.ComponentModel.DataAnnotations;

//namespace ECom.UI.Models.ViewModels
//{
//    public class LoginViewModel
//    {
//        [Required]
//        public string Username { get; set; }

//        [Required]
//        [DataType(DataType.Password)]
//        public string Password { get; set; }

//        public bool RememberMe { get; set; }
//    }
//}


using System.ComponentModel.DataAnnotations;

namespace ECom.UI.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}

