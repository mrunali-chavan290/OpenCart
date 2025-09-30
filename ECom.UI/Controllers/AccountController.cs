using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECom.UI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public IActionResult Profile()
        {
            ViewBag.Username = User.Identity.Name;
            return View();
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }


        public IActionResult EditProfile()
        {
            var username = User.Identity.Name;
            ViewBag.Username = username;
            return View();
        }

        public IActionResult Logout()
        {
            // Add logout logic here
            return RedirectToAction("Index", "Home");
        }
    }
}


