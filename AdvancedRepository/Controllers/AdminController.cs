using Microsoft.AspNetCore.Mvc;

namespace AdvancedRepository.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
