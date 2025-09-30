using Microsoft.AspNetCore.Mvc;

namespace ECom.UI.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}