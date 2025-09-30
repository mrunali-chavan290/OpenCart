

//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Authentication.Cookies;
//using System.Threading.Tasks;

//namespace ECom.UI.Controllers
//{
//    [Authorize]
//    public class AdminController : Controller

//    {
//        // GET: /Account/Profile
//        public IActionResult Profile()
//        {
//            ViewBag.Username = User.Identity.Name;
//            return View(); // Views/Account/Profile.cshtml
//        }

//        // GET: /Account/EditProfile
//        public IActionResult EditProfile()
//        {
//            ViewBag.Username = User.Identity.Name;
//            return View(); // Views/Account/EditProfile.cshtml
//        }

//        // GET: /Account/Register (not used if Register.cshtml is under Views/User)
//        [AllowAnonymous]
//        public IActionResult Register()
//        {
//            if (User.Identity.IsAuthenticated)
//            {
//                return RedirectToAction("Index", "Home");
//            }

//            // Redirect to UserController's Register view
//            return RedirectToAction("Register", "User");
//        }

//        // POST: /Account/Logout
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Logout()
//        {
//            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
//            return RedirectToAction("Login", "User"); // Redirect to login page in UserController
//        }
//    }
//}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Threading.Tasks;

namespace ECom.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        // GET: /Admin/EditProfile
        public IActionResult EditProfile()
        {
            ViewBag.Username = User.Identity.Name;
            return View(); // Views/Account/EditProfile.cshtml
        }

        // GET: /Admin/Register
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Register", "User");
        }

        // POST: /Admin/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "User");
        }
    }
}
