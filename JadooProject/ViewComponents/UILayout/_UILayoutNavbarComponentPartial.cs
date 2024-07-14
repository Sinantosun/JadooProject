using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.UILayout
{
    public class _UILayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
