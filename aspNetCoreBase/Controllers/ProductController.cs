using Microsoft.AspNetCore.Mvc;

namespace aspNetCoreBase.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
