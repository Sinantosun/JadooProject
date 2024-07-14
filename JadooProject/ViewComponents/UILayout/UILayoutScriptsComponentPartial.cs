using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.UILayout
{
    public class UILayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
