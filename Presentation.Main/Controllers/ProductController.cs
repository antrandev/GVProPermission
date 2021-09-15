using Microsoft.AspNetCore.Mvc;

namespace Presentation.Main.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}