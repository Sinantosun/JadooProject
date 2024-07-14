using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.UILayout
{
    public class _UILayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
