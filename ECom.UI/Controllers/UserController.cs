

//using ECom.UI.Models.ViewModels;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using System.Threading.Tasks;

//namespace ECom.UI.Controllers
//{
//    public class UserController : Controller
//    {
//        private readonly UserManager<IdentityUser> _userManager;
//        private readonly SignInManager<IdentityUser> _signInManager;

//        public UserController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//        }

//        // GET: /User/Register
//        public IActionResult Register()
//        {
//            return View();
//        }

//        // POST: /User/Register
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Register(UserRegisterViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                var user = new IdentityUser
//                {
//                    UserName = model.Username,
//                    Email = model.Email
//                };

//                var result = await _userManager.CreateAsync(user, model.Password);

//                if (result.Succeeded)
//                {
//                    // Assign role based on username
//                    if (model.Username.ToLower() == "admin")
//                    {
//                        await _userManager.AddToRoleAsync(user, "Admin");
//                    }
//                    else
//                    {
//                        await _userManager.AddToRoleAsync(user, "Customer");
//                    }

//                    return RedirectToAction("Login", "User");
//                }

//                foreach (var error in result.Errors)
//                {
//                    ModelState.AddModelError("", error.Description);
//                }
//            }

//            return View(model);
//        }

//        // GET: /User/Login
//        public IActionResult Login()
//        {
//            return View();
//        }

//        // POST: /User/Login
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Login(LoginViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: false);

//                if (result.Succeeded)
//                {
//                    var user = await _userManager.FindByNameAsync(model.Username);
//                    var roles = await _userManager.GetRolesAsync(user);

//                    if (roles.Contains("Admin"))
//                    {
//                        return RedirectToAction("Index", "AdminProduct");
//                    }
//                    else
//                    {
//                        return RedirectToAction("Index", "Home");
//                    }
//                }

//                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
//            }

//            return View(model);
//        }

//        // POST: /User/Logout
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Logout()
//        {
//            await _signInManager.SignOutAsync();
//            return RedirectToAction("Login", "User");
//        }

//        // GET: /User/AccessDenied
//        public IActionResult AccessDenied()
//        {
//            return View();
//        }
//    }
//}


using ECom.UI.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECom.UI.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: /User/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /User/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Username,
                    Email = model.Email
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    // ✅ Assign role based on username
                    var role = model.Username.ToLower() == "admin" ? "Admin" : "Customer";
                    await _userManager.AddToRoleAsync(user, role);

                    return RedirectToAction("Login", "User");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        // GET: /User/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /User/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(model.Username);
                    var roles = await _userManager.GetRolesAsync(user);

                    if (roles.Contains("Admin"))
                    {
                        return RedirectToAction("Index", "AdminProduct");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }

            return View(model);
        }

        // POST: /User/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "User");
        }

        // GET: /User/AccessDenied
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
