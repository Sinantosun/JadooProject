using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
