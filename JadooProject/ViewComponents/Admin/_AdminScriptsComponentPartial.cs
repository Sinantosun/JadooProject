using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Admin
{
    public class _AdminScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
