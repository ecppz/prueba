using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class Banking : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
