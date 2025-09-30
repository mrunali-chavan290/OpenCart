using Microsoft.AspNetCore.Mvc;

namespace ECom.UI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
