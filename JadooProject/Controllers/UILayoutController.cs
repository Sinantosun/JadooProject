using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
