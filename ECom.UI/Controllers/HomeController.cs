//using ECom.UI.Models;
//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;

//namespace ECom.UI.Controllers
//{
//    public class HomeController : Controller
//    {
//        public IActionResult Index()
//        {
//            // ✅ Add username to ViewBag if user is logged in
//            if (User.Identity.IsAuthenticated)
//            {
//                ViewBag.Username = User.Identity.Name;
//            }

//            var categories = new List<CategoryViewModel>
//            {
//                new CategoryViewModel { Name = "Mobiles & Tablets", ImagePath = "~/Images/Mobile.png" },
//                new CategoryViewModel { Name = "TVs & Appliances", ImagePath = "~/Images/TV.png" },
//                new CategoryViewModel { Name = "Electronics", ImagePath = "~/Images/Washing-machine.png" },
//                new CategoryViewModel { Name = "Fashion", ImagePath = "~/Images/Fashion.png" },
//                new CategoryViewModel { Name = "Home & Kitchen", ImagePath = "~/Images/Home and Kitchen.png" },
//                new CategoryViewModel { Name = "Beauty & Toys", ImagePath = "~/Images/Beauty.png" },
//            };

//            return View(categories);
//        }

//        public IActionResult Fashion()
//        {
//            var fashionItems = new List<string>
//            {
//                "Men's Wear",
//                "Women's Wear",
//                "Kids Fashion",
//                "Footwear",
//                "Accessories"
//            };

//            return View(fashionItems);
//        }
//    }
//}

using ECom.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECom.UI.Controllers
{
    [Authorize] // ✅ This ensures only logged-in users can access this controller
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // ✅ Add username to ViewBag if user is logged in
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.Username = User.Identity.Name;
            }

            var categories = new List<CategoryViewModel>
            {
                new CategoryViewModel { Name = "Mobiles & Tablets", ImagePath = "~/Images/Mobile.png" },
                new CategoryViewModel { Name = "TVs & Appliances", ImagePath = "~/Images/TV.png" },
                new CategoryViewModel { Name = "Electronics", ImagePath = "~/Images/Washing-machine.png" },
                new CategoryViewModel { Name = "Fashion", ImagePath = "~/Images/Fashion.png" },
                new CategoryViewModel { Name = "Home & Kitchen", ImagePath = "~/Images/Home and Kitchen.png" },
                new CategoryViewModel { Name = "Beauty & Toys", ImagePath = "~/Images/Beauty.png" },
            };

            return View(categories);
        }

        public IActionResult Fashion()
        {
            var fashionItems = new List<string>
            {
                "Men's Wear",
                "Women's Wear",
                "Kids Fashion",
                "Footwear",
                "Accessories"
            };

            return View(fashionItems);
        }
    }
}
